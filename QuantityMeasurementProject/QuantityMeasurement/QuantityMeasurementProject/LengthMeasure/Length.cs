using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace QuantityMeasurementProject.LengthMeasure
{
    /// <summary>
    /// abstract class to handle length units
    /// </summary>
    public abstract class Length : IQuantityMeasurement 
    {
        /// <summary>
        /// abstract implementationn of IQuantityMeasurement interface method
        /// </summary>
        /// <param name="unit1"></param>
        /// <param name="unit2"></param>
        /// <returns></returns>
        public abstract bool ConvertAndMeasure<X,Y>(X obj1, Y obj2);
    }

    /// <summary>
    /// feet class type
    /// </summary>
    public class Feet : IEquatable<Inch>, IEquatable<Feet>
    {
        public int? feet = null;

        public Feet(int? val)
        {
            this.feet = val;
        }

        public bool Equals(Feet other)
        {
            return this.feet == other.feet;
        }

        public bool Equals(Inch obj2)
        {
            return this.feet * 12 == obj2.inch;
        }

        public bool Equals(Yard obj2)
        {
            return this.feet * 3 == obj2.yard;
        }

        public override bool Equals(Object obj)
        {
            if (obj == null)
                return false;
            if (obj.GetType().ToString().Equals("QuantityMeasurementProject.LengthMeasure.Inch"))
            {
                Inch inchobj = obj as Inch;
                if (inchobj == null)
                    return false;
                else
                    return Equals(inchobj);
            }
            else if (obj.GetType().ToString().Equals("QuantityMeasurementProject.LengthMeasure.Feet"))
            {
                Feet feetobj = obj as Feet;
                if (feetobj == null)
                    return false;
                else
                    return Equals(feetobj);
            }
            else if(obj.GetType().ToString().Equals("QuantityMeasurementProject.LengthMeasure.Yard"))
            {
                Yard yardObj = obj as Yard;
                if (yardObj == null)
                    return false;
                else
                    return Equals(yardObj);
            }
            return false;
        }
    }

    /// <summary>
    /// inch class type
    /// </summary>
    public class Inch
    {
        public int? inch = null;

        public Inch(int? val)
        {
            this.inch = val;
        }
    }

    public class Yard
    {
        public int? yard = null;

        public Yard(int? val)
        {
            this.yard = val;
        }
    }
}
