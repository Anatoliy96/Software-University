using System;
using System.Collections.Generic;
using System.Linq;

namespace ClothesMagazine
{
    public class Magazine
    {
        public Magazine(string type, int capacity)
        {
            Type = type;
            Capacity = capacity;
            Clothes = new List<Cloth>();
        }

        public string Type { get; set; }
        public int Capacity { get; set; }
        public List<Cloth> Clothes { get; set; }

        public void AddCloth(Cloth cloth)
        {
            Clothes.Add(cloth);
        }
        public bool RemoveCloth(string color)
        {
            Cloth clothToRemove = Clothes.FirstOrDefault(c => c.Color == color);
            if (clothToRemove != null)
            {
                Clothes.Remove(clothToRemove);
                return true;
            }
            return false;
        }

        public Cloth GetSmallestCloth()
        {
            return Clothes.OrderBy(c => c.Size).FirstOrDefault();
        }

        public Cloth GetCloth(string color)
        {
            return Clothes.FirstOrDefault(c => c.Color == color);
        }

        public int GetClothCount()
        {
            return Clothes.Count;
        }

        public string Report()
        {
            string result = $"{Type} magazine contains:";
            foreach (var cloth in Clothes.OrderBy(c => c.Size))
            {
                result += Environment.NewLine + cloth.ToString();
            }
            return result;
        }
    }
}
