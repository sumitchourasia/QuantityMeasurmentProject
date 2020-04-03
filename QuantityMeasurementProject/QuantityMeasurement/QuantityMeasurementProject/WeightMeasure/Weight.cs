/*using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMeasurementProject.WeightMeasure
{
    public abstract class Weight // : IQuantityMeasurement
    {
        public abstract bool ConvertAndMeasure(object unit1, object unit2);
    }

    public class Kilo
    {
        public int? kilo = null;
        public Kilo(int? kilo)
        {
            this.kilo = kilo;
        }

        /// <summary>
        /// override the Equals method.
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(Object obj2)
        {
            ////check for null
            if (this == null || obj2 == null)
                return false;

            ////check for reference
            if (Object.ReferenceEquals(this, obj2))
            {
                return true;
            }

            ////check for type
            if (this.GetType().Equals(obj2.GetType()))
            {
                return (this).kilo == ((Gram)obj2).gram;
            }

            ////if (obj1.GetType().ToString().Equals("QuantityMeasurementProject.LengthMeasure.Feet") && obj2.GetType().ToString().Equals("QuantityMeasurementProject.LengthMeasure.Inch"))
            return this.kilo * 1000 == ((Gram)obj2).gram;
        }
    }

    public class Gram
    {
        public int? gram = null;
        public Gram(int? gram)
        {
            this.gram = gram;
        }
        /// <summary>
        /// override the Equals method.
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(Object obj2)
        {
            ////check for null
            if (this == null || obj2 == null)
                return false;

            ////check for reference
            if (Object.ReferenceEquals(this, obj2))
            {
                return true;
            }

            ////check for type
            if (this.GetType().Equals(obj2.GetType()))
            {
                return (this).gram == ((Gram)obj2).gram;
            }

            ////if (obj1.GetType().ToString().Equals("QuantityMeasurementProject.LengthMeasure.Feet") && obj2.GetType().ToString().Equals("QuantityMeasurementProject.LengthMeasure.Inch"))
            return this.gram / 1000 == ((Kilo)obj2).kilo;
        }
    }
}
*/