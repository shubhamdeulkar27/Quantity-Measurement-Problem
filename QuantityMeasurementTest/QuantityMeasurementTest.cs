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

        /// <summary>
        /// Test Case 1.2 Given Null Values Should Return Equal.
        /// </summary>
        [Test]
        public void GivenNullFeetValuesShouldReturnEqual()
        {
            //Creating Feet Null References.
            Feet feet1 = null;
            Feet feet2 = null;

            //Asserting Values.
            Assert.AreEqual(feet1, feet2);
        }

        /// <summary>
        /// Test Case 1.3 Given References Having Same Object Should Return Equal.
        /// </summary>
        [Test]
        public void GivenSameReferencesShouldReturnEqual()
        {
            //Creeating Feet Instance.
            Feet feet1 = new Feet(0.0);
            Feet feet2 = feet1;

            //Asserting Values.
            Assert.AreEqual(feet1, feet2);
        }

        /// <summary>
        /// Test Case 1.4 Given Feet Type Data Should Return Equal.
        /// </summary>
        [Test]
        public void GivenFeet1andFeet2TypesShouldReturnEqual()
        {
            //Creating Instances.
            Feet feet1 = new Feet(0.0);
            Feet feet2 = new Feet(0.0);

            Type typeFeet1 = feet1.GetType();
            Type typeFeet2 = feet2.GetType();

            //Asserting Values.
            Assert.AreEqual(typeFeet1, typeFeet2);
        }

        /// <summary>
        /// Test Case 1.5 Given 1 Feet and 1 Feet Should Return Equal.
        /// </summary>
        [Test]
        public void Given1FeetAnd1FeetShouldReturnEqual()
        {
            //Creating Feet Instances.
            Feet feet1 = new Feet(1.0);
            Feet feet2 = new Feet(1.0);

            //Asserting Values.
            Assert.AreEqual(feet1, feet2);
        }

        /// <summary>
        /// Test Case 1.6 Given 1 Feet and 10 Feet Should Return Not Equal.
        /// </summary>
        [Test]
        public void Given1FeetAnd10FeetShouldReturnNotEqual()
        {
            //Creating Feet Instances.
            Feet feet1 = new Feet(1.0);
            Feet feet2 = new Feet(10.0);

            //Asserting Values.
            Assert.AreNotEqual(feet1, feet2);
        }

    }
}