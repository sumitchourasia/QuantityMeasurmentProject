using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace QuantityMeasurementProject.TemperatureMeasure
{
    /// <summary>
    /// temperature conversion abstract class
    /// </summary>
    public abstract class Temperature : IQuantityMeasurement
    {
        /// <summary>
        /// abtract implementation of interface method
        /// </summary>
        /// <param name="feet"></param>
        /// <param name="inch"></param>
        /// <returns></returns>
        public abstract bool ConvertAndMeasure<X,Y>(X obj1, Y obj2);
    }

    /// <summary>
    /// Fahrenheit type
    /// </summary>
    public class Fahrenheit  : IEquatable<Celsius> , IEquatable<Fahrenheit>
    {
        public double? fahr = null;
        public Fahrenheit(double? value)
        {
            this.fahr = value;
        }

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
                return this.fahr == ((Fahrenheit)obj2).fahr;
            }

            if(obj2.GetType().ToString().Equals("QuantityMeasurementProject.TemperatureMeasure.Celsius"))
            {
                Celsius celobj = obj2 as Celsius;
                return Equals(celobj);
            }
            else if(obj2.GetType().ToString().Equals("QuantityMeasurementProject.TemperatureMeasure.Fahrenhiet"))
            {
                Fahrenheit fahrobj = obj2 as Fahrenheit;
                return Equals(fahrobj);
            }
            return false; 
        }

        public bool Equals([AllowNull] Celsius other)
        {
            return (this.fahr - 32) * 5 / 9 == other.celsius;
        }

        public bool Equals([AllowNull] Fahrenheit other)
        {
            return this.fahr == other.fahr;
        }
    }

    /// <summary>
    /// Celsius type
    /// </summary>
    public class Celsius : IEquatable<Fahrenheit> , IEquatable<Celsius>
    {
        public double? celsius = null;
        public Celsius(double? value)
        {
            this.celsius = value;
        }

        /// override the Equals method.
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(Object obj2)
        {
            ////check for null
            if (obj2 == null)
                return false;

            ////check for reference
            if (Object.ReferenceEquals(this, obj2))
            {
                return true;
            }

            ////check for type
            if (this.GetType().Equals(obj2.GetType()))
            {
                Celsius celobj = obj2 as Celsius;
                return Equals(celobj); 
            }

            if (obj2.GetType().ToString().Equals("QuantityMeasurementProject.TemperatureMeasure.Celsius"))
            {
                Celsius celobj = obj2 as Celsius;
                return Equals(celobj);
            }
            else if (obj2.GetType().ToString().Equals("QuantityMeasurementProject.TemperatureMeasure.Fahrenheit"))
            {
                Fahrenheit fahrobj = obj2 as Fahrenheit;
                return Equals(fahrobj);
            }
            
            return false;
        }

        public bool Equals([AllowNull] Fahrenheit obj2)
        {
            return (this.celsius * 9 / 5) + 32 == obj2.fahr;
        }

        public bool Equals([AllowNull] Celsius other)
        {
            return this.celsius == other.celsius;
        }
    }
}
