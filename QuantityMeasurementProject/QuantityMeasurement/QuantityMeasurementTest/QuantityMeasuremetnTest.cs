using NUnit.Framework;
using QuantityMeasurementProject;

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
            int feet = 0; 
            int inch = 0;
            object expected = QuantityObject.ConvertAndMeasure(feet, inch);
            object actual = true ;
            Assert.AreEqual(actual,expected);
        }

        /// <summary>
        /// TestCase 1.2  to test for null value  
        /// </summary>
        [TestCase]
        public void MeasureFeetAndInchForNull()
        {
            IQuantityMeasurement QuantityObject = QuantityMeasurementFactory.Create("FeetAndInch");
            object expected = QuantityObject.ConvertAndMeasure(null, 1);
            object actual = null;
            Assert.AreEqual(actual, expected);
        }

        /// <summary>
        /// TestCase 1.3  to test for type   
        /// </summary>
        [TestCase]
        public void MeasureFeetAndInchForType()
        {
            object expected = QuantityMeasurementFactory.Create("FeetAndInch");
            object actual = "QuantityMeasurementProject.LengthMeasure.FeetAndInch";
            Assert.AreEqual(actual, expected.GetType().ToString());
        }

        /// <summary>
        /// TestCase 1.4  to test for Reference validity
        /// </summary>
        [TestCase]
        public void MeasureFeetAndInchForRef()
        {
            object expected = QuantityMeasurementFactory.Create("WrongClass");
            Assert.AreEqual(null, expected);
        }

        /// <summary>
        /// TestCase 1.5 to test feet and inch for equality
        /// </summary>
        [TestCase]
        public void MeasureFeetAndInchForEquality()
        {
            IQuantityMeasurement QuantityObject = QuantityMeasurementFactory.Create("FeetAndInch");
            int feet = 1;
            int inch = 12;
            object expected = QuantityObject.ConvertAndMeasure(feet, inch);
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
            int feet = 1;
            int inch = 11;
            object expected = QuantityObject.ConvertAndMeasure(feet, inch);
            object actual = false;
            Assert.AreEqual(actual, expected);
        }
    }
}