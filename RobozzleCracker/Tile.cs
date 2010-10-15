using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RobozzleCracker
{
    public class Tile
    {
        public Color Color { get; internal set; }
        public bool HasStar { get; internal set; }
        public bool IsEmpty { get; private set; }

        private static Color[] AllowedColors = new Color[] { Color.Red, Color.Green, Color.Blue }; 

        public Tile() : this(Color.None, false, true) { }
        public Tile(Color color) : this(color, false, false) { }
        public Tile(Color color, bool hasStar) : this(color, hasStar, false) { }

        private Tile(Color color, bool hasStar, bool isEmpty)
        {
            if (!isEmpty && !AllowedColors.Contains(color)) throw new ArgumentException("Invalid Color.");

            this.Color = (isEmpty ? Color.None : color);
            this.HasStar = (isEmpty ? false : hasStar);
            this.IsEmpty = isEmpty;
        }
    }
}