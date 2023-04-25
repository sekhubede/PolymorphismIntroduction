using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleUI
{
    public class Car
    {
        public int HP { get; set; }
        public string Color { get; set; }

        // Create an instance of the CarIDInfo class.
        // has a relationship.
        protected CarIDInfo carIDInfo = new CarIDInfo();

        public void SetCarIDInfo(int idNumber, string owner)
        {
            carIDInfo.IDNumber = idNumber;
            carIDInfo.Owner = owner;
        }

        public void GetCarIDInfo()
        {
            WriteLine($"The car has the ID of {carIDInfo.IDNumber} and is owned by {carIDInfo.Owner}");
        }

        public Car()
        {

        }

        public Car(int hp, string color)
        {
            this.HP = hp;
            this.Color = color;
        }


        public void ShowDetails()
        {
            WriteLine($"HP: {this.HP} Color: {this.Color}");
        }

        // Virtual method that can be overriden by the deriving classes.
        public virtual void Repair()
        {
            WriteLine("Car was repaired.");
        }
    }
}
