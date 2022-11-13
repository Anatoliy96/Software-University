using System;

namespace _05._Movie_Ratings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfMovies = int.Parse(Console.ReadLine());
            
            double max = double.MinValue;
            double min = double.MaxValue;
            double average = 0;
            double totalRating = 0;
            string maxRatingMovie = "";
            string minRatingMovie = "";

            for (int i = 0; i < numberOfMovies; i++)
            {
                string movieName = Console.ReadLine();
                double rating = double.Parse(Console.ReadLine());

                if (rating > max)
                {
                    max = rating;
                    maxRatingMovie = movieName;
                }
                else if (rating < min)
                {
                    min = rating;
                    minRatingMovie = movieName;
                }

                totalRating += rating;


            }
            average = totalRating / numberOfMovies;

            Console.WriteLine($"{maxRatingMovie} is with highest rating: {max:f1}");
            Console.WriteLine($"{minRatingMovie} is with lowest rating: {min:f1}");
            Console.WriteLine($"Average rating: {average:f1}");
            
        }
    }
}
