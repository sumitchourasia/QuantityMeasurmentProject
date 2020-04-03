using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMeasurementProject.LengthMeasure
{
    public abstract class Length : IQuantityMeasurement 
    {
        public abstract bool ConvertAndMeasure(int unit1, int unit2);
    }
}
