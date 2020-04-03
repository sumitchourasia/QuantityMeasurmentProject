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
        public override bool ConvertAndMeasure(Object feet, Object inch)
        {
            ////check for null
            if (feet == null || inch == null)
                return false;

            ////check for reference
            if (Object.ReferenceEquals(feet, inch))
            {
                return true;
            }

            ////check for type
            if (!feet.GetType().Equals(inch.GetType()))
            {
                return false;
            }

            ////check for equality
            int paramfeet = Convert.ToInt32(feet);
            int paraminch = Convert.ToInt32(inch);
            return (paramfeet * 12 == paraminch);
        }
    }
}
