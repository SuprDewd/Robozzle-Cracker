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

        public abstract bool Execute(Robozzle owner);

        public bool Execute(Func<bool> execution)
        {
            try
            {
                return execution();
            }
            catch
            {
                return false;
            }
        }
    }
}