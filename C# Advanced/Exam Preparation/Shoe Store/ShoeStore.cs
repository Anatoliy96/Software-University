using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShoeStore
{
    public class ShoeStore
    {
        public ShoeStore(string name, int storageCapacity)
        {
            Name = name;
            StorageCapacity = storageCapacity;
            Shoes = new List<Shoe>();
        }
        public string Name { get; set; }
        public int StorageCapacity { get; set; }
        public int Count { get { return Shoes.Count; } }
        public List<Shoe> Shoes { get; set; }

       
        public string AddShoe(Shoe shoe)
        {
            if (Count == StorageCapacity)
            {
                return "No more space in the storage room.";
            }

            Shoes.Add(shoe);

            return $"Successfully added {shoe.Type} {shoe.Material} pair of shoes to the store.";
            
        }

        public int RemoveShoes(string material)
        {
            List<Shoe> shoesToRemove = Shoes.Where(s => s.Material == material).ToList();
            int countOfRemovedShoes = 0;

            foreach (var shoe in shoesToRemove)
            {
                Shoes.Remove(shoe);
                countOfRemovedShoes++;
            }

            return countOfRemovedShoes;
        }
        public List<Shoe> GetShoesByType(string type)
        {
            List<Shoe> matchingShoes = Shoes.Where(s => s.Type.ToLower() == type.ToLower()).ToList();
            return matchingShoes;
        }

        public Shoe GetShoeBySize(double size)
        {
            Shoe shoe = Shoes.FirstOrDefault(s => s.Size == size);
            return shoe;
        }

        public string StockList(double size, string type)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Stock list for size {size} - {type} shoes:");
            bool matchedShoes = false;

            foreach (Shoe shoe in Shoes.Where(s => s.Size == size && s.Type == type))
            {
                sb.AppendLine(shoe.ToString());
                matchedShoes = true;
            }

            if (!matchedShoes)
            {
                return "No matches found!";
            }
            return sb.ToString().TrimEnd();
        }
    }
}
