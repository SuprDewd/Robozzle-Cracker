using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Robozzle
{
    public abstract class Instruction
    {
        public Color NeedColor { get; set; }

        public Instruction(Color needColor)
        {
            this.NeedColor = needColor;
        }

        public bool Execute(RobozzlePuzzle owner)
        {
            return this.Execute(owner, 0);
        }

        public abstract bool Execute(RobozzlePuzzle owner, int depth);

        protected bool Execute(Func<bool> execution, RobozzlePuzzle owner, int depth)
        {
            try
            {
                if (depth >= RobozzlePuzzle.MaxDepth) throw new Exception("Depth exceeded max depth.");

                if (this.NeedColor == Color.None || owner.CurrentTile.Color == this.NeedColor)
                {
                    return execution();
                }

                return true;
            }
            catch
            {
                return false;
            }
        }

        public new abstract string ToString();
    }
}