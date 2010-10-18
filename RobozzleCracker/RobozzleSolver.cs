using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Robozzle;

namespace RobozzleCracker
{
    public class RobozzleSolver
    {
        public Tile[,] Board { get; private set; }
        public Robot Robot { get; private set; }
        public Color ReplaceAllowed { get; private set; }
        public int[] FunctionSizes { get; private set; }

        public RobozzleSolver(Tile[,] board, Robot robot, Color replaceAllowed, int[] functionSizes)
        {
            this.Board = board;
            this.Robot = robot;
            this.ReplaceAllowed = replaceAllowed;
            this.FunctionSizes = functionSizes;
        }
    }
}