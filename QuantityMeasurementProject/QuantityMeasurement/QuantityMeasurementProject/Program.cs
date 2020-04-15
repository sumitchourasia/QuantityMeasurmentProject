using QuantityMeasurementProject.LengthMeasure;
using QuantityMeasurementProject.TemperatureMeasure;
//using QuantityMeasurementProject.TemperatureMeasure;
//using QuantityMeasurementProject.WeightMeasure;
using System;
using System.Collections.Generic;

namespace QuantityMeasurementProject
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("measure celsius and fahrenhiet");
            IQuantityMeasurement QuantityObject = QuantityMeasurementFactory.Create("FeetAndInch");
            Feet feetobj = new Feet(1);
            Inch inchObj = new Inch(12);
            Feet feetobj2 = new Feet(2);
            Yard yardobj = new Yard(3);

            bool expected2 = QuantityObject.ConvertAndMeasure<Feet, Feet>(feetobj, feetobj2);

            bool expected = QuantityObject.ConvertAndMeasure<Feet, Inch>(feetobj, inchObj);

            bool expected3 = QuantityObject.ConvertAndMeasure<Feet, Yard>(feetobj, yardobj);

            /* IQuantityMeasurement QuantityObject = QuantityMeasurementFactory.Create("KiloAndGram");
             Kilo Obj1 = new Kilo(1);
             Gram Obj2 = new Gram(100); 
             bool expected = QuantityObject.ConvertAndMeasure(Obj1, Obj2);
             bool actual = true;*/

            IQuantityMeasurement QuantityObject2 = QuantityMeasurementFactory.Create("CelciusAndFahrenhiet");
            Celsius Obj1 = new Celsius(1);
            Fahrenheit Obj2 = new Fahrenheit(33.8);
            Celsius obj3 = new Celsius(1);
          //  bool expected = QuantityObject.ConvertAndMeasure<Celsius,Fahrenheit>(Obj1, Obj2);
            QuantityObject.ConvertAndMeasure<Celsius, Celsius>(Obj1, obj3);
        }
    }
}
