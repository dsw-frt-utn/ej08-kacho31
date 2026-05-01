using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    public partial class ProductHelper
    {
        private const string FormatoMoneda = "C2";

        private string FormatearPrecio(decimal price)
        {
            return price.ToString(FormatoMoneda);
        }
    }
}
