using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMeasurementProject.LengthMeasure
{
    public class FeetAndInch : Length
    {
        public override bool ConvertAndMeasure(int unit1, int unit2)
        {
            return unit1 * 12 == unit2;
        }
    }
}
