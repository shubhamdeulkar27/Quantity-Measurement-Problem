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

        /// <summary>
        /// Function For Implemenattion.
        /// </summary>
        /// <param name="object1"></param>
        /// <param name="object2"></param>
        /// <returns></returns>
        public double AddLengths(Length object1, Length object2)
        {
            return 0;
        }

        /// <summary>
        /// Function For Implementation.
        /// </summary>
        /// <param name="objectName"></param>
        /// <returns></returns>
        public double ConvertToLitre(Volume objectName)
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
        private static readonly double GALLON_TO_LITRE_CONVERSION = 3.785;
        private static readonly double MILILITRE_TO_LITRE_CONVERSION = 1000;

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

        /// <summary>
        /// Function to Convert Volume Into Litre.
        /// </summary>
        /// <param name="objectName"></param>
        /// <returns></returns>
        public static double ConvertToLitre(Volume objectName)
        {
            double value = objectName.value;
            try
            {
                //Checking Unit Type And Conveting it to Litre.
                if (objectName.unit.Equals(Unit.Gallon))
                {
                    value = objectName.value * GALLON_TO_LITRE_CONVERSION;
                }
                if (objectName.unit.Equals(Unit.Mililitre))
                {
                    value = objectName.value / MILILITRE_TO_LITRE_CONVERSION;
                }
            }
            catch (QuantityMeasurementException)
            {
                throw new QuantityMeasurementException(QuantityMeasurementException.ExceptionType.INVALID_TYPE, "Invalid Type");
            }
            return value;
        }

        /// <summary>
        /// Function to Add Volumes And result into Litre.
        /// </summary>
        /// <param name="object1"></param>
        /// <param name="object2"></param>
        /// <returns></returns>
        public static double AddVolumes(Volume object1, Volume object2)
        {
            try
            {
                double value1 = ConvertToLitre(object1);
                double value2 = ConvertToLitre(object2);
                return value1 + value2;
            }
            catch (QuantityMeasurementException)
            {
                throw new QuantityMeasurementException(QuantityMeasurementException.ExceptionType.INVALID_TYPE, "Invalid Type");
            }
        }
    }
}
