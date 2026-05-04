using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    public class Problema3
    {
        public string CompararCopias(int originalValue, Product product)
        {
            // 1. Copia por valor
            int copiaValor = originalValue;

            // 2. Incrementar solo la copia
            copiaValor++;

            // 3. Copia de referencia
            Product copiaProducto = product;

            // 4. Modificar el producto
            copiaProducto.SetDescription("Producto Modificado");

            // 5. Retornar resultado
            return $"{originalValue}-{copiaValor}-{product.GetDescription()}";
        }
    }
}
