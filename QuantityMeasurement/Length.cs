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
        public enum Unit { Feet, Inch, Yard }

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
        /// IsEqual Function to Convert Input Units Into Centi-Meter
        /// And Checking Their Equality.
        /// </summary>
        /// <param name="object1"></param>
        /// <param name="object2"></param>
        /// <returns></returns>
        public bool IsEqual(Length object1, Length object2)
        {
            //Checking Feet and Inch Values Are Equal Or Not.
            if (object1.unit.Equals(Unit.Feet) && object2.unit.Equals(Unit.Inch))
            {
                double feetToCm = object1.value * 30.48;
                double inchToCm = object2.value * 2.54;
                if (feetToCm == inchToCm)
                {
                    return true;
                }
            }

            //Checking Inch and Feet Values Are Equal Or Not
            else if (object1.unit.Equals(Unit.Inch) && object2.unit.Equals(Unit.Feet))
            {
                double inchToCm = object1.value * 2.54;
                double feetToCm = object2.value * 30.48;
                if (inchToCm == feetToCm)
                {
                    return true;
                }
            }

            //Checking Feet and Yard Values Are Equal Or Not
            else if (object1.unit.Equals(Unit.Feet) && object2.unit.Equals(Unit.Yard))
            {
                double feetToCm = object1.value * 30.48;
                double yardToCm = object2.value * 91.44;
                if (feetToCm == yardToCm)
                {
                    return true;
                }
            }

            //Checking Yard And Inch Values Are Equal or Not.
            else if (object1.unit.Equals(Unit.Yard) && object2.unit.Equals(Unit.Inch))
            {
                double yardToCm = object1.value * 91.44;
                double inchToCm = object2.value * 2.54;
                if (yardToCm == inchToCm)
                {
                    return true;
                }
            }
           
            //Checking Inch And Yard Values Are Equal or Not.
            else if (object1.unit.Equals(Unit.Inch) && object2.unit.Equals(Unit.Yard))
            {
                double inchToCm = object1.value * 2.54;
                double yardToCm = object2.value * 91.44;
                if (yardToCm == inchToCm)
                {
                    return true;
                }
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
