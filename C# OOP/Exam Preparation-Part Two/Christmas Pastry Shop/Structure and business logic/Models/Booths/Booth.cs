using ChristmasPastryShop.Models.Booths.Contracts;
using ChristmasPastryShop.Models.Cocktails.Contracts;
using ChristmasPastryShop.Models.Delicacies.Contracts;
using ChristmasPastryShop.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChristmasPastryShop.Models.Booths
{
    public class Booth : IBooth
    {
        private readonly IRepository<IDelicacy> delicacies;
        private readonly IRepository<ICocktail> coctails;
        private int capacity;
        private double currentBill;
        private double turnover;

        public Booth(int boothId, int capacity)
        {
            BoothId = boothId;
            Capacity = capacity;
            this.currentBill = 0;
            this.turnover = 0;
            IsReserved = false;
        }

        public int BoothId { get; private set; }

        public int Capacity
        {
            get => capacity; 
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Capacity has to be greater than 0!");
                }
                capacity = value;
            }
        }

        public IRepository<IDelicacy> DelicacyMenu => this.delicacies;

        public IRepository<ICocktail> CocktailMenu => this.coctails;

        public double CurrentBill => this.currentBill;

        public double Turnover => this.turnover;

        public bool IsReserved { get; private set; }

        public void ChangeStatus()
        {
            if (IsReserved)
            {
                IsReserved = false;
            }
            else
            {
                IsReserved = true;
            }
        }

        public void Charge()
        {
            turnover += CurrentBill;
            currentBill = 0;
        }

        public void UpdateCurrentBill(double amount)
        {
            currentBill += amount;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
