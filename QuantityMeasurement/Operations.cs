using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMeasurement
{
    /// <summary>
    /// Operations Class For Unit Convertion And Addition Operation.
    /// </summary>
    public class Operations:IOperations
    {
        //Constants
        private static readonly double FEET_TO_INCH_CONVERSION = 12;
        private static readonly double YARD_TO_INCH_CONVERSION = 36;
        private static readonly double CENTIMETER_TO_INCH_CONVERSION = 2.54;
        private static readonly double GALLON_TO_LITRE_CONVERSION = 3.785;
        private static readonly double MILILITRE_TO_LITRE_CONVERSION = 1000;
        private static readonly double GRAM_TO_KILOGRAM_CONVERSION = 1000;

        /// <summary>
        /// Function To Convert To Base Unit.
        /// </summary>
        /// <param name="inputObject"></param>
        /// <returns></returns>
        public double ConvertToBaseUnit(object inputObject)
        {
            Type objectType = inputObject.GetType();
            if (objectType.Equals(typeof(Length)))
            {
                Length length = ((Length)inputObject);
                double value = length.value;
                try
                {
                    //If Else Block for checking the specified Unit and converting into Inch.
                    if (length.unit.Equals(Unit.Feet))
                    {
                        value = length.value * FEET_TO_INCH_CONVERSION;
                    }
                    else if (length.unit.Equals(Unit.Yard))
                    {
                        value = length.value * YARD_TO_INCH_CONVERSION;
                    }
                    else if (length.unit.Equals(Unit.Centimeter))
                    {
                        value = Math.Round(length.value / CENTIMETER_TO_INCH_CONVERSION);
                    }
                }
                catch (QuantityMeasurementException)
                {
                    throw new QuantityMeasurementException(QuantityMeasurementException.ExceptionType.INVALID_TYPE, "Invalid");
                }
                return value;
            }
            else if (objectType.Equals(typeof(Volume)))
            {
                Volume volume = (Volume)inputObject;
                double value = volume.value;
                try
                {
                    //Checking Unit Type And Conveting it to Litre.
                    if (volume.unit.Equals(Unit.Gallon))
                    {
                        value = volume.value * GALLON_TO_LITRE_CONVERSION;
                    }
                    if (volume.unit.Equals(Unit.Mililitre))
                    {
                        value = volume.value / MILILITRE_TO_LITRE_CONVERSION;
                    }
                }
                catch (QuantityMeasurementException)
                {
                    throw new QuantityMeasurementException(QuantityMeasurementException.ExceptionType.INVALID_TYPE, "Invalid Type");
                }
                return value;
            }
            else if (objectType.Equals(typeof(Weight)))
            {
                Weight weight = (Weight)inputObject;
                double value = weight.value;
                try
                {

                    //Checking Unit and Converting Into Kilograms.
                    if (weight.unit.Equals(Unit.Grams))
                    {
                        value = weight.value / GRAM_TO_KILOGRAM_CONVERSION;
                    }
                    if (weight.unit.Equals(Unit.Tonne))
                    {
                        value = weight.value * GRAM_TO_KILOGRAM_CONVERSION;
                    }
                }
                catch (QuantityMeasurementException)
                {
                    throw new QuantityMeasurementException(QuantityMeasurementException.ExceptionType.INVALID_TYPE, "Invalid Type");
                }
                return value;
            }
            else if (objectType.Equals(typeof(Temperature)))
            {
                Temperature temperature = (Temperature)inputObject;
                double value = temperature.value;

                try
                {
                    //Checking Unit And Converting Into Celsius.
                    if (temperature.unit.Equals(Unit.Fahrenheit))
                    {
                        value = (temperature.value - 32) * 5 / 9;
                    }
                }
                catch (QuantityMeasurementException)
                {
                    throw new QuantityMeasurementException(QuantityMeasurementException.ExceptionType.INVALID_TYPE, "Invalid Type");
                }
                return value;
            }
            return 0;
        }

        /// <summary>
        /// Function For Addition Of Two Measurements.
        /// </summary>
        /// <param name="object1"></param>
        /// <param name="object2"></param>
        /// <returns></returns>
        public double Add(object object1, object object2)
        {
            try
            {
                //Converting Values To Its Base Unit.
                double value1 = ConvertToBaseUnit(object1);
                double value2 = ConvertToBaseUnit(object2);
                return value1 + value2;
            }
            catch (QuantityMeasurementException)
            {
                throw new QuantityMeasurementException(QuantityMeasurementException.ExceptionType.INVALID_TYPE, "Invalid Type");
            }
        }
    }
}
