using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMeasurementProject.LengthMeasure
{
    public class FeetAndInch : Length
    {
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
