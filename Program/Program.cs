using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Robozzle;
using RobozzleCracker;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Instruction[] funcs = {
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
            }*/


            /*Instruction[] funcs = new Instruction[10] { new MoveRobot(), new MoveRobot(), new TurnRobot(Direction.Left), new TurnRobot(Direction.Left), new MoveRobot(), new MoveRobot(), new MoveRobot(), new MoveRobot(), null, null };

            Tile[,] tiles = {
                            
                                {Tile.Empty, new Tile(Color.Blue), new Tile(Color.Blue), new Tile(Color.Blue), new Tile(Color.Blue), new Tile(Color.Blue), Tile.Empty },
                                {new Tile(Color.Blue), new Tile(Color.Blue), new Tile(Color.Blue), new Tile(Color.Blue), new Tile(Color.Blue), new Tile(Color.Blue), new Tile(Color.Blue) },
                                {new Tile(Color.Blue), new Tile(Color.Blue, true), new Tile(Color.Blue), new Tile(Color.Blue), new Tile(Color.Blue), new Tile(Color.Blue, true), new Tile(Color.Blue) },
                                {new Tile(Color.Blue), new Tile(Color.Blue), new Tile(Color.Blue), new Tile(Color.Blue), new Tile(Color.Blue), new Tile(Color.Blue), new Tile(Color.Blue) },
                                {Tile.Empty, new Tile(Color.Blue), new Tile(Color.Blue), new Tile(Color.Blue), new Tile(Color.Blue), new Tile(Color.Blue), Tile.Empty }

                            };

            Robot robot = new Robot(2, 3, Direction.Right);*/

            /*Instruction[][] funcs = new Instruction[][]
            {
            
               //new Instruction[]{new TurnRobot(Direction.Left), new CallFunction(0)}
               new Instruction[5] { new MoveRobot(), new MoveRobot(Color.Blue), new TurnRobot(Direction.Right, Color.Red), new CallFunction(1, Color.Green), new CallFunction(0) },
               new Instruction[5] { new MoveRobot(), new MoveRobot(Color.Green), new TurnRobot(Direction.Left, Color.Red), new CallFunction(0, Color.Blue), new CallFunction(1) }
            
            };

            Robot robot = new Robot(11, 0, Direction.Up);

            Tile[,] tiles = {
                            
                                {new Tile(Color.Red), new Tile(Color.Blue), new Tile(Color.Red), Tile.Empty, new Tile(Color.Red), new Tile(Color.Blue), new Tile(Color.Red), Tile.Empty,new Tile(Color.Red), new Tile(Color.Blue), new Tile(Color.Red), Tile.Empty,new Tile(Color.Red), new Tile(Color.Blue), new Tile(Color.Red), Tile.Empty},
                                {new Tile(Color.Blue), Tile.Empty, new Tile(Color.Green), Tile.Empty, new Tile(Color.Blue), Tile.Empty, new Tile(Color.Green), Tile.Empty, new Tile(Color.Blue), Tile.Empty, new Tile(Color.Green), Tile.Empty, new Tile(Color.Blue), Tile.Empty, new Tile(Color.Green), Tile.Empty},
                                {new Tile(Color.Blue), Tile.Empty, new Tile(Color.Green), Tile.Empty, new Tile(Color.Blue), Tile.Empty, new Tile(Color.Green), Tile.Empty, new Tile(Color.Blue), Tile.Empty, new Tile(Color.Green), Tile.Empty, new Tile(Color.Blue), Tile.Empty, new Tile(Color.Green), Tile.Empty},
                                {new Tile(Color.Blue), Tile.Empty, new Tile(Color.Green), Tile.Empty, new Tile(Color.Blue), Tile.Empty, new Tile(Color.Green), Tile.Empty, new Tile(Color.Blue), Tile.Empty, new Tile(Color.Green), Tile.Empty, new Tile(Color.Blue), Tile.Empty, new Tile(Color.Green), Tile.Empty},
                                {new Tile(Color.Blue), Tile.Empty, new Tile(Color.Green), Tile.Empty, new Tile(Color.Blue), Tile.Empty, new Tile(Color.Green), Tile.Empty, new Tile(Color.Blue), Tile.Empty, new Tile(Color.Green), Tile.Empty, new Tile(Color.Blue), Tile.Empty, new Tile(Color.Green), Tile.Empty},
                                {new Tile(Color.Blue), Tile.Empty, new Tile(Color.Green), Tile.Empty, new Tile(Color.Blue), Tile.Empty, new Tile(Color.Green), Tile.Empty, new Tile(Color.Blue), Tile.Empty, new Tile(Color.Green), Tile.Empty, new Tile(Color.Blue), Tile.Empty, new Tile(Color.Green), Tile.Empty},
                                {new Tile(Color.Blue), Tile.Empty, new Tile(Color.Green), Tile.Empty, new Tile(Color.Blue), Tile.Empty, new Tile(Color.Green), Tile.Empty, new Tile(Color.Blue), Tile.Empty, new Tile(Color.Green), Tile.Empty, new Tile(Color.Blue), Tile.Empty, new Tile(Color.Green), Tile.Empty},
                                {new Tile(Color.Blue), Tile.Empty, new Tile(Color.Green), Tile.Empty, new Tile(Color.Blue), Tile.Empty, new Tile(Color.Green), Tile.Empty, new Tile(Color.Blue), Tile.Empty, new Tile(Color.Green), Tile.Empty, new Tile(Color.Blue), Tile.Empty, new Tile(Color.Green), Tile.Empty},
                                {new Tile(Color.Blue), Tile.Empty, new Tile(Color.Green), Tile.Empty, new Tile(Color.Blue), Tile.Empty, new Tile(Color.Green), Tile.Empty, new Tile(Color.Blue), Tile.Empty, new Tile(Color.Green), Tile.Empty, new Tile(Color.Blue), Tile.Empty, new Tile(Color.Green), Tile.Empty},
                                {new Tile(Color.Blue), Tile.Empty, new Tile(Color.Green), Tile.Empty, new Tile(Color.Blue), Tile.Empty, new Tile(Color.Green), Tile.Empty, new Tile(Color.Blue), Tile.Empty, new Tile(Color.Green), Tile.Empty, new Tile(Color.Blue), Tile.Empty, new Tile(Color.Green), Tile.Empty},
                                {new Tile(Color.Blue), Tile.Empty, new Tile(Color.Green), Tile.Empty, new Tile(Color.Blue), Tile.Empty, new Tile(Color.Green), Tile.Empty, new Tile(Color.Blue), Tile.Empty, new Tile(Color.Green), Tile.Empty, new Tile(Color.Blue), Tile.Empty, new Tile(Color.Green), Tile.Empty},
                                {new Tile(Color.Blue), Tile.Empty, new Tile(Color.Red), new Tile(Color.Green), new Tile(Color.Red), Tile.Empty, new Tile(Color.Red), new Tile(Color.Green), new Tile(Color.Red), Tile.Empty, new Tile(Color.Red), new Tile(Color.Green), new Tile(Color.Red), Tile.Empty, new Tile(Color.Red), new Tile(Color.Green, true)}
                            
                            };*/

            /*Instruction[][] funcs = new Instruction[][] {
                new Instruction[4]{ new MoveRobot(), new TurnRobot(Direction.Right, Color.Green), new TurnRobot(Direction.Left, Color.Red), new CallFunction(0) }
            };

            Robot robot = new Robot(2, 0, Direction.Up);

            Tile[,] tiles = new Tile[,] {
            
                {new Tile(Color.Green), new Tile(Color.Green), new Tile(Color.Green), new Tile(Color.Green), new Tile(Color.Green), new Tile(Color.Green), new Tile(Color.Green), new Tile(Color.Green), new Tile(Color.Green), new Tile(Color.Green) },
                {new Tile(Color.Blue, true), new Tile(Color.Blue), new Tile(Color.Blue, true), new Tile(Color.Blue), new Tile(Color.Blue, true), new Tile(Color.Blue), new Tile(Color.Blue, true), new Tile(Color.Blue), new Tile(Color.Blue), new Tile(Color.Blue) },
                {new Tile(Color.Blue), new Tile(Color.Blue, true), new Tile(Color.Blue), new Tile(Color.Blue, true), new Tile(Color.Blue), new Tile(Color.Blue, true), new Tile(Color.Blue), new Tile(Color.Blue, true), new Tile(Color.Blue), new Tile(Color.Blue) },
                {new Tile(Color.Blue), new Tile(Color.Blue), new Tile(Color.Blue, true), new Tile(Color.Blue), new Tile(Color.Blue, true), new Tile(Color.Blue), new Tile(Color.Blue, true), new Tile(Color.Blue), new Tile(Color.Blue, true), new Tile(Color.Blue) },
                {new Tile(Color.Blue), new Tile(Color.Blue), new Tile(Color.Blue), new Tile(Color.Blue, true), new Tile(Color.Blue), new Tile(Color.Blue, true), new Tile(Color.Blue), new Tile(Color.Blue, true), new Tile(Color.Blue), new Tile(Color.Blue, true) },
                {new Tile(Color.Red), new Tile(Color.Red), new Tile(Color.Red), new Tile(Color.Red), new Tile(Color.Red), new Tile(Color.Red), new Tile(Color.Red), new Tile(Color.Red), new Tile(Color.Red), new Tile(Color.Red)}

            };*/

            Instruction[][] funcs = new Instruction[][] {
                new Instruction[6]{ new MoveRobot(), new TurnRobot(Direction.Right, Color.Red), new TurnRobot(Direction.Right, Color.Red), new CallFunction(0), null, null }
            };

            Robot robot = new Robot(0, 8, Direction.Left);

            Tile[,] tiles = new Tile[,] {
            
                {new Tile(Color.Red), new Tile(Color.Blue), new Tile(Color.Blue), new Tile(Color.Blue), new Tile(Color.Blue), new Tile(Color.Blue), new Tile(Color.Blue), new Tile(Color.Blue), new Tile(Color.Blue), new Tile(Color.Blue, true), new Tile(Color.Blue, true), new Tile(Color.Blue, true), new Tile(Color.Blue, true), new Tile(Color.Blue, true), new Tile(Color.Blue, true), new Tile(Color.Blue, true)}

            };

            RobozzlePuzzle r = new RobozzlePuzzle(tiles, robot, funcs);
            r.OnRunStep += rob => { rob.Print(); System.Threading.Thread.Sleep(100); };

            Console.WriteLine(r.Run());

            Console.ReadLine();
        }
    }
}