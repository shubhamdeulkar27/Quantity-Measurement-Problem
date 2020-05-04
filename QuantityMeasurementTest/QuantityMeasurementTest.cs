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
            Assert.AreNotEqual(feet1,feet2);
        }

        /// <summary>
        /// Test Case 1.7 Given 0 Inch And 0 Inch Should Return Equal.
        /// </summary>
        [Test]
        public void Given0InchAnd0InchShouldReturnEqual()
        {
            //Creating Inch Instances.
            Inch inch1 = new Inch(0.0);
            Inch inch2 = new Inch(0.0);

            //Asserting Values.
            Assert.AreEqual(inch1, inch2);
        }

        /// <summary>
        /// Test Case 1.8 Given Null Inch Values Should Return Equal.
        /// </summary>
        [Test]
        public void GivenNullInchValuesShouldReturnEqual()
        {
            //Creating Inch Instances.
            Inch inch1 = null;
            Inch inch2 = null;

            //Asserting Values.
            Assert.AreEqual(inch1, inch2);
        }

        /// <summary>
        /// Test Case 1.9 Given Two References Of Same Type Should Return Equal.
        /// </summary>
        [Test]
        public void GivenSameInchReferencesShouldReturnEqual()
        {
            //Creating Inch Instances.
            Inch inch1 = new Inch(0.0);
            Inch inch2 = inch1;

            //Asserting Values.
            Assert.AreEqual(inch1, inch2);
        }

        /// <summary>
        /// Test Case 1.10 Given Same Type References Should Return Equal.
        /// </summary>
        [Test]
        public void GivenInchTypeReferenceShouldReturnEqual()
        {
            //Creating Inch Instances.
            Inch inch1 = new Inch(0.0);
            Inch inch2 = new Inch(0.0);

            //Getting Type Of Reference.
            Type typeInch1 = inch1.GetType();
            Type typeInch2 = inch2.GetType();

            //Asserting Values.
            Assert.AreEqual(typeInch1, typeInch2);
        }

    }
}