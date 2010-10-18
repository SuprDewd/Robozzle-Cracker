using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Robozzle
{
    public class CallFunction : Instruction, ICloneable<CallFunction>
    {
        public int Function { get; private set; }

        public CallFunction(int function) : this(function, Color.None) { }
        public CallFunction(int function, Color needColor)
            : base(needColor)
        {
            this.Function = function;
        }

        public override bool Execute(RobozzlePuzzle owner, int depth)
        {
            return base.Execute(() =>
            {
                for (int i = 0; i < owner.Functions[this.Function].Length; i++)
                {
                    owner.CallOnRunStep();

                    if (owner.StarsLeft == 0) return true;

                    Instruction func = owner.Functions[this.Function][i];
                    if (func == null) continue;

                    if (!func.Execute(owner, depth + 1))
                    {
                        owner.CallOnRunStep();
                        return false;
                    }
                }

                return true;

            }, owner, depth);
        }

        public override string ToString()
        {
            return "Call function " + this.Function + (this.NeedColor != Color.None ? " if the current tile's color is " + this.NeedColor : "") + ".";
        }
    }
}
