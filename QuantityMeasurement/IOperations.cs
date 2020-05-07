using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMeasurement
{
    /// <summary>
    /// Interface for Operations Class.
    /// </summary>
    public interface IOperations
    {
        /// <summary>
        /// Abstract Function For BaseUnit Convertion Implementation.
        /// </summary>
        /// <param name="inputObject"></param>
        /// <returns></returns>
        public abstract double ConvertToBaseUnit(object inputObject);

        /// <summary>
        /// Abstract Function For Addition Of Two Measurements Implementation.
        /// </summary>
        /// <param name="object1"></param>
        /// <param name="object2"></param>
        /// <returns></returns>
        public abstract double Add(object object1, object object2);
    }
}
