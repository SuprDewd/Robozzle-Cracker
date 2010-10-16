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
            Instruction[] funcs = {
                                      null,
                                      new MoveRobot(),
                                      new TurnRobot(Direction.Left),
                                      new TurnRobot(Direction.Right)
                                  };

            var brute = from i1 in funcs
                        from i2 in funcs
                        from i3 in funcs
                        from i4 in funcs
                        from i5 in funcs
                        from i6 in funcs
                        let array = new Instruction[] { i1, i2, i3, i4, i5, i6 }
                        where new Robozzle(new Tile[2, 2]
            {
                {new Tile(Color.Red, true), new Tile()},
                {new Tile(Color.Red, true), new Tile(Color.Red, true)}
            }, new Robot(0, 0), new Instruction[][] { array }).Run()
                        select array;

            var solution = brute.First();
            Console.WriteLine("Solution: ");
            foreach (Instruction func in solution)
            {
                Console.WriteLine(func != null ? func.ToString() : "");
            }


            Console.ReadLine();
        }

        static void PrintBoard(Robozzle r)
        {
            for (int i = 0; i < r.Board.GetLength(0); i++)
            {
                for (int j = 0; j < r.Board.GetLength(1); j++)
                {
                    switch (r.Board[i, j].Color)
                    {
                        case Color.Red:
                            Console.BackgroundColor = ConsoleColor.Red;
                            break;
                        case Color.Blue:
                            Console.BackgroundColor = ConsoleColor.Blue;
                            break;
                        case Color.Green:
                            Console.BackgroundColor = ConsoleColor.Green;
                            break;
                    }

                    if (r.Robot.X == i && r.Robot.Y == j)
                    {
                        switch (r.Robot.Direction)
                        {
                            case Direction.Up:
                                Console.Write("-");
                                break;
                            case Direction.Down:
                                Console.Write("_");
                                break;
                            case Direction.Left:
                                Console.Write("<");
                                break;
                            case Direction.Right:
                                Console.Write(">");
                                break;
                        }
                    }
                    else
                    {
                        Console.Write(r.Board[i, j].IsEmpty ? " " : r.Board[i, j].HasStar ? "*" : "#");
                    }

                    Console.BackgroundColor = ConsoleColor.Black;
                }

                Console.WriteLine();
            }
        }
    }
}