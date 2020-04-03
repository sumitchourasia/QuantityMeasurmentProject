using System;

namespace QuantityMeasurementProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("measure feet and inch");
            IQuantityMeasurement QuantityObject = QuantityMeasurementFactory.Create("FeetAndInch");
            int feet = 1;
            int inch = 1;
            
            bool expected = QuantityObject.ConvertAndMeasure(feet, inch);
            bool actual = true;
        }
    }
}
