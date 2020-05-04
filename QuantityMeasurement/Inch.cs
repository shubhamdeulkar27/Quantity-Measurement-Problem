using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMeasurement
{
    /// <summary>
    /// Inch Class To Set Data.
    /// </summary>
    public class Inch
    {
        //Variable
        private double value;

        /// <summary>
        /// Parameter Constructor to Set Inch Data.
        /// </summary>
        /// <param name="value"></param>
        public Inch(double value)
        {
            this.value = value;
        }

        /// <summary>
        /// Overriding Equals Functon. 
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (!(obj is Inch))
            {
                return false;
            }
            return (this.value == ((Inch)obj).value);
        }

        /// <summary>
        /// Overriding GetHashCode Function.
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
