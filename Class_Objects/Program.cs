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

        
        
    }

    class Program{
       static void Main(String[] args){
           car car1 = new car("honda", "insight", 2019);

           //tesla tesla1 = new tesla("models");

           
           Console.WriteLine(car1.make);
       }
    }    

  
}