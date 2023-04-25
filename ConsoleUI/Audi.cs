using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleUI
{
    // an Audi is a Car
    public class Audi : Car
    {
        private string Brand = "Audi";

        public string Model { get; set; }

        public Audi(int hp, string color, string model) : base(hp, color)
        {
            this.Model = model;
        }

        public void ShowDetails()
        {
            WriteLine($"Brand: {Brand} HP: {this.HP} Color: {this.Color}");
        }

        public override void Repair()
        {
            WriteLine($"The {Brand} {Model} was repaired.");
        }

    }
}
