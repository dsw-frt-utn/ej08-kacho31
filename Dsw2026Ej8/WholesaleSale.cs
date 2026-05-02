using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    public class WholesaleSale : Sale
    {
        public WholesaleSale(decimal amount) : base(amount)
        {
        }

        public override decimal CalculateTotal()
        {
            return Amount - (Amount * 0.10m); //10% de descuento
        }
    }
}
