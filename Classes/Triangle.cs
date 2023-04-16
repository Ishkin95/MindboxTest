using MindboxTest.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace MindboxTest.Classes
{
    public class Triangle : Shape, IArea
    {
        public Triangle(double angle, double size1, double size2) : base(size1, size2)
        {
            Angle = angle;
            Size1 = size1;
            Size2 = size2;
        }

        //in degrees
        private double Angle { get; set; }
        private double Size1 { get; }
        private double Size2 { get; }

        public override double GetArea()
        {
            if (Angle == 90) 
            {
                return Size1 * Size2 / 2;
            }
            else 
            {
                return (Size1 * Size2 / 2 ) * Math.Sin(Angle * (Math.PI / 180));
            }
        }
    }
}
