using EDriveRent.Models;
using EDriveRent.Models.Contracts;
using EDriveRent.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDriveRent.Repositories
{
    public class UserRepository : IRepository<IUser>
    {
        private readonly List<IUser> users;

        public UserRepository()
        {
            users = new List<IUser>();
        }

        public void AddModel(IUser model)
        {
            users.Add(model);
        }

        public IUser FindById(string identifier)
        {
            return this.users.FirstOrDefault(u => u.DrivingLicenseNumber == identifier);
        }

        public IReadOnlyCollection<IUser> GetAll()
        {
            return users;
        }

        public bool RemoveById(string identifier)
        {
            var userToRemove = users.Find(u => u.DrivingLicenseNumber == identifier);

            if (userToRemove != null)
            {
                users.Remove(userToRemove);
                return true;
            }

            return false;
        }
    }
}
