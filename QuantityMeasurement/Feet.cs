using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMeasurement
{
    /// <summary>
    /// Class Feet to Set Feet Data.
    /// </summary>
    public class Feet
    {
        //Variable
        private double value;

        /// <summary>
        /// Parameter Constructor to Set Value.
        /// </summary>
        /// <param name="value"></param>
        public Feet(double value)
        {
            this.value = value;
        }

        /// <summary>
        /// Overridding Equals Method.
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            if(obj==null)
            {
                return false;
            }
            if (!(obj is Feet))
            {
                return false;
            }
            return (this.value == ((Feet)obj).value);
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
