using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMeasurement
{
    /// <summary>
    /// Length Class For Setting Length Value In Specified Unit.
    /// </summary>
    public class Length
    {
        /// <summary>
        /// Enum For Length Unit.
        /// </summary>
        public enum Unit { Feet, Inch }

        //Variables.
        Unit unit;
        private double value;

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

            return (this.unit == ((Length)obj).unit) && (this.value == ((Length)obj).value) || 
                (this.unit.Equals(Unit.Feet) && ((Length)obj).unit.Equals(Unit.Inch) && 
                this.value == 0 && ((Length)obj).value == 0);
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
