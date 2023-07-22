using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace doituonghinhhoc
{
    public class Shape
    {
        private string color = "green";
        private bool filled = true;

        public Shape()
        {

        }
        public Shape(string color, bool filled)
        {
            this.color = color;
            this.Filled = filled;
        }

        public string Color { get => color; set => color = value; }
        public bool Filled { get => filled; set => filled = value; }
        private bool isFilled()
        {
            return filled;
        }

        public override string ToString()
        {
            return "a shape with color of "
                   + color
                   +  " and " 
                   + (isFilled()? "filled" : "not filled");
        }


    }
    public class Circle : Shape
    {
        private double radius = 1.0;
        public Circle()
        {

        }

        public Circle(double radius)
        {
            this.radius = radius;
        }
        public Circle(double radius, string color, bool filled) : base(color, filled)
        {
            this.radius = radius;
        }

        public double Getradius()
        {
            return radius;
        }
        public void  Setradius(double radius)
        {
            this.radius = radius;
        }
        public double GetArea()
        {
            return radius * radius * Math.PI;
        }
        public double GetPerimeter()
        {
            return 2*radius * Math.PI;
        }
        public override string ToString()
        {
            return " a circle with radius = " + Getradius() + " which is a subclass of " + base.ToString();
        }
    }
    public class Rectangle : Shape
    {
        private double width = 1.0;
        private double length = 1.0;

        public Rectangle()
        {

        }
        public Rectangle(double width, double length)
        {
            this.width = width;
            this.length = length;
        }
        public Rectangle(double width, double length, string color, bool filled) : base(color, filled)
        {
            this.width = width;
            this.length = length;
        }
        public double GetWidth()
        {
            return width;
        }
        public virtual void SetWidth(double width)
        {
            this.width = width;
        }
        public double GetLength()
        {
            return length;
        }
        public virtual void SetLength(double length)
        {
            this.length= length;
        }
        public double GetArea()
        {
            return width* length;
        }
        public double Getperimeter()
        {
            return 2 *(width + this.length);
        }
        public override string ToString()
        {
            return "A rectangle with width = " + GetWidth() + " and length = " + GetLength() + ", which is a subclass of" + base.ToString();
        }
    }
    public class Square : Rectangle
    {
        public Square()
        {

        }
        public Square(double side) : base(side, side)
        {

        }
        public Square(double side, string color, bool filled): base(side,side, color, filled)
        { 
        }
        public double GetSide()
        {
            return GetWidth();
        }
        public void SetSide(double side)
        {
            SetWidth(side);
            SetLength(side);
        }
        public override void SetWidth(double width)

        {

            SetSide(width);

        }

        public override void SetLength(double length)

        {

            SetSide(length);

        }

        public override String ToString()
        {
            return "a awuare with side = "
                +GetSide()
                + ",which is a subcless of " + base.ToString();
          
        }
    }
}
