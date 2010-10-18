using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Robozzle;

namespace RobozzleCracker
{
    public static class Tools
    {
        public static IEnumerable<T> AllColorNeeds<T>(this IEnumerable<T> instructions) where T : Instruction
        {
            foreach (var instruction in instructions)
            {
                instruction.NeedColor = Color.None;
                yield return instruction;
                instruction.NeedColor = Color.Red;
                yield return instruction;
                instruction.NeedColor = Color.Green;
                yield return instruction;
                instruction.NeedColor = Color.Blue;
                yield return instruction;
            }
        }

        public static IEnumerable<T> AllColorNeeds<T>(this T instruction) where T : Instruction
        {
            instruction.NeedColor = Color.None;
            yield return instruction;
            instruction.NeedColor = Color.Red;
            yield return instruction;
            instruction.NeedColor = Color.Green;
            yield return instruction;
            instruction.NeedColor = Color.Blue;
            yield return instruction;
        }

        public static void Print(this RobozzlePuzzle r)
        {
            Console.Clear();
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