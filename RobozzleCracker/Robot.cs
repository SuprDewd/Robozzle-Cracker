﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RobozzleCracker
{
    public class Robot
    {
        public int X { get; private set; }
        public int Y { get; private set; }
        public Direction Direction { get; private set; }

        public Robot(int x, int y, Direction direction)
        {
            this.X = x;
            this.Y = y;
            this.Direction = direction;
        }

        public void TurnLeft()
        {
            switch (this.Direction)
            {
                case Direction.Up:
                    this.Direction = Direction.Left;
                    break;
                case Direction.Down:
                    this.Direction = Direction.Right;
                    break;
                case Direction.Left:
                    this.Direction = Direction.Down;
                    break;
                case Direction.Right:
                    this.Direction = Direction.Up;
                    break;
                default: throw new Exception("Robot turned to an invalid direction.");
            }
        }

        public void TurnRight()
        {
            switch (this.Direction)
            {
                case Direction.Up:
                    this.Direction = Direction.Right;
                    break;
                case Direction.Down:
                    this.Direction = Direction.Left;
                    break;
                case Direction.Left:
                    this.Direction = Direction.Up;
                    break;
                case Direction.Right:
                    this.Direction = Direction.Down;
                    break;
                default: throw new Exception("Robot turned to an invalid direction.");
            }
        }

        public void Move() {this.Move(1);}
        public void Move(int i)
        {
            switch (this.Direction)
            {
                case Direction.Up:
                    this.Y += i;
                    break;
                case Direction.Down:
                    this.Y -= i;
                    break;
                case Direction.Left:
                    this.X -= i;
                    break;
                case Direction.Right:
                    this.X += i;
                    break;
                default: throw new Exception("Robot moved in an invalid direction.");
            }
        }
    }
}