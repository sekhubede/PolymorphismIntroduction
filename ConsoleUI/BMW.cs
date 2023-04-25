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

        // new keyword states that this method has priority over the
        // base class method if object created from this class else use base class method.
        public new void ShowDetails()
        {
            WriteLine($"Brand: {Brand} HP: {this.HP} Color: {this.Color}");
        }

        // override, overrides the base class method.
        public override void Repair()
        {
            WriteLine($"The {Brand} {Model} was repaired.");
        }

    }
}
