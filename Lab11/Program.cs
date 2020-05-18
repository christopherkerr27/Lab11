using System;
using System.Collections.Generic;

namespace Lab11
{
    class Program
    {
        static void Main(string[] args)
        {
            var movies = new Dictionary<string, string>();
            movies.Add("The Wizard of Oz", "Drama");
            movies.Add("Toy Story", "Animated");
            movies.Add("Casablanca", "Drama");
            movies.Add("The Hunt", "Horror");
            movies.Add("Despicable Me", "Animated");
            movies.Add("Spiderman", "Animated");
            movies.Add("Star Wars", "Scifi");
            movies.Add("The Lodge", "Horror");
            movies.Add("King Kong", "Scifi");
            movies.Add("Us", "Horror");

            Console.WriteLine("Welcome to the Movie List Application!");
            Console.WriteLine("There are 10 movies in the list.");
            Console.WriteLine("What category are yoiu interested in?");
            string v = Console.ReadLine();
            string category = v;


            {
                System.Console.WriteLine(movies);
            }
        }


    }

}

