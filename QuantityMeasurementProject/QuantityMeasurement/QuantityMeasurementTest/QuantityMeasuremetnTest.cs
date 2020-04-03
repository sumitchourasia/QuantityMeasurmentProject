using NUnit.Framework;
using QuantityMeasurementProject;

namespace QuantityMeasurementTest
{
    [TestFixture]
    public class Tests
    {
        [TestCase]
        public void ConvertFeetToInch()
        {
            IQuantityMeasurement QuantityObject = QuantityMeasurementFactory.Create("FeetAndInch");
            int feet = 0; 
            int inch = 0;
            object expected = QuantityObject.ConvertAndMeasure(feet, inch);
            object actual = true ;
            Assert.AreEqual(actual,expected);
        }
    }
}