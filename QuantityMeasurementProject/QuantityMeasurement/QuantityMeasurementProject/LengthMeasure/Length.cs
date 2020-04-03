using System;

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
        public abstract bool ConvertAndMeasure(Object feet, Object inch);
        
    }
}
