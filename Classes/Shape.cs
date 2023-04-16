using MindboxTest.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindboxTest.Classes
{
    public abstract class Shape : IArea
    {
        protected Shape(double size1, double size2)
        {
            Size1 = size1;
            Size2 = size2;
        }

        private double Size1 { get; set; }

        private double Size2 { get; set; }

        public abstract double GetArea();
    }
}
