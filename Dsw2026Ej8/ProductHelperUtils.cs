using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Dsw2026Ej8
{
    public partial class ProductHelper
    {
        private string FormatearPrecio(decimal price)
        {
            return price.ToString("C", CultureInfo.CurrentCulture);
        }
    }
}
