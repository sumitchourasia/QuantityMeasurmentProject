using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMeasurementProject
{
    public interface IQuantityMeasurement
    {
        bool ConvertAndMeasure(int unit1, int unit2);
    }
}
