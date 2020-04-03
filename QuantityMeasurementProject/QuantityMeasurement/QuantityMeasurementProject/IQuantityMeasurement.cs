using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMeasurementProject
{
    public interface IQuantityMeasurement
    {
        object ConvertAndMeasure(object unit1, object unit2);
    }
}
