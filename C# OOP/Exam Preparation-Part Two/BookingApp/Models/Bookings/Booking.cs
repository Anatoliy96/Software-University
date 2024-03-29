﻿using BookingApp.Models.Bookings.Contracts;
using BookingApp.Models.Rooms.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingApp.Models.Bookings
{
    public class Booking : IBooking
    {
        private int residenceDuration;
        private int adultsCount;
        private int childrenCount;
        private int bookingNumber;
        private IRoom room;

        public Booking(IRoom room, int residenceDuration, int adultsCount, int childrenCount, int bookingNumber)
        {
            Room = room;
            ResidenceDuration = residenceDuration;
            AdultsCount = adultsCount;
            ChildrenCount = childrenCount;
            BookingNumber = bookingNumber;
        }

        public IRoom Room { get => room; private set => room = value; }

        public int ResidenceDuration
        {
            get => residenceDuration;
            private set
            {
                if (value <= 0)
                {
                    throw new ArithmeticException("Duration cannot be negative or zero!");
                }
                residenceDuration = value;
            }
        }

        public int AdultsCount
        {
            get => adultsCount; 
            private set
            {
                if (value < 1)
                {
                    throw new ArithmeticException("Adults count cannot be negative or zero!");
                }
                adultsCount = value;
            }
        }

        public int ChildrenCount
        {
            get => childrenCount;
            private set
            {
                if (value < 0)
                {
                    throw new ArithmeticException("Children count cannot be negative!");
                }
                childrenCount = value;
            }
        }

        public int BookingNumber { get => bookingNumber; private set => bookingNumber = value; }

        public string BookingSummary()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Booking number: {BookingNumber}");
            sb.AppendLine($"Room type: {Room.GetType().Name}");
            sb.AppendLine($"Adults: {AdultsCount} Children: {ChildrenCount}");
            sb.AppendLine($"Total amount paid: {TotalPaid():F2} $");

            return sb.ToString().TrimEnd();
        }

        private double TotalPaid()
        {
            return Math.Round(ResidenceDuration * room.PricePerNight, 2);
        }
    }
}
