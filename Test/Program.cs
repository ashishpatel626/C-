// See https://aka.ms/new-console-template for more information
using System;

namespace Program{
    class test{
        static void Main(string[] args){
            string[] cars;
            cars = new string[] {"honda"};

            Console.WriteLine(cars[0]);
            
            for (int i = 0; i < cars.Length; i++){
                Console.WriteLine(cars[i]);
            }
        }
    }
}