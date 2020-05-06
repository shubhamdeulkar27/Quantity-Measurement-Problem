using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMeasurement
{
    /// <summary>
    /// Class For Impelementation.
    /// </summary>
    public class ImplemetorOperations:IOperations
    {
        /// <summary>
        /// Function For Implementation.
        /// </summary>
        /// <param name="objectName"></param>
        /// <returns></returns>
        public double ConvertToInch(Length objectName)
        {
            return 0;
        }

        public double AddLengths(Length object1, Length object2)
        {
            return 0;
        }
    }

    /// <summary>
    /// Class To Convert The Given Unit Into Specified One.
    /// </summary>
    public class Operations:ImplemetorOperations
    {
        //Constants
        private static readonly double FEET_TO_INCH_CONVERSION = 12;
        private static readonly double YARD_TO_INCH_CONVERSION = 36;
        private static readonly double CENTIMETER_TO_INCH_CONVERSION = 2.54;

        /// <summary>
        /// Function To Covert Given Objects Unit Value Into Inch Unit.
        /// </summary>
        /// <param name="objectName"></param>
        /// <returns></returns>
        public static double ConvertToInch(Length objectName)
        {
            double value=objectName.value;
            try
            {
                //If Else Block for checking the specified Unit and converting into Inch.
                if (objectName.unit.Equals(Unit.Feet))
                {
                    value = objectName.value * FEET_TO_INCH_CONVERSION;
                }
                else if (objectName.unit.Equals(Unit.Yard))
                {
                    value = objectName.value * YARD_TO_INCH_CONVERSION;
                }
                else if (objectName.unit.Equals(Unit.Centimeter))
                {
                    value = Math.Round(objectName.value / CENTIMETER_TO_INCH_CONVERSION);
                }    
            }
            catch (QuantityMeasurementException)
            {
                throw new QuantityMeasurementException(QuantityMeasurementException.ExceptionType.INVALID_TYPE, "Invalid");
            }
            return value;
        }

        public static double AddLengths(Length object1, Length object2)
        {
            try
            {
                double value1 = ConvertToInch(object1);
                double value2 = ConvertToInch(object2);
                return value1 + value2;
            }
            catch (QuantityMeasurementException)
            {
                throw new QuantityMeasurementException(QuantityMeasurementException.ExceptionType.INVALID_TYPE, "Invalid Type");
            }
        }
    }
}
