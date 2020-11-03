using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Math;

namespace project1
{
    class Vector
    {
            public double X,Y,Z; // X,Y,Z- координаты

        public Vector( double x, double y, double z)
        {
            X = x; 
            Y = y;
            Z = z;
        }

        public void Adder(Vector b)
        {
            this.X += b.X;
            this.Y += b.X;
            this.Z += b.X;
            Console.WriteLine("{0},{1},{2}",this.X, this.Y,this.Z);
        }
        public void Subtraction(Vector b)
        {
            this.X -= b.X;
            this.Y -= b.Y;
            this.Z -= b.Z;
             Console.WriteLine("{0},{1},{2}",this.X, this.Y,this.Z);
        }
        public  double AB (Vector a)
        {
            double rezult=0;
            rezult =this.X*a.X+this.Y*a.Y+this.Z*a.Z;
            return rezult;
        }
        public double Leng()
        {
            double rezult = 0;
            rezult = Math.Abs(this.X*this.X+this.Y*this.Y+this.Z*this.Z);
            return rezult;
        }
        public double Cosinus(Vector a)
        {
            double rezult =0;
            rezult = this.AB(a)/(this.Leng() * a.Leng());
            return rezult;
        }
    }
}