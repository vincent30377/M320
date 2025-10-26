using System;

namespace Shapes
{
    internal class Rectangles
    {
        private int length;
        private int width;
        private string color;
        private (int x, int y) punkt;
        private readonly int winkelsumme = 360;

        public int Length { get { return length; } }


        public int Width { get { return Width; } set { Width = value; } }

        public string Color { set { color = value; } }


        public string Color { get; }

        public int Lenght { get; set; }

        public int width { get; set; }
    }

}