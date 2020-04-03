using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMeasurementProject.LengthMeasure
{
    /// <summary>
    /// class to convert and measure the length unit feet and inch
    /// </summary>
    public class FeetAndInch : Length
    {
        /// <summary>
        /// overide the abstract method
        /// </summary>
        /// <param name="unit1"></param>
        /// <param name="unit2"></param>
        /// <returns></returns>
        public override object ConvertAndMeasure(object unit1, object unit2)
        {
            if (unit1 == null || unit2 == null)
                return null;
            int feet = Convert.ToInt32(unit1);
            int inch = Convert.ToInt32(unit2);
            return feet * 12 == inch;
        }
    }
}
