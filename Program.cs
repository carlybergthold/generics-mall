using System;

namespace TheMall
{
    class Program
    {
        static void Main(string[] args)
        {
            DollarStore Dollarama = new DollarStore();

            DollarItem MultiColoredPen = new DollarItem() { Name = "Multi-Colored Pen with 12 Colors" };

            Dollarama.AddToInventory("mcp", MultiColoredPen);

            FoodStore Cinnabon = new FoodStore() { Name = "Cinnabon" };

            FoodItem ClassicRoll = new FoodItem() {
                Name = "Classic Roll",
                Price = 3.50,
                Calories = 880
            };

            FoodItem CaramelPecanBun = new FoodItem() {
                Name = "Caramel Pecan Bun",
                Price = 6,
                Calories = 1080
            };

            Cinnabon.AddToInventory("tcr", ClassicRoll);
            Cinnabon.AddToInventory("cpb", CaramelPecanBun);

            Console.WriteLine(Dollarama.GetFromInventory("mcp").Name);
            Console.WriteLine(Cinnabon.GetFromInventory("tcr").Name);

        }
    }
}
