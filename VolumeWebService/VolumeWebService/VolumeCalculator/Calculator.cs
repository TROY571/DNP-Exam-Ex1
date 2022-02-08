using System;
using System.Threading.Tasks;
using VolumeWebService.Persistence;

namespace VolumeWebService.VolumeCalculator
{
    public class Calculator
    { 

        public double CalculateVolumeCylinder(double height,double radius)
        {
            return Math.PI * radius * radius * height;
        }

        public double CalculateVolumeCone(double height,double radius)
        {
            return Math.PI * radius * radius * height / 3;
        }
    }
}