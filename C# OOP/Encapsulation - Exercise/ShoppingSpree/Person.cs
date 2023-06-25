using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingSpree
{
    public class Person
    {
		private string name;
        private decimal money;
        private List<Product> bagOfProducts;

        public Person(string name, decimal money)
        {
            Name = name;
			Money = money;
			BagOfProducts = new List<Product>();
        }

        public string Name
		{
			get { return name; }
			private set 
			{ 
				if (string.IsNullOrWhiteSpace(value))
				{
					throw new ArgumentNullException("Name cannot be empty");
				}
				name = value; 
			}
		}
		
		public decimal Money
		{
			get { return money; }
			private set 
			{
				if (value < 0)
				{
					throw new ArgumentException("Money cannot be negative");
				}
				money = value; 
			}
		}

		public List<Product> BagOfProducts
		{
			get { return bagOfProducts; }
			set { bagOfProducts = value; }
		}

        public string Add(Product product)
        {
            if (Money < product.Cost)
            {
                return $"{Name} can't afford {product.Name}";
            }

            bagOfProducts.Add(product);

            Money -= product.Cost;

            return $"{Name} bought {product.Name}";
        }

        public override string ToString()
        {
            string productsString = bagOfProducts.Any()
                 ? string.Join(", ", bagOfProducts.Select(p => p.Name))
                 : "Nothing bought";

            return $"{Name} - {productsString}";
        }
    }
}
