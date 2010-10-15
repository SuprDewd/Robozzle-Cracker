using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RobozzleCracker
{
    public class MoveRobot : Instruction
    {
        public MoveRobot(Color needColor) : base(needColor)
        {
        }

        public override bool Execute(Robozzle owner)
        {
            return base.Execute(() => {

                if (this.NeedColor == Color.None || owner.CurrentTile.Color == this.NeedColor)
                {
                    owner.Robot.Move(1);
                }

                owner.CurrentTile.HasStar = false;

                return true;

            });
        }
    }
}
