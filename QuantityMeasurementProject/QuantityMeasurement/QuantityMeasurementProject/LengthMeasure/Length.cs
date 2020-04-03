using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMeasurementProject.LengthMeasure
{
    public abstract class Length : IQuantityMeasurement 
    {
        public abstract object ConvertAndMeasure(object unit1, object unit2);
    }
}
