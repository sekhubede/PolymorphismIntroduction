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

        public Car(int hp, string color)
        {
            this.HP = hp;
            this.Color = color;
        }

        public virtual void ShowDetails()
        {
            WriteLine($"HP: {this.HP} Color: {this.Color}");
        }

        public virtual void Repair()
        {
            WriteLine("Car was repaired.");
        }
    }
}
