using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Robozzle
{
    public class TurnRobot : Instruction
    {
        public Direction Direction { get; private set; }

        public TurnRobot(Direction dir) : this(dir, Color.None) { }
        public TurnRobot(Direction dir, Color needColor)
            : base(needColor)
        {
            this.Direction = dir;

            if (dir != Direction.Left && dir != Direction.Right)
            {
                throw new ArgumentException("Direction must be left or right.");
            }
        }

        public override bool Execute(RobozzlePuzzle owner, int i)
        {
            return base.Execute(() =>
            {
                if (this.Direction == Direction.Left)
                {
                    owner.Robot.TurnLeft();
                }
                else if (this.Direction == Direction.Right)
                {
                    owner.Robot.TurnRight();
                }
                else
                {
                    throw new Exception("Direction must be left or right.");
                }

                return true;

            }, owner, i);
        }

        public override string ToString()
        {
            return "Turn the robot " + this.Direction.ToString().ToLower() + (this.NeedColor != Color.None ? " if the current tile's color is " + this.NeedColor : "") + ".";
        }
    }
}