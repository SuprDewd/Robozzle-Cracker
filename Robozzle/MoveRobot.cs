﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Robozzle
{
    public class MoveRobot : Instruction
    {
        public MoveRobot(Color needColor = Color.None)
            : base(needColor)
        {
        }

        public override bool Execute(RobozzlePuzzle owner, int depth)
        {
            return base.Execute(() =>
            {
                owner.Robot.Move(1);

                if (owner.Robot.X < 0 || owner.Robot.Y < 0 || owner.Robot.X >= owner.Board.GetLength(0) || owner.Robot.Y >= owner.Board.GetLength(1) || owner.CurrentTile.IsEmpty) return false;

                owner.RemoveStar(owner.CurrentTile);

                return true;

            }, owner, depth);
        }

        public override string ToString()
        {
            return "Move the robot" + (this.NeedColor != Color.None ? " if the current tile's color is " + this.NeedColor : "") + ".";
        }
    }
}
