using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMeasurement
{
    /// <summary>
    /// Class For Impelementation.
    /// </summary>
    public class ImplemetorConverUnit:IConvertUnit
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
    }

    /// <summary>
    /// Class To Convert The Given Unit Into Specified One.
    /// </summary>
    public class ConvertUnit:ImplemetorConverUnit
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
                //If Else Block for checking the specified Unit and converting into Centimeter.
                if (objectName.unit.Equals(Length.Unit.Feet))
                {
                    value = objectName.value * 12;
                }
                else if (objectName.unit.Equals(Length.Unit.Yard))
                {
                    value = objectName.value * 36;
                }
            }
            catch (Exception)
            {
                throw new QuantityMeasurementException(QuantityMeasurementException.ExceptionType.INVALID_TYPE, "Invalid");
            }
            return value;
        }
    }
}
