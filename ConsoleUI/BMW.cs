using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleUI
{
    public class BMW : Car
    {
        private string Brand = "BMW";

        public string Model { get; set; }

        public BMW(int hp, string color, string model) : base (hp, color)
        {
            this.Model = model;
        }

        public override void ShowDetails()
        {
            WriteLine($"Brnd: {Brand} HP: {this.HP} Color: {this.Color}");
        }

        public override void Repair()
        {
            WriteLine($"The {Brand} was repaired.");
        }

    }
}
