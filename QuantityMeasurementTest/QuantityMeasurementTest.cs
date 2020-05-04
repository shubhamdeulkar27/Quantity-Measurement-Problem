using NUnit.Framework;
using QuantityMeasurement;
using System;

namespace QuantityMeasurementTest
{
    public class Tests
    {
        /// <summary>
        /// Test Case 1.1 Given 0 Feet And 0 Feet Should Return Equal.
        /// </summary>
        [Test]
        public void GivenZeroFeetAndZeroFeetShouldReturnEqual()
        {
            //Creating Feet Instance.
            Feet feet1 =  new Feet(0.0);
            Feet feet2 = new Feet(0.0);
            
            //Asserting Values.
            Assert.AreEqual(feet1,feet2);
        }
    }
}