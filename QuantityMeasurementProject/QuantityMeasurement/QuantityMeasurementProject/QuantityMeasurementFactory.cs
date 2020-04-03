using QuantityMeasurementProject.LengthMeasure;
using QuantityMeasurementProject.TemperatureMeasure;
/*using QuantityMeasurementProject.WeightMeasure;*/
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
            else if (type.Equals("CelciusAndFahrenhiet"))
                return new CelciusAndFahrenhiet();
            /* else if (type.Equals("KiloAndGram"))
                 return new KiloAndGram();*/

            return null;
        }
    }
}
