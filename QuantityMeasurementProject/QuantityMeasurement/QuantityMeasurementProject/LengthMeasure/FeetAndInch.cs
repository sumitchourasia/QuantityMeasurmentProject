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
        public override bool ConvertAndMeasure<X,Y>(X obj1, Y obj2)
        {
            Console.WriteLine(obj2.GetType().ToString());
            try
            {
               return obj1.Equals(obj2);
            }
            catch(NullReferenceException)
            {
                try
                {
                   return obj2.Equals(obj1);
                }
                catch(NullReferenceException )
                {
                    return false;
                }
            }
        }
    }
}
