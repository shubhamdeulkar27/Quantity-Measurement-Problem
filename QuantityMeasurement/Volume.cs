using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMeasurement
{
    /// <summary>
    /// Class Volume For Setting Volume in Specified Unit.
    /// </summary>
    public class Volume:IQuantity
    {
        //Variables.
        public Unit unit;
        public double value;

        //Creating Instance Of Operation Class For Function Calling.
        Operations operation = new Operations();

        /// <summary>
        /// Parameter Constructor for Setting Data.
        /// </summary>
        /// <param name="unit"></param>
        /// <param name="value"></param>
        public Volume(Unit unit, double value)
        {
            this.unit = unit;
            this.value = value;
        }

        /// <summary>
        /// Function For Checking Equality Of Volumes.
        /// </summary>
        /// <param name="object1"></param>
        /// <param name="object2"></param>
        /// <returns></returns>
        public bool IsEqual(object object1, object object2)
        {
            try
            {
                double object1ValueInLitre = operation.ConvertToBaseUnit((Volume)object1);
                double object2ValueInLitre = operation.ConvertToBaseUnit((Volume)object2);
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
            if (!(obj is Volume))
            {
                return false;
            }
            return (this.unit== ((Volume)obj).unit && this.value==((Volume)obj).value) || IsEqual(this,(Volume)obj);
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
