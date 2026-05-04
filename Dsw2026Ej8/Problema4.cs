using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    public class Problema4
    {
        public double CalcularPromedio(int? nota1, int? nota2, int? nota3)
        {
            int suma = 0;
            int contador = 0;

            void ProcesarNota(int? nota)
            {
                if (nota.HasValue && nota >= 0 && nota <= 10)
                {
                    suma += nota.Value;
                    contador++;
                }
            }

            ProcesarNota(nota1);
            ProcesarNota(nota2);
            ProcesarNota(nota3);

            if (contador == 0)
                return 0;

            return (double)suma / contador;
        }
    }
}
