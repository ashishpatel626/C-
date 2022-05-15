using System;

namespace Program
{
    public class Person{
        public string Name = "";
        public int Age;
        public bool HasPet;

        public int Calc(int x, int y){
            int number = x + y;
            return number;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person sam = new Person();
            sam.Name = "sam";
            sam.Age = 3;
            sam.HasPet = true;
            
            int t = sam.Calc(3, 4);
            Console.WriteLine(t);
        }
    }
}