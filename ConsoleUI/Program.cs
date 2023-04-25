using System;
using System.Collections.Generic;
using static System.Console;

namespace ConsoleUI
{
    internal class Program
    {
        // Challenge
        // Create a base class Car with two proerties HP and Color
        // Create a Constructor setting those two properties
        // Create a Method called ShowDetails() which shows the HP and Color of the car on the console
        // Create a Repair Method which writes "Car was repaired!" onto the console
        // Create two deriving classes, BMW and Audi, which have their own constructor and have an aditional property
        // called Model. Also a private member called brand. Brand should be different in each of the two classes.
        // Create the two methods ShowDetails() and Repair in them as well. Adjust those methods accordingly.

        static void Main(string[] args)
        {
            // A car can be a BMW, an Audi, a Porsche etc.
            // Polymorphism at work #1: an Audi, BMW, Porsche
            // can all be used where ever a Car is expected. No cast is
            // required because an implicit conversion exists from a derived
            // class to its base class.

            var cars = new List<Car>
            {
                new Audi(200, "blue", "A4"),
                new BMW(250, "red", "M3")
            };

            // Polymorphism at work #2: the virtual method Repair is
            // invoked on each of the derived classes, not the base class.

            foreach (var car in cars)
            {
                car.Repair();
            }

            WriteLine();

            Car bmwZ3 = new BMW(200, "black", "Z3");
            Car audiA3 = new Audi(100, "green", "A3");

            bmwZ3.ShowDetails();
            audiA3.ShowDetails();
            
            WriteLine();

            bmwZ3.SetCarIDInfo(1234, "Michael");
            audiA3.SetCarIDInfo(5473, "Mike");
            bmwZ3.GetCarIDInfo();
            audiA3.GetCarIDInfo();

            WriteLine();
            
            BMW bmwM5 = new BMW(330, "white", "M5");

            bmwM5.ShowDetails();

            // Casting, use the base class method on a deriving class method that has it's own method.
            Car carB = (Car)bmwM5;
            carB.ShowDetails();

            WriteLine();

            //M3 myM3 = new M3(260, "red", "M3 Super Turbo");
            //myM3.Repair();

            ReadKey(true);
        }
    }
}
