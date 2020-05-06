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

        /// <summary>
        /// Abstract Function For Convert To Litre.
        /// </summary>
        /// <param name="objectName"></param>
        /// <returns></returns>
        public abstract double ConvertToLitre(Volume objectName);

        /// <summary>
        /// Abstract Function For Adding Volumes And Results into Litre.
        /// </summary>
        /// <param name="object1"></param>
        /// <param name="object2"></param>
        /// <returns></returns>
        public abstract double AddVolumes(Volume object1, Volume object2);

        /// <summary>
        /// Abstract Function For Convert To Kilograms.
        /// </summary>
        /// <param name="objectName"></param>
        /// <returns></returns>
        public abstract double ConvertToKiloGram(Weight objectName);

        /// <summary>
        /// Abstract Function For Adding Weights And Results into Kiograms.
        /// </summary>
        /// <param name="object1"></param>
        /// <param name="object2"></param>
        /// <returns></returns>
        public abstract double AddWeights(Weight object1, Weight object2);

        /// <summary>
        /// Abstract Function For Temperature To Convert into Celsius.
        /// </summary>
        /// <param name="objectName"></param>
        /// <returns></returns>
        public abstract double ConvertToCelsius(Temperature objectName);
    }
}
