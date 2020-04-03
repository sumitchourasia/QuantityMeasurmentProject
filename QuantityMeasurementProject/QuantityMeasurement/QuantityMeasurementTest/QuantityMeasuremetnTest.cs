using NUnit.Framework;
using System.Collections.Generic;
using QuantityMeasurementProject;
using QuantityMeasurementProject.LengthMeasure;
using QuantityMeasurementProject.TemperatureMeasure;

namespace QuantityMeasurementTest
{
    /// <summary>
    /// class for test case
    /// </summary>
    [TestFixture]
    public class Tests
    {
        /// <summary>
        /// TestCase 1.1 to test feet and inch units
        /// </summary>
        [TestCase]
        public void MeasureFeetAndInch()
        {
            IQuantityMeasurement QuantityObject = QuantityMeasurementFactory.Create("FeetAndInch");
            Feet feetobj = new Feet(0);
            Inch inchObj = new Inch(0);
            bool expected = QuantityObject.ConvertAndMeasure<Feet,Inch>(feetobj, inchObj);
            bool actual = true ;
            Assert.AreEqual(actual,expected);
        }

        /// <summary>
        /// TestCase 1.2  to test for null value  
        /// </summary>
        [TestCase]
        public void MeasureFeetAndInchForNull()
        {
            IQuantityMeasurement QuantityObject = QuantityMeasurementFactory.Create("FeetAndInch");
            Feet feetobj = new Feet(null);
            Inch inchObj = new Inch(1);
            bool expected = QuantityObject.ConvertAndMeasure<Feet,Inch>(feetobj, inchObj);
            bool actual = false;
            Assert.AreEqual(actual, expected);
        }
        
        /// <summary>
        /// TestCase 1.3  to test for type   
        /// </summary>
        [TestCase]
        public void MeasureFeetAndInchForType()
        {
            IQuantityMeasurement QuantityObject = QuantityMeasurementFactory.Create("FeetAndInch");
            Feet feetobj = new Feet(1);
            Inch inchObj = new Inch(11);
            bool expected = QuantityObject.ConvertAndMeasure<Feet,Inch>(feetobj, inchObj);
            bool actual = false;
            Assert.AreEqual(actual, expected);
        }

        /// <summary>
        /// TestCase 1.5 to test feet and inch for equality
        /// </summary>
        [TestCase]
        public void MeasureFeetAndInchForEquality()
        {
            IQuantityMeasurement QuantityObject = QuantityMeasurementFactory.Create("FeetAndInch");
            Feet feetobj = new Feet(1);
            Inch inchObj = new Inch(12);
            bool expected = QuantityObject.ConvertAndMeasure<Feet, Inch>(feetobj, inchObj);
            object actual = true;
            Assert.AreEqual(actual, expected);
        }

        /// <summary>
        /// TestCase 1.6 to test feet and inch for Inequality
        /// </summary>
        [TestCase]
        public void MeasureFeetAndInchForInequality()
        {
            IQuantityMeasurement QuantityObject = QuantityMeasurementFactory.Create("FeetAndInch");
            Feet feetobj = new Feet(1);
            Inch inchObj = new Inch(24);
            bool expected = QuantityObject.ConvertAndMeasure(feetobj, inchObj);
            object actual = false;
            Assert.AreEqual(actual, expected);
        }

        /// <summary>
        /// TestCase 1.4  to test for Reference validity
        /// </summary>
        [TestCase]
        public void MeasureFeetAndInchForRef()
        {
            IQuantityMeasurement QuantityObject = QuantityMeasurementFactory.Create("FeetAndInch");
            Feet feetobj1 = new Feet(1);
            Feet feetobj2 = new Feet(2);
            feetobj2 = feetobj1;
            bool expected = QuantityObject.ConvertAndMeasure<Feet,Feet>(feetobj1, feetobj2);
            bool actual = true;
            Assert.AreEqual(actual, expected);
        }

        /// <summary>
        /// TestCase 1.7 to test feet and feet for equality2
        /// </summary>
        [TestCase]
        public void MeasureFeetAndInchForEquality2()
        {
            IQuantityMeasurement QuantityObject = QuantityMeasurementFactory.Create("FeetAndInch");
            Feet feetobj1 = new Feet(1);
            Feet feetobj2 = new Feet(1);
            bool expected = QuantityObject.ConvertAndMeasure<Feet, Feet>(feetobj1, feetobj2);
            object actual = true;
            Assert.AreEqual(actual, expected);
        }

        /// <summary>
        /// TestCase 1.7 to test feet and feet for equality2
        /// </summary>
        [TestCase]
        public void MeasureFeetAndYardTest()
        {
            IQuantityMeasurement QuantityObject = QuantityMeasurementFactory.Create("FeetAndInch");
            Feet feetobj1 = new Feet(1);
            Yard yardobj = new Yard(3);
            bool expected = QuantityObject.ConvertAndMeasure<Feet, Yard>(feetobj1, yardobj);
            object actual = true;
            Assert.AreEqual(actual, expected);
        }

        /// <summary>
        /// TestCase 1.7 to test feet and feet for equality2
        /// </summary>
        [TestCase]
        public void MeasureFeetAndYard2Test()
        {
            IQuantityMeasurement QuantityObject = QuantityMeasurementFactory.Create("FeetAndInch");
            Feet feetobj1 = new Feet(1);
            Yard yardobj = new Yard(2);
            bool expected = QuantityObject.ConvertAndMeasure<Feet, Yard>(feetobj1, yardobj);
            object actual = false; 
            Assert.AreEqual(actual, expected);
        }

                 

        /// <summary>
        /// testcase 2.1 to test the values of celsius and fahrenheit
        /// </summary>
        [TestCase]
        public void MeasureCelsiusAndFahrenheit()
        {
            IQuantityMeasurement QuantityObject = QuantityMeasurementFactory.Create("CelciusAndFahrenhiet");
            Celsius Obj1 = new Celsius(1);
            Fahrenheit Obj2 = new Fahrenheit(33.8); ;
            bool expected = QuantityObject.ConvertAndMeasure<Celsius,Fahrenheit>(Obj1, Obj2);
            bool actual = true;
            Assert.AreEqual(expected, actual);
        }
        
        /// <summary>
        /// testcase 2.2 to test the values of celsius and fahrenheit
        /// </summary>
        [TestCase]
        public void MeasureCelsiusAndFahrenheit2()
        {
            IQuantityMeasurement QuantityObject = QuantityMeasurementFactory.Create("CelciusAndFahrenhiet");
            Celsius Obj1 = new Celsius(1);
            Celsius Obj2 = new Celsius(1);
            bool expected = QuantityObject.ConvertAndMeasure<Celsius,Celsius>(Obj1, Obj2);
            bool actual = true;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// testcase 2.3 to test the values of celsius and fahrenheit
        /// </summary>
        [TestCase]
        public void MeasureCelsiusAndFahrenheit3()
        {
            IQuantityMeasurement QuantityObject = QuantityMeasurementFactory.Create("CelciusAndFahrenhiet");
            Celsius Obj1 = new Celsius(1);
            Celsius Obj2 = new Celsius(2);
            bool expected = QuantityObject.ConvertAndMeasure<Celsius,Celsius>(Obj1, Obj2);
            bool actual = false;
            Assert.AreEqual(expected,actual);
        }

        /// <summary>
        /// testcase 2.4 to test the values of celsius and fahrenheit
        /// </summary>
        [TestCase]
        public void MeasureCelsiusAndFahrenheit4()
        {
            IQuantityMeasurement QuantityObject = QuantityMeasurementFactory.Create("CelciusAndFahrenhiet");
            Celsius Obj1 = new Celsius(1);
            Fahrenheit Obj2 = new Fahrenheit(50); 
            bool expected = QuantityObject.ConvertAndMeasure<Celsius,Fahrenheit>(Obj1, Obj2);
            bool actual = false;
            Assert.AreEqual(expected, actual);
        }
    /*
            /// <summary>
            /// testcase 3.1 to test Kilo and Gram
            /// </summary>
            [TestCase]
            public void MeasureKiloAndGramTest()
            {
                IQuantityMeasurement QuantityObject = QuantityMeasurementFactory.Create("KiloAndGram");
                Kilo Obj1 = new Kilo(1);
                Gram Obj2 = new Gram(1000);
                bool expected = QuantityObject.ConvertAndMeasure(Obj1, Obj2);
                bool actual = true;
                Assert.AreEqual(expected, actual);
            }

            /// <summary>
            /// testcase 3.2 to test Kilo and Gram
            /// </summary>
            [TestCase]
            public void MeasureKiloAndGram2Test()
            {
                IQuantityMeasurement QuantityObject = QuantityMeasurementFactory.Create("KiloAndGram");
                Kilo Obj1 = new Kilo(1);
                Gram Obj2 = new Gram(2000);
                bool expected = QuantityObject.ConvertAndMeasure(Obj1, Obj2);
                bool actual = false;
                Assert.AreEqual(expected, actual);
            }


            /// <summary>
            /// testcase 3.3 to test Kilo and Gram
            /// </summary>
            [TestCase]
            public void MeasureKiloAndGram3Test()
            {
                IQuantityMeasurement QuantityObject = QuantityMeasurementFactory.Create("KiloAndGram");
                Gram Obj1 = new Gram(1);
                Gram Obj2 = new Gram(1);
                bool expected = QuantityObject.ConvertAndMeasure(Obj1, Obj2);
                bool actual = true;
                Assert.AreEqual(expected, actual);
            }

            /// <summary>
            /// testcase 3.4 to test Kilo and Gram
            /// </summary>
            [TestCase]
            public void MeasureKiloAndGram4Test()
            {
                IQuantityMeasurement QuantityObject = QuantityMeasurementFactory.Create("KiloAndGram");
                Gram Obj1 = new Gram(1);
                Gram Obj2 = new Gram(2);
                bool expected = QuantityObject.ConvertAndMeasure(Obj1, Obj2);
                bool actual = false;
                Assert.AreEqual(expected, actual);
            }
         */
    }
}

















