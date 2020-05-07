using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMeasurement
{
    /// <summary>
    /// IVolume Interface For Volume Units Implementation.
    /// </summary>
    interface IQuantity
    {
        /// <summary>
        /// Abstract Function For Equality check.
        /// </summary>
        /// <param name="object1"></param>
        /// <param name="object2"></param>
        /// <returns></returns>
        public abstract bool IsEqual(object object1, object object2);
    }
}
