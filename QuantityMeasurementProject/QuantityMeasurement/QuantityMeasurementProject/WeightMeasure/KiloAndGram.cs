/*using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMeasurementProject.WeightMeasure
{
    public class KiloAndGram : Weight
    {
        public override bool ConvertAndMeasure(object obj1, object obj2)
        {
            try
            {
                return obj1.Equals(obj2);
            }
            catch (NullReferenceException)
            {
                try
                {
                    return obj2.Equals(obj1);
                }
                catch (NullReferenceException)
                {
                    return false;
                }
            }
        }
    }
}
*/