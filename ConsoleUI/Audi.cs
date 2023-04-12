using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleUI
{
    public class Audi : Car
    {
        private string Brand = "Audi";

        public string Model { get; set; }

        public Audi(int hp, string color, string model, string brand) : base(hp, color)
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
