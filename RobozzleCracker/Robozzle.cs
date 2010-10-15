using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace RobozzleCracker
{
    public class Robozzle
    {
        public Tile[,] Board { get; private set; }
        public Color ReplaceAllowed { get; private set; }
        public Robot Robot { get; private set; }
        public Tile CurrentTile { get { return this.Board[this.Robot.X, this.Robot.Y]; } }

        public Robozzle(Tile[,] board, Robot robot) : this(board, robot, Color.None) { } 
        public Robozzle(Tile[,] board, Robot robot, Color replaceAllowed)
        {
            this.Board = board;
            this.Robot = robot;
            this.ReplaceAllowed = replaceAllowed;
        }
    }
}