using QuantityMeasurementProject.LengthMeasure;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMeasurementProject
{
    public class QuantityMeasurementFactory
    {
        public static IQuantityMeasurement Create(string type)
        {
            if (type.Equals("FeetAndInch"))
                return new FeetAndInch();
            
            return null;
        }
    }
}
