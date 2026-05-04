using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    public class Product
    {
        private string description;

        public void SetDescription(string desc)
        {
            description = desc;
        }

        public string GetDescription()
        {
            return description;
        }
    }
}