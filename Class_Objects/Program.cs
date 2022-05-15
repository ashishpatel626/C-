using System;

namespace Program {
    public class car{
        public string make = "";
        public string model = "";
        public int year; 

        public int num(){
            return 1;
        }
    }

    public class tesla : car {
        
    }


    class tuples{
       static void Main(String[] args){
           car car1 = new car();
           car1.make = "toyota";
           car1.model = "ravenger";
           car1.year = 2025;

           tesla tesla1 = new tesla();
           tesla1.make = "hello";

           
           Console.WriteLine(tesla1.make);
       }
    }    
}