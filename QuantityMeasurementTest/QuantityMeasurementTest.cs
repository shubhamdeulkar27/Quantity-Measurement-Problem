using NUnit.Framework;
using QuantityMeasurement;
using System;

namespace QuantityMeasurementTest
{
    /// <summary>
    /// Class For Test Cases.
    /// </summary>
    public class Tests
    {
        //Creating Length Instances For Different unit.
        Length zeroFeet = new Length(Unit.Feet, 0.0);
        Length zeroInch = new Length(Unit.Inch, 0.0);
        Length oneFeet = new Length(Unit.Feet, 1);
        Length oneInch = new Length(Unit.Inch, 1);
        Length oneYard = new Length(Unit.Yard, 1);

        //Creating Instance Of Operation Class For Function Calling.
        Operations operation = new Operations();

        /// <summary>
        /// Test Case 1.1 Given 0 Feet And 0 Feet Should Return Equal.
        /// </summary>
        [Test]
        public void GivenZeroFeetAndZeroFeetShouldReturnEqual()
        {
            //Asserting Values.
            Assert.AreEqual(zeroFeet, zeroFeet);
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
            Length feet1 = zeroFeet;

            //Asserting Values.
            Assert.AreEqual(zeroFeet, feet1);
        }

        /// <summary>
        /// Test Case 1.4 Given Feet Type Data Should Return Equal.
        /// </summary>
        [Test]
        public void GivenFeet1andFeet2TypesShouldReturnEqual()
        {
            //Getting Types.
            Type typeFeet1 = zeroFeet.GetType();
            Type typeFeet2 = zeroFeet.GetType();

            //Asserting Values.
            Assert.AreEqual(typeFeet1, typeFeet2);
        }

        /// <summary>
        /// Test Case 1.5 Given 1 Feet and 1 Feet Should Return Equal.
        /// </summary>
        [Test]
        public void Given1FeetAnd1FeetShouldReturnEqual()
        {
            //Asserting Values.
            Assert.AreEqual(oneFeet, oneFeet);
        }

        /// <summary>
        /// Test Case 1.6 Given 1 Feet and 10 Feet Should Return Not Equal.
        /// </summary>
        [Test]
        public void Given1FeetAnd10FeetShouldReturnNotEqual()
        {
            //Creating Feet Instance.
            Length tenFeet = new Length(Unit.Feet, 10.0);

            //Asserting Values.
            Assert.AreNotEqual(oneFeet, tenFeet);
        }

        /// <summary>
        /// Test Case 1.7 Given 0 Inch And 0 Inch Should Return Equal.
        /// </summary>
        [Test]
        public void Given0InchAnd0InchShouldReturnEqual()
        {
            //Asserting Values.
            Assert.AreEqual(zeroInch, zeroInch);
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
            Length inch = zeroInch;

            //Asserting Values.
            Assert.AreEqual(zeroInch, inch);
        }

        /// <summary>
        /// Test Case 1.10 Given Same Type References Should Return Equal.
        /// </summary>
        [Test]
        public void GivenInchTypeReferenceShouldReturnEqual()
        {
            //Getting Type Of Reference.
            Type typeInch1 = oneInch.GetType();
            Type typeInch2 = oneInch.GetType();

            //Asserting Values.
            Assert.AreEqual(typeInch1, typeInch2);
        }

        /// <summary>
        /// Test Case 1.11 Given 1 Inch and 1 Inch Should Return Equal.
        /// </summary>
        [Test]
        public void Given1InchAnd1InchShouldReturnEqual()
        {
            //Asserting Values.
            Assert.AreEqual(oneInch, oneInch);
        }

        /// <summary>
        /// Test Case 1.12 Given 1 Inch And 10 Inch Should Return Not Equal.
        /// </summary>
        [Test]
        public void Given1InchAnd10InchShouldReturnNotEqual()
        {
            //Creating Inch Instances.
            Length tenInch = new Length(Unit.Inch, 10);

            //Asserting Values.
            Assert.AreNotEqual(oneInch, tenInch);
        }

        /// <summary>
        /// Test Case 1.13 Given 0 Feet and 0 Inch Should Return Equal.
        /// </summary>
        [Test]
        public void Given0FeetAnd0InchShouldReturnEqual()
        {
            //Asserting Values.
            Assert.AreEqual(zeroFeet, zeroInch);
        }

        /// <summary>
        /// Test Case 1.14 Given 1 Feet And 1 Inch Should Return Not Equal.
        /// </summary>
        [Test]
        public void Given1FeetAnd1InchShouldReturnNotEqual()
        {
            //Asserting Values.
            Assert.AreNotEqual(oneFeet, oneInch);
            Assert.AreNotEqual(oneInch, oneFeet);
        }

        /// <summary>
        /// Test Case 1.15 Given 1 Feet And 12 Inch Should Return Equal.
        /// </summary>
        [Test]
        public void Given1FeetAnd12InchShouldReturnEqual()
        {
            //Creating Length Instances For Inch
            Length inch = new Length(Unit.Inch, 12);

            //Asserting Values.
            Assert.AreEqual(oneFeet, inch);
        }

        /// <summary>
        /// Test Case 1.16 Given 1 Feet And 12 Inch Should Return Equal.
        /// </summary>
        [Test]
        public void Given12InchAnd1FeetShouldReturnEqual()
        {
            //Creating Length Instances For Inch
            Length inch = new Length(Unit.Inch, 12);

            //Asserting Values.
            Assert.AreEqual(inch, oneFeet);
        }

        /// <summary>
        /// Test Case 2.17 Given 3 Feet And 1 Yard Should Return Equal.
        /// </summary>
        [Test]
        public void Given3FeetAnd1YardShouldReturnEqual()
        {
            //Creating Length Instance For Feet.
            Length feet = new Length(Unit.Feet, 3);

            //Asserting Values.
            Assert.AreEqual(feet, oneYard);
        }

        /// <summary>
        /// Test Case 2.18 Given 1 Feet And 1 Yard Should Return Not Equal.
        /// </summary>
        [Test]
        public void Given1FeetAnd1YardShouldReturnNotEqual()
        {
            //Asserting Values.
            Assert.AreNotEqual(oneFeet, oneYard);
        }

        /// <summary>
        /// Test Case 2.19 Given 1 Yard And 36 Inch Should Return Equal.
        /// </summary>
        [Test]
        public void Given1YardAnd36InchShouldReturEqual()
        {
            //Creating Length Instance For Inch
            Length inch = new Length(Unit.Inch, 36);

            //Asserting Values.
            Assert.AreEqual(oneYard, inch);
        }

        /// <summary>
        /// Test Case 2.20 Given 36 Inch And 1 Yard Should Return Equal.
        /// </summary>
        [Test]
        public void Given36InchAnD1YardShouldReturnEqual()
        {
            //Creating Length Instance For Inch
            Length inch = new Length(Unit.Inch, 36);

            //Asserting Values.
            Assert.AreEqual(inch, oneYard);
        }

        /// <summary>
        /// Test Case 2.21 Given 1 Yard And 3 Feet Should Return Equal.
        /// </summary>
        [Test]
        public void Given1YardAnd3FeetShouldReturnEqual()
        {
            //Creating Length Instance For Feet
            Length feet = new Length(Unit.Feet, 3);

            //Asserting Values.
            Assert.AreEqual(oneYard, feet);
        }

        /// <summary>
        /// Test Case 3.22 Given 2 Inch And 5 Centimeter Should Return Equal.
        /// </summary>
        [Test]
        public void Given2InchAnd5CentimeterShouldReturnEqual()
        {
            //Creating Length Instances For Inch And Centimeter.
            Length inch = new Length(Unit.Inch, 2);
            Length centimeter = new Length(Unit.Centimeter, 5);

            //Asserting Values.
            Assert.AreEqual(inch, centimeter);
        }

        /// <summary>
        /// Test Case 4.23 Given 2 Inch And 2 Inch Should Return 4 Inch.
        /// </summary>
        [Test]
        public void Gievn2InchAnd2InchShouldReturn4Inch()
        {
            //Creating Inch Instances.
            Length inch1 = new Length(Unit.Inch, 2);
            Length inch2 = new Length(Unit.Inch, 2);
            double result = operation.Add(inch1, inch2);
            double expected = 4;

            //Assertig Values.
            Assert.AreEqual(expected, result);
        }

        /// <summary>
        /// Test Case 4.24 Given 1 Feet And 2 Inch Should Return 14 Inches.
        /// </summary>
        [Test]
        public void Given1FeetAnd2InchShouldReturn14Inch()
        {
            //Creating Feet And Inch Instances.
            Length inch = new Length(Unit.Inch, 2);
            double result = operation.Add(oneFeet, inch);
            double expected = 14;

            //Assertig Values.
            Assert.AreEqual(expected, result);
        }

        /// <summary>
        /// Test Case 4.25 Given 1 Feet And 1 Feet Should Return 24 Inches.
        /// </summary>
        [Test]
        public void Given1FeetAnd1FeetShouldReturn24Inch()
        {
            double result = operation.Add(oneFeet, oneFeet);
            double expected = 24;

            //Assertig Values.
            Assert.AreEqual(expected, result);
        }

        /// <summary>
        /// Test Case 4.26 Given 2 Inch Adn 2.5 Centimeter Should Return 3 Inch. 
        /// </summary>
        [Test]
        public void Given2InchAnd2point5CentimeterShouldReturn3Inch()
        {
            //Creating Length Instances and Performing Operation.
            Length inch = new Length(Unit.Inch, 2);
            Length centimeter = new Length(Unit.Centimeter, 2.5);
            double result = operation.Add(inch, centimeter);
            double expected = 3;

            //Asserting Values.
            Assert.AreEqual(expected, result);
        }

        /// <summary>
        /// Test Case 5.27 Given 1 Gallon And 3.785 Litre Should Return Equal.
        /// </summary>
        [Test]
        public void Given1GallonAnd3point785LitreShouldReturnEqual()
        {
            //Creating Volume Instances For Gallon And Litre.
            Volume gallon = new Volume(Unit.Gallon, 1.0);
            Volume litre = new Volume(Unit.Litre, 3.785);

            //Asserting Values.
            Assert.AreEqual(gallon, litre);
        }

        /// <summary>
        /// Test Case 5.28 Given 1 Litre And 1000 MiliLitre Should Return Equal.
        /// </summary>
        [Test]
        public void Given1LitreAnd1000MiliLitreShouldReturnEqual()
        {
            //Creating Volume Instances For Litre And Mililitre.
            Volume litre = new Volume(Unit.Litre, 1);
            Volume miliLitre = new Volume(Unit.Mililitre, 1000);

            //Asserting Values.
            Assert.AreEqual(litre, miliLitre);
        }

        /// <summary>
        /// Test Case 6.29 Given 1 Gallon And 3.785 Litre Should Return 7.57.
        /// </summary>
        [Test]
        public void Given1GallonAnd3point785LitreShouldReturn7point57Litre()
        {
            //Creating Volume Instances.
            Volume gallon = new Volume(Unit.Gallon, 1);
            Volume litre = new Volume(Unit.Litre, 3.785);

            double expected = 7.57;
            double result = operation.Add(gallon, litre);

            //Asserting Values.
            Assert.AreEqual(expected, result);
        }

        /// <summary>
        /// Test Case 6.30 Given 1 Litre And 1000 Mililitre Should Return 2 Litre.
        /// </summary>
        [Test]
        public void Given1LitreAnd1000MililitreShouldReturn2Litre()
        {
            //Creating Instances For Volumes.
            Volume litre = new Volume(Unit.Litre, 1);
            Volume miliLitre = new Volume(Unit.Mililitre, 1000);

            double expected = 2;
            double result = operation.Add(litre, miliLitre);

            //Asserting Values.
            Assert.AreEqual(expected, result);
        }

        /// <summary>
        /// Test Case 7.31 Given 1 Kilogram And 1000 Gram Should Return Equal.
        /// </summary>
        [Test]
        public void Given1KiloGramsAnd1000GramsShouldReturnEqul()
        {
            //Creating Instances Of Weights.
            Weight kiloGrams = new Weight(Unit.KiloGram, 1.0);
            Weight grams = new Weight(Unit.Grams, 1000);

            //Assertin Values.
            Assert.AreEqual(kiloGrams, grams);
        }

        /// <summary>
        /// Test Case 7.32 Given 1 Tonne And 1000  kilograms Should Return Equal.
        /// </summary>
        [Test]
        public void Given1TonneAnd1000KilogramsShouldReturnEqual()
        {
            //Creating Weight Instances For Tonne And Kilogram.
            Weight tonne = new Weight(Unit.Tonne, 1);
            Weight kilograms = new Weight(Unit.KiloGram, 1000);

            //Asserting Value.
            Assert.AreEqual(tonne, kilograms);
        }

        /// <summary>
        /// Test Case 7.33 Given 1 Tonne And 1000 Grams Should Return 1001 Kilograms.
        /// </summary>
        [Test]
        public void Given1TonneAnd1000GramShouldReturn1001Kilogram()
        {
            //Creating Weight Instances For Tonne And Grams.
            Weight tonne = new Weight(Unit.Tonne, 1);
            Weight grams = new Weight(Unit.Grams, 1000);

            double expected = 1001;
            double result = operation.Add(tonne, grams);

            //Asserting Values.
            Assert.AreEqual(expected, result);
        }

        /// <summary>
        /// Test Case 8.34 Given 212 Fahreneit And 100 Celsius Should Return Equal.
        /// </summary>
        [Test]
        public void Given212FahrenheitAnd100CelsiusShouldReturnEqual()
        {
            //Creating Temperature Instances For Fahrenheit And Celsius.
            Temperature fahrenheit = new Temperature(Unit.Fahrenheit,212.0);
            Temperature celsius = new Temperature(Unit.Celsius,100);

            //Asserting Values.
            Assert.AreEqual(fahrenheit,celsius);
        }
    }
}