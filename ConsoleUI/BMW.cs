using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleUI
{
    sealed public class BMW : Car
    {
        private string Brand = "BMW";

        public string Model { get; set; }

        // default constructor
        public BMW()
        {

        }

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
        // sealed, prevents deriving classes to override this method.
        // cannot be used on a virtual method.
        public sealed override void Repair()
        {
            WriteLine($"The {Brand} {Model} was repaired.");
        }

    }
}
