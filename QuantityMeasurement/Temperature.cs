using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMeasurement
{
    /// <summary>
    /// Class For Setting Temperatur Data.
    /// </summary>
    public class Temperature : IQuantity
    {
        //Variables.
        public Unit unit;
        public double value;

        //Creating Instance Of Operation Class For Function Calling.
        Operations operation = new Operations();
 
        /// <summary>
        /// Parameter Constructor For Setting Data.
        /// </summary>
        /// <param name="unit"></param>
        /// <param name="value"></param>
        public Temperature(Unit unit, double value)
        {
            this.unit = unit;
            this.value = value;
        }

        /// <summary>
        /// Function For Equating Object's Values.
        /// </summary>
        /// <param name="object1"></param>
        /// <param name="object2"></param>
        /// <returns></returns>
        public bool IsEqual(object object1, object object2)
        {
            try
            {
                double object1ValueInLitre = operation.ConvertToBaseUnit((Temperature)object1);
                double object2ValueInLitre = operation.ConvertToBaseUnit((Temperature)object2);
                if (object1ValueInLitre == object2ValueInLitre)
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
            if (obj == null)
            {
                return false;
            }
            if (!(obj is Temperature))
            {
                return false;
            }
            return (this.unit == ((Temperature)obj).unit && this.value ==((Temperature)obj).value) || IsEqual(this,(Temperature)obj);
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
