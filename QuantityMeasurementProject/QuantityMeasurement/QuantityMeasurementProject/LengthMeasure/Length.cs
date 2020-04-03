using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMeasurementProject.LengthMeasure
{
    /// <summary>
    /// abstract class to handle length units
    /// </summary>
    public abstract class Length : IQuantityMeasurement 
    {
        /// <summary>
        /// abstract implementationn of IQuantityMeasurement interface method
        /// </summary>
        /// <param name="unit1"></param>
        /// <param name="unit2"></param>
        /// <returns></returns>
        public abstract object ConvertAndMeasure(object unit1, object unit2);
    }
}
