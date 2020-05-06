using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMeasurement
{
    /// <summary>
    /// Interface for ConvertUnit Class.
    /// </summary>
    public interface IConvertUnit
    {
        /// <summary>
        /// Abstract Function For Unit Conversion.
        /// </summary>
        /// <param name="objectName"></param>
        /// <returns></returns>
        public abstract double ConvertToInch(Length objectName);
    }
}
