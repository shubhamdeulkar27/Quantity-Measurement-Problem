using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMeasurement
{
    /// <summary>
    /// IVolume Interface For Volume Units Implementation.
    /// </summary>
    interface IVolume
    {
        /// <summary>
        /// Abstract Function For Equality check.
        /// </summary>
        /// <param name="object1"></param>
        /// <param name="object2"></param>
        /// <returns></returns>
        public abstract bool IsEqual(Volume object1, Volume object2);
    }
}
