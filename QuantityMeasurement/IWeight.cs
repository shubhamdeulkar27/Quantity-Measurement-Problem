using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMeasurement
{
    /// <summary>
    /// Interface For Weight Implementation.
    /// </summary>
    interface IWeight
    {
        /// <summary>
        /// Abstract Function For Checking Equal Values Implemenattion.
        /// </summary>
        /// <param name="object1"></param>
        /// <param name="object2"></param>
        /// <returns></returns>
        public abstract bool IsEqual(Weight object1, Weight object2);
    }
}
