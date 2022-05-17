using System;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            dog kujo = new dog("Male", "Pitbull", 5);
            cat cat1 = new cat("Female", "N/A", 3, "p");
            Console.WriteLine(cat1.bark());
        }
    }

    class dog
    {
        public string gender;
        public string breed;
        public int age;

        public dog(string aGender, string aBreed, int aAge)
        {
            this.gender = aGender;
            this.breed = aBreed;
            this.age = aAge;
        }

        public string bark()
        {
            return "woof";
        }

        public int product(int x, int y)
        {
            
        }
    }

    class cat : dog
    {
        public string vet;

        public cat(string aGender, string aBreed, int aAge, string aVet)
            : base(aGender, aBreed, aAge)
        {
            vet = aVet;
        }
        new public string bark()
        {
            return "meow";
        }
    }
}
