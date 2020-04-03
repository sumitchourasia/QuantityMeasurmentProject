using System;

namespace QuantityMeasurementProject.TemperatureMeasure
{

    public class CelciusAndFahrenhiet : Temperature
    {
        public override bool ConvertAndMeasure<X,Y>(X obj1, Y obj2)
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
