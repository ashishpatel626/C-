using System;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            dog kujo = new dog("Male", "Pitbull", 5);
            cat kity = new cat("Female", "N/A", 3, "p");
            Length len1 = new Length(2, 8);
            Length len2 = new Length(4, 5);

            Length len3 = len1 + len2;
            
            Console.WriteLine(len1.GetLength());
            Console.WriteLine(len2.GetLength());
            Console.WriteLine(len3.GetLength());

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
            int result = x * y;
            return result;
        }

        public int product(int x, int y, int z)
        {
            int result = x * y * z;
            return result;
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

        public int product(int x, int y, int z, int a)
        {
            int result = x * y * z * a;
            return result;
        }
    }

    class Length
    {
        int feet, inch;
        public Length()
        {
            this.feet = 0;
            this.inch = 0;
        }

        public static Length operator +(Length l1, Length l2)
        {
            Length l3 = new Length();
            l3.feet = l1.feet + l2.feet;
            l3.inch = l1.inch + l3.feet;
            if (l3.inch >= 12)
            {
                l3.feet++;
                l3.inch -= 12;
            }
            return l3;
        }

        public Length(int feet, int inch)
        {
            this.feet = feet;
            this.inch = inch;
        }

        public string GetLength()
        {
            return string.Format("Length: {0}' {1}\"", feet, inch);
        }
    }
}
