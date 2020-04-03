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
    }
}