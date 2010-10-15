using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RobozzleCracker
{
    public class ChangeColor : Instruction
    {
        public Color SetColor { get; private set; }

        public ChangeColor(Color setColor) : this(setColor, Color.None) { }
        public ChangeColor(Color setColor, Color needColor) : base(needColor)
        {
            this.SetColor = setColor;
        }

        public override bool Execute(Robozzle owner)
        {
            return base.Execute(() => {

                if ((owner.ReplaceAllowed & this.SetColor) != this.SetColor)
                {
                    return false;
                }

                if (((owner.ReplaceAllowed & this.SetColor) == this.SetColor) && (this.NeedColor == Color.None || owner.CurrentTile.Color == this.NeedColor))
                {
                    owner.CurrentTile.Color = this.SetColor;
                }

                return true;

            });
        }
    }
}