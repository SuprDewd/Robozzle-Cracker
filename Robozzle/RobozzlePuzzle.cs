using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Robozzle
{
    public class RobozzlePuzzle
    {
        public Tile[,] Board { get; private set; }
        public Color ReplaceAllowed { get; private set; }
        public Robot Robot { get; private set; }
        public Tile CurrentTile { get { return this.Board[this.Robot.X, this.Robot.Y]; } }
        public int StarsLeft { get; private set; }
        public Instruction[][] Functions { get; set; }
        public event Action<RobozzlePuzzle> OnRunStep;

        public const int MaxDepth = 500;

        public RobozzlePuzzle(Tile[,] board, Robot robot, Instruction[][] functions) : this(board, robot, functions, Color.None) { }
        public RobozzlePuzzle(Tile[,] board, Robot robot, Instruction[][] functions, Color replaceAllowed)
        {
            this.Board = board;
            this.Robot = robot;
            this.ReplaceAllowed = replaceAllowed;
            this.Functions = functions;
            this.StarsLeft = this.CountStars();
            this.RemoveStar(this.CurrentTile);
        }

        private int CountStars()
        {
            int stars = 0;

            for (int x = 0; x < this.Board.GetLength(0); x++)
            {
                for (int y = 0; y < this.Board.GetLength(1); y++)
                {
                    if (this.Board[x, y] != null && this.Board[x, y].HasStar) stars++;
                }
            }

            return stars;
        }

        public void Reset(Tile[,] board, int robotX, int robotY, Direction robotDir)
        {
            this.Board = board;
            this.RemoveStar(this.CurrentTile);
            this.CurrentTile.HasStar = false;
            this.Robot.X = robotX;
            this.Robot.Y = robotY;
            this.Robot.Direction = robotDir;
            this.StarsLeft = this.CountStars();
            this.RemoveStar(this.CurrentTile);
        }

        internal void RemoveStar(int x, int y)
        {
            this.RemoveStar(this.Board[x, y]);
        }

        internal void RemoveStar(Tile t)
        {
            if (t.HasStar)
            {
                t.HasStar = false;
                this.StarsLeft--;
            }
        }

        internal void CallOnRunStep()
        {
            if (this.OnRunStep != null)
            {
                this.OnRunStep(this);
            }
        }

        public bool Run()
        {
            try
            {
                lock (this.Functions)
                {
                    for (int i = 0; i < this.Functions[0].Length; i++)
                    {
                        this.CallOnRunStep();

                        if (this.StarsLeft == 0) return true;

                        Instruction func = this.Functions[0][i];
                        if (func == null) continue;

                        if (!func.Execute(this))
                        {
                            this.CallOnRunStep();
                            return false;
                        }
                    }

                    return this.StarsLeft == 0;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}