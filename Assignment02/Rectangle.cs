using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment02
{
    /* This class contains getter and setter methods for the program files to get and set the user
     * inputs.
     */
    public class Rectangle
    {
        private int length;
        private int width;
        private int height;

        public Rectangle()
        {
            length = 1;
            width = 1;
            height = 1;
        }

        public Rectangle(int length, int width, int height)
        {
            this.length = length;
            this.width = width;
            this.height = height;
        }

        public int Getlength()
        {
            return length;
        }
        public int Setlength(int length)
        {
            this.length = length;
            return this.length;
        }
        public int Getwidth()
        {
            return width;
        }
        public int Setwidth(int width)
        {
            this.width = width;
            return this.width;
        }

        public int GetHeight()
        {
            return height;
        }
        public int SetHeight(int height)
        {
            this.height = height;
            return this.height;
        }

        public int GetRectangleVolume()
        {
            return (length * width * height);
        }

    }
}
