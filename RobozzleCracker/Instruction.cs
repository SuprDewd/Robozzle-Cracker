using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RobozzleCracker
{
    public abstract class Instruction
    {
        public Color NeedColor { get; private set; }

        public Instruction(Color needColor)
        {
            this.NeedColor = needColor;
        }

        public bool Execute(Robozzle owner)
        {
            return this.Execute(owner, 0);
        }

        public abstract bool Execute(Robozzle owner, int depth);

        protected bool Execute(Func<bool> execution, Robozzle owner, int depth)
        {
            try
            {
                if (depth >= Robozzle.MaxDepth) throw new Exception("Depth exceeded max depth.");

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

        public abstract string ToString();
    }
}