using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMeasurement
{
    /// <summary>
    /// Class Volume For Setting Volume in Specified Unit.
    /// </summary>
    public class Volume:IVolume
    {
        //Variables.
        public Unit unit;
        public double value;

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
        public bool IsEqual(Volume object1, Volume object2)
        {
            try
            {
                double object1ValueInLitre = Operations.ConvertToLitre(object1);
                double object2ValueInLitre = Operations.ConvertToLitre(object2);
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
