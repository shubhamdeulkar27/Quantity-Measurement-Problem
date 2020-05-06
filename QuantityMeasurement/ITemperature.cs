using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMeasurement
{
    /// <summary>
    /// Interface For Implementing Temperature.
    /// </summary>
    interface ITemperature
    {
        /// <summary>
        /// Abstract Function For Equating Object's Values.
        /// </summary>
        /// <param name="object1"></param>
        /// <param name="object2"></param>
        /// <returns></returns>
        public abstract bool IsEqual(Temperature object1, Temperature object2);
    }
}
