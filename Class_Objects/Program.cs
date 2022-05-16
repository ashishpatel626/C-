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

    public interface design
    {
        string animal{get; set;};
        
    }

    public class electricCar : car
    {
       public override void hello()
       {
           Console.WriteLine("helo world");
       }
    }

    class Program
    {
       static void Main(String[] args)
       {
            car car1 = new car("honda", "insight", 2019);
            electricCar car2 = new electricCar();
            car2.hello();

            Console.WriteLine(car1.make);
       }
    }   
}