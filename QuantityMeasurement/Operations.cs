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
                if (objectName.unit.Equals(Length.Unit.Feet))
                {
                    value = objectName.value * 12;
                }
                else if (objectName.unit.Equals(Length.Unit.Yard))
                {
                    value = objectName.value * 36;
                }
                else if (objectName.unit.Equals(Length.Unit.Centimeter))
                {
                    value = Math.Round(objectName.value / 2.54);
                }    
            }
            catch (Exception)
            {
                throw new QuantityMeasurementException(QuantityMeasurementException.ExceptionType.INVALID_TYPE, "Invalid");
            }
            return value;
        }

        public static double AddLengths(Length object1, Length object2)
        {
            double value1 = ConvertToInch(object1);
            double value2 = ConvertToInch(object2);
            return value1 + value2;
        }
    }
}
