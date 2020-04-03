using System;

namespace QuantityMeasurementProject
{
    /// <summary>
    /// inteface IQuantityMeasurement
    /// </summary>
    public interface IQuantityMeasurement
    {
        /// <summary>
        /// Convert And Measure method to check the equality of two parameter
        /// </summary>
        /// <param name="unit1"></param>
        /// <param name="unit2"></param>
        /// <returns></returns>
        bool ConvertAndMeasure(Object feet, Object inch);
    }
}
