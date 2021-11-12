using System;

namespace FridayNightRandom
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayRandomFood();
            DisplayRandomDrink();
            DisplayRandomMovie();
        }

        private static int GenerateRandomIndex(string[] someArray)
        {
            Random rnd = new Random();

            int randomIndex = rnd.Next(0, someArray.Length);

            return randomIndex;
        }

        private static void DisplayRandomFood()
        {
            string[] foods = { "chicken wings", "pizza", "sushi", "popcorn", "salad" };

           // int randomIndex = GenerateRandomIndex(foods);

          //  string randomFood = foods[randomIndex];
            Console.WriteLine($"COMPUTER PICKED: {foods[GenerateRandomIndex(foods)]}");
        }

        private static void DisplayRandomDrink()
        {
            string[] drinks = { "apple juice", "coke", "fanta", "sprite" };
            
            Console.WriteLine($"COMPUTER PICKED: {drinks[GenerateRandomIndex(drinks)]}");
        }

        private static void DisplayRandomMovie()
        {
            string[] movies = { "Disney Movie", "Comedy Movie", "Horror Movie", "Action Movie" };
            Console.WriteLine($"COMPUTER PICKED: {movies[GenerateRandomIndex(movies)]}");
        }
    }
}
