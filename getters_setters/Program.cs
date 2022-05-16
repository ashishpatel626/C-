using System;

namespace getters_setters
{
    class Program
    {
        static void Main(string[] args)
        {
            Movie Movie1 = new Movie("Lord of the rings", "tolken", 100);
            
            Console.WriteLine(Movie1.Rating);
        }
    }
}