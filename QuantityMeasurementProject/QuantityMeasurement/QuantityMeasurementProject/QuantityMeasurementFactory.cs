using QuantityMeasurementProject.LengthMeasure;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMeasurementProject
{
    /// <summary>
    /// Factory class to create the Instance of respective class 
    /// </summary>
    public class QuantityMeasurementFactory
    {
        /// <summary>
        /// Factory method
        /// </summary>
        /// <param name="type"></param>
        /// <returns>Instance</returns>
        public static IQuantityMeasurement Create(string type)
        {
            if (type.Equals("FeetAndInch"))
                return new FeetAndInch();
            
            return null;
        }
    }
}
