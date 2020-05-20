using System;
using System.Collections.Generic;

namespace Lab11
{
    class Program
    {
        static void Main(string[] args)
        {
            var movieList = new List<Movie> {
            new Movie("The Wizard of Oz", $"{ Category.Drama}"),
            new Movie("Toy Story", $"{ Category.Animated}"),
            new Movie("Casablanca",$"{ Category.Drama}"),
            new Movie("The Hunt", $"{ Category.Horror}"),
            new Movie("Despicable Me", $"{ Category.Animated}"),
            new Movie("Spiderman", $"{ Category.Animated}"),
            new Movie("Star Wars", $"{ Category.Drama}"),
            new Movie("The Lodge", $"{ Category.Drama}"),
            new Movie("King Kong",$"{ Category.Animated}"),
            new Movie("Us",$"{ Category.Horror}"),
        };
            Console.WriteLine("Welcome to the Movie List Application!");
            Console.WriteLine("There are 10 movies in the list.");
            do
            {
                Console.WriteLine("What category are yoiu interested in?");
                string v = Console.ReadLine();
                string choice = v;
                foreach (var Movie in movieList)
                {
                    if (Movie.GetCategory() == $"{choice}")

                        Console.WriteLine(Movie.GetTitle());
                }
                Console.WriteLine("Do you want to continue? (y/n)");

            }

            while
            (Console.ReadLine() == "y");

            {
                Console.WriteLine("Thank you!");
            }


        }
    }
}
















