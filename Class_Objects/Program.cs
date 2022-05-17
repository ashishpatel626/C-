using System;

namespace Class_Objects
{
    public class car
    {
        public string make;
        public string model;
        public int year;

        public car(string aMake, string aModel, int aYear)
        {
            make = aMake;
            model = aModel;
            year = aYear;
        }

        public virtual void hello()
        {
            Console.WriteLine("hello world");
        }
    }

    public class electricCar : car
    {

        public electricCar(string aMake, string aModel, int aYear)
        {
            make = aMake;
            model = aModel;
            year = aYear;
        }

        public void print()
        {
            Console.WriteLine("print");
        }
    }

    class Program
    {
       static void Main(String[] args)
       {
            car car1 = new car("honda", "insight", 2019);
            electricCar car2 = new electricCar("honda", "insight", 2019);
       }
    }   
}