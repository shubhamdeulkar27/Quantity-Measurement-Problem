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
            Length feet1 = new Length(Length.Unit.Feet, 0.0);
            Length feet2 = new Length(Length.Unit.Feet, 0.0);

            //Asserting Values.
            Assert.AreEqual(feet1, feet2);
        }

        /// <summary>
        /// Test Case 1.2 Given Null Values Should Return Equal.
        /// </summary>
        [Test]
        public void GivenNullFeetValuesShouldReturnEqual()
        {
            //Creating Feet Null References.
            Length feet1 = null;
            Length feet2 = null;

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
            Length feet1 = new Length(Length.Unit.Feet, 0.0);
            Length feet2 = feet1;

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
            Length feet1 = new Length(Length.Unit.Feet, 0.0);
            Length feet2 = new Length(Length.Unit.Feet, 0.0);

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
            Length feet1 = new Length(Length.Unit.Feet, 1.0);
            Length feet2 = new Length(Length.Unit.Feet, 1.0);

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
            Length feet1 = new Length(Length.Unit.Feet, 1.0);
            Length feet2 = new Length(Length.Unit.Feet, 10.0);

            //Asserting Values.
            Assert.AreNotEqual(feet1, feet2);
        }

        /// <summary>
        /// Test Case 1.7 Given 0 Inch And 0 Inch Should Return Equal.
        /// </summary>
        [Test]
        public void Given0InchAnd0InchShouldReturnEqual()
        {
            //Creating Inch Instances.
            Length inch1 = new Length(Length.Unit.Inch, 0.0);
            Length inch2 = new Length(Length.Unit.Inch, 0.0);

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
            Length inch1 = null;
            Length inch2 = null;

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
            Length inch1 = new Length(Length.Unit.Inch, 0.0);
            Length inch2 = inch1;

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
            Length inch1 = new Length(Length.Unit.Inch, 0.0);
            Length inch2 = new Length(Length.Unit.Inch, 0.0);

            //Getting Type Of Reference.
            Type typeInch1 = inch1.GetType();
            Type typeInch2 = inch2.GetType();

            //Asserting Values.
            Assert.AreEqual(typeInch1, typeInch2);
        }

        /// <summary>
        /// Test Case 1.11 Given 1 Inch and 1 Inch Should Return Equal.
        /// </summary>
        [Test]
        public void Given1InchAnd1InchShouldReturnEqual()
        {
            //Creating Inch Instances.
            Length inch1 = new Length(Length.Unit.Inch, 1);
            Length inch2 = new Length(Length.Unit.Inch, 1);

            //Asserting Values.
            Assert.AreEqual(inch1, inch2);
        }

        /// <summary>
        /// Test Case 1.12 Given 1 Inch And 10 Inch Should Return Not Equal.
        /// </summary>
        [Test]
        public void Given1InchAnd10InchShouldReturnNotEqual()
        {
            //Creating Inch Instances.
            Length inch1 = new Length(Length.Unit.Inch, 1);
            Length inch2 = new Length(Length.Unit.Inch, 10);

            //Asserting Values.
            Assert.AreNotEqual(inch1, inch2);
        }

        /// <summary>
        /// Test Case 1.13 Given 0 Feet and 0 Inch Should Return Equal.
        /// </summary>
        [Test]
        public void Given0FeetAnd0InchShouldReturnEqual()
        {
            //Creating Length Instances For Feet and Inch
            Length feet = new Length(Length.Unit.Feet, 0);
            Length inch = new Length(Length.Unit.Inch, 0);

            //Asserting Values.
            Assert.AreEqual(feet, inch);
        }

        /// <summary>
        /// Test Case 1.14 Given 1 Feet And 1 Inch Should Return Not Equal.
        /// </summary>
        [Test]
        public void Given1FeetAnd1InchShouldReturnNotEqual()
        {
            //Creating Length Instances For Feet and Inch
            Length feet = new Length(Length.Unit.Feet, 1);
            Length inch = new Length(Length.Unit.Inch, 1);

            //Asserting Values.
            Assert.AreNotEqual(feet, inch);
            Assert.AreNotEqual(inch, feet);

        }

        /// <summary>
        /// Test Case 1.15 Given 1 Feet And 12 Inch Should Return Equal.
        /// </summary>
        [Test]
        public void Given1FeetAnd12InchShouldReturnEqual()
        {
            //Creating Length Instances For Feet and Inch
            Length feet = new Length(Length.Unit.Feet, 1);
            Length inch = new Length(Length.Unit.Inch, 12);

            //Asserting Values.
            Assert.AreEqual(feet, inch);
        }

        /// <summary>
        /// Test Case 1.16 Given 1 Feet And 12 Inch Should Return Equal.
        /// </summary>
        [Test]
        public void Given12InchAnd1FeetShouldReturnEqual()
        {
            //Creating Length Instances For Feet and Inch
            Length feet = new Length(Length.Unit.Feet, 1);
            Length inch = new Length(Length.Unit.Inch, 12);

            //Asserting Values.
            Assert.AreEqual(inch, feet);
        }

        /// <summary>
        /// Test Case 2.17 Given 3 Feet And 1 Yard Should Return Equal.
        /// </summary>
        [Test]
        public void Given3FeetAnd1YardShouldReturnEqual()
        {
            //Creating Length Instances For Feet and Inch
            Length feet = new Length(Length.Unit.Feet, 3);
            Length yard = new Length(Length.Unit.Yard, 1);

            //Asserting Values.
            Assert.AreEqual(feet, yard);
        }

        /// <summary>
        /// Test Case 2.18 Given 1 Feet And 1 Yard Should Return Not Equal.
        /// </summary>
        [Test]
        public void Given1FeetAnd1YardShouldReturnNotEqual()
        {
            //Creating Length Instances For Feet and Inch
            Length feet = new Length(Length.Unit.Feet, 1);
            Length yard = new Length(Length.Unit.Yard, 1);

            //Asserting Values.
            Assert.AreNotEqual(feet, yard);
        }

        /// <summary>
        /// Test Case 2.19 Given 1 Yard And 36 Inch Should Return Equal.
        /// </summary>
        [Test]
        public void Given1YardAnd36InchShouldReturEqual()
        {
            //Creating Length Instances For Feet and Inch
            Length yard = new Length(Length.Unit.Yard, 1);
            Length inch = new Length(Length.Unit.Inch, 36);
            
            //Asserting Values.
            Assert.AreEqual(yard, inch);
        }
    }
}