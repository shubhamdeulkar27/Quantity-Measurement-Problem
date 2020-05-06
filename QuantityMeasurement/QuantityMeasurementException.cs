using System;

namespace QuantityMeasurement
{
    /// <summary>
    /// Class For Custom Exception.
    /// </summary>
    public class QuantityMeasurementException : Exception
    {
        /// <summary>
        /// Enum For Defining Custom Exceptions.
        /// </summary>
        public enum ExceptionType { INVALID_TYPE }

        ExceptionType type;

        /// <summary>
        /// Constuctor For Throwing Exception.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="message"></param>
        public QuantityMeasurementException(QuantityMeasurementException.ExceptionType type, string message) : base(message)
        {
            this.type = type;
        }
    }
}