using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMeasurement
{
    /// <summary>
    /// Interface for ConvertUnit Class.
    /// </summary>
    public interface IOperations
    {
        /// <summary>
        /// Abstract Function For Unit Conversion.
        /// </summary>
        /// <param name="objectName"></param>
        /// <returns></returns>
        public abstract double ConvertToInch(Length objectName);

        /// <summary>
        /// Abstract Fiunction For Addition Of Lengths.
        /// </summary>
        /// <param name="object1"></param>
        /// <param name="object2"></param>
        /// <returns></returns>
        public abstract double AddLengths(Length object1, Length object2);
    }
}
