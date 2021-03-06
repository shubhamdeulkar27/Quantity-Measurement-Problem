﻿using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMeasurement
{
    public class Weight:IQuantity
    {
        //Variables.
        public Unit unit;
        public double value;

        //Creating Instance Of Operation Class For Function Calling.
        Operations operation = new Operations();

        /// <summary>
        /// Parameter Constructor For Setting Unit Anf Value.
        /// </summary>
        /// <param name="unit"></param>
        /// <param name="value"></param>
        public Weight(Unit unit, double value)
        {
            this.unit = unit;
            this.value = value;
        }

        /// <summary>
        /// Function To Check Equality Of Two Objects Values.
        /// </summary>
        /// <param name="object1"></param>
        /// <param name="object2"></param>
        /// <returns></returns>
        public bool IsEqual(object object1, object object2)
        {
            try
            {
                double object1ValueInLitre = operation.ConvertToBaseUnit((Weight)object1);
                double object2ValueInLitre = operation.ConvertToBaseUnit((Weight)object2);
                if (object1ValueInLitre == object2ValueInLitre)
                {
                    return true;
                }
            }
            catch (Exception)
            {
                throw new QuantityMeasurementException(QuantityMeasurementException.ExceptionType.INVALID_TYPE, "Invalid Type");
            }
            return false;
        }

        /// <summary>
        /// Overriding Equals Function.
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (!(obj is Weight))
            {
                return false;
            }
            return (this.unit == ((Weight)obj).unit && this.value == ((Weight)obj).value) || IsEqual(this,(Weight)obj);
        }

        /// <summary>
        /// Overriding GetHashCode Function.
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
