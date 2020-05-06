using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMeasurement
{
    /// <summary>
    /// Length Class For Setting Length Value In Specified Unit.
    /// </summary>
    public class Length : ILength
    {   
        //Variables.
        public Unit unit;
        public double value;

        /// <summary>
        /// Parameter Constructor To Set Unit And Value.
        /// </summary>
        /// <param name="unit"></param>
        /// <param name="value"></param>
        public Length(Unit unit, double value)
        {
            this.unit = unit;
            this.value = value;
        }

        /// <summary>
        /// IsEqual Function to Convert Input Units Into Lowest-Unit
        /// And Checking Their Equality.
        /// </summary>
        /// <param name="object1"></param>
        /// <param name="object2"></param>
        /// <returns></returns>
        public bool IsEqual(Length object1, Length object2)
        {
            try
            {
                double object1ValueInCentimeter = Operations.ConvertToInch(object1);
                double object2ValueInCentimeter = Operations.ConvertToInch(object2);
                if (object1ValueInCentimeter == object2ValueInCentimeter)
                {
                    return true;
                }
            }
            catch (Exception)
            {
                throw new QuantityMeasurementException(QuantityMeasurementException.ExceptionType.INVALID_TYPE, "Invalid Type");
            }
            return false;
        }

        /// <summary>
        /// Overriding Equals Function.
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            //If Object is Null It Will Return False.
            if (obj == null)
            {
                return false;
            }

            //If Object is Not A Reference Of Length Class The It Will Return False.
            if (!(obj is Length))
            {
                return false;
            }
            return (this.unit == ((Length)obj).unit) && (this.value == ((Length)obj).value) || IsEqual(this,(Length)obj) ;
        }

        /// <summary>
        /// Overriding GetHashCode Method.
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
