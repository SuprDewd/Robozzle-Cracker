using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RobozzleCracker;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Tile[,] tiles = new Tile[2, 2]
            {
                {new Tile(Color.Red, true), new Tile()},
                {new Tile(Color.Red, true), new Tile(Color.Red, true)}
            };

            Robot robot = new Robot(0, 0);

            Instruction[][] functions =
            {
                new Instruction[] { new ChangeColor(Color.Red), new ChangeColor(Color.Blue) },
                new Instruction[] { new ChangeColor(Color.Green), new ChangeColor(Color.Red) }
            };

            Robozzle robozzle = new Robozzle(tiles, robot, functions, Color.Red | Color.Green | Color.Blue);
        }
    }
}
