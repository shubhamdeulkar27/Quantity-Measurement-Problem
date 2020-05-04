using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMeasurement
{
    public class Inch
    {
        private double value;

        public Inch(double value)
        {
            this.value = value;
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (!(obj is Inch))
            {
                return false;
            }
            return (this.value == ((Inch)obj).value);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
