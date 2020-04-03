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
           IQuantityMeasurement QuantityObject = QuantityMeasurementFactory.Create("FeetToInch");
            int feet = 1;
            int inch = 12;
            bool expected = QuantityObject.Convert(feet, inch);
            Assert.AreEqual(true,expected);
        }
    }
}