﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RobozzleCracker
{
    public class ChangeColor : Instruction
    {
        public Color SetColor { get; private set; }

        public ChangeColor(Color setColor) : this(setColor, Color.None) { }
        public ChangeColor(Color setColor, Color needColor)
            : base(needColor)
        {
            this.SetColor = setColor;
        }

        public override bool Execute(Robozzle owner, int depth)
        {
            return base.Execute(() =>
            {

                if ((owner.ReplaceAllowed & this.SetColor) != this.SetColor)
                {
                    return false;
                }

                if ((owner.ReplaceAllowed & this.SetColor) == this.SetColor)
                {
                    owner.CurrentTile.Color = this.SetColor;
                }

                return true;

            }, owner, depth);
        }

        public override string ToString()
        {
            return "Change the the current tile's color to " + this.SetColor + (this.NeedColor != Color.None ? " if the current tile's color is " + this.NeedColor : "") + ".";
        }
    }
}