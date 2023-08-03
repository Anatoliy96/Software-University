using EDriveRent.Core.Contracts;
using EDriveRent.Models;
using EDriveRent.Models.Contracts;
using EDriveRent.Repositories;
using EDriveRent.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDriveRent.Core
{
    public class Controller : IController
    {
        private IRepository<IUser> users;
        private IRepository<IVehicle> vehicles;
        private IRepository<IRoute> routes;

        public Controller()
        {
            this.users = new UserRepository();
            this.vehicles = new VehicleRepository();
            this.routes = new RouteRepository();
        }

        public string AllowRoute(string startPoint, string endPoint, double length)
        {
            var route = routes.GetAll()
                .FirstOrDefault(r => r.StartPoint == startPoint && r.EndPoint == endPoint && r.Length == length);

            if (route != null)
            {
                return $"{startPoint}/{endPoint} - {length} km is already added in our platform.";
            }

            route = routes.GetAll()
                .FirstOrDefault(r => r.StartPoint == startPoint && r.EndPoint == endPoint && r.Length < length);

            if (route != null)
            {
                return $"{startPoint}/{endPoint} shorter route is already added in our platform.";
            }

            route = routes.GetAll()
               .FirstOrDefault(r => r.StartPoint == startPoint && r.EndPoint == endPoint && r.Length > length);

            if (route != null)
            {
                route.LockRoute();
            }

            var allRoutes = routes.GetAll().Count();

            Route newRoute = new Route(startPoint, endPoint, length, allRoutes + 1);

            routes.AddModel(newRoute);

            return $"{startPoint}/{endPoint} - {length} km is unlocked in our platform.";
        }

        public string MakeTrip(string drivingLicenseNumber, string licensePlateNumber, string routeId, bool isAccidentHappened)
        {
            var user = users.FindById(drivingLicenseNumber);

            if (user.IsBlocked)
            {
                return $"User {drivingLicenseNumber} is blocked in the platform! Trip is not allowed.";
            }

            var vehicle = vehicles.FindById(licensePlateNumber);

            if (vehicle.IsDamaged)
            {
                return $"Vehicle {licensePlateNumber} is damaged! Trip is not allowed.";
            }

            var route = routes.FindById(routeId);

            if (route.IsLocked)
            {
                return $"Route {routeId} is locked! Trip is not allowed.";
            }

            vehicle.Drive(route.Length);

            if (isAccidentHappened)
            {
                vehicle.ChangeStatus();
                user.DecreaseRating();
            }
            else
            {
                user.IncreaseRating();
            }

            return vehicle.ToString().TrimEnd();
        }

        public string RegisterUser(string firstName, string lastName, string drivingLicenseNumber)
        {
            var userToFind = users.FindById(drivingLicenseNumber);

            if (userToFind != null)
            {
                return $"{drivingLicenseNumber} is already registered in our platform.";
            }

            User user = new User(firstName, lastName, drivingLicenseNumber);

            users.AddModel(user);

            return $"{firstName} {lastName} is registered successfully with DLN-{drivingLicenseNumber}";
        }

        public string RepairVehicles(int count)
        {
            var damagedVehicles = vehicles.GetAll()
                .Where(v => v.IsDamaged == true)
                .OrderBy(v => v.Brand).ThenBy(v => v.Model).Take(count).ToList();

            foreach (var vehicle in damagedVehicles)
            {
                vehicle.Recharge();
                vehicle.ChangeStatus();
            }

            return $"{damagedVehicles.Count} vehicles are successfully repaired!";
        }

        public string UploadVehicle(string vehicleType, string brand, string model, string licensePlateNumber)
        {
            if (vehicleType != "CargoVan" && vehicleType != "PassengerCar")
            {
                return $"{vehicleType} is not accessible in our platform.";
            }

            var vehicle = vehicles.FindById(licensePlateNumber);

            if (vehicle != null)
            {
                return $"{licensePlateNumber} belongs to another vehicle.";
            }

            if (vehicleType == "CargoVan")
            {
                vehicle = new CargoVan(brand, model, licensePlateNumber);
            }

            if (vehicleType == "PassengerCar")
            {
                vehicle = new PassengerCar(brand, model, licensePlateNumber);
            }

            vehicles.AddModel(vehicle);
            return $"{brand} {model} is uploaded successfully with LPN-{licensePlateNumber}";
        }

        public string UsersReport()
        {
            StringBuilder stringBuilder = new StringBuilder();

            var usersReport = users.GetAll().OrderByDescending(u => u.Rating).ThenBy(u => u.LastName).ThenBy(u => u.FirstName).ToList();

            stringBuilder.AppendLine("*** E-Drive-Rent ***");

            foreach (var user in usersReport)
            {
                stringBuilder.AppendLine(user.ToString());
            }

            return stringBuilder.ToString().TrimEnd();
        }
    }
}
