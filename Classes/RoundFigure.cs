using MindboxTest.Interfaces;

namespace MindboxTest.Classes
{
    public class RoundFigure : IArea
    {

        public RoundFigure(double radius)
        {
            Radius = radius;
        }

        public double Radius { get; set; }

        public static double GetArea(double radius) 
        {
            return Math.PI * Math.Pow(radius, 2);
        }

        public double GetArea() 
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}