using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMeasurement
{
    /// <summary>
    /// Interface For Length Class.
    /// </summary>
    interface ILength
    {
        /// <summary>
        /// Enum For Unit.
        /// </summary>
        public enum Unit { }

        /// <summary>
        /// Abstract Function IsEqual.
        /// </summary>
        /// <param name="object1"></param>
        /// <param name="object2"></param>
        /// <returns></returns>
        public abstract bool IsEqual(Length object1, Length object2);
    }
}
