using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraIMC
{
    public static class CalculoIMC
    {
        public static double CalcularIMC(double peso, double altura)
        {
            return (Math.Round(peso / (altura * altura), 2));
        }
        public static string ClassificarIMC(double imc)
        {
            if (imc < 18.5)
            {
                return ("Abaixo do peso.");
            }
            else if (imc >= 1.85 && imc < 25.0)
            {
                return ("Peso normal.");
            }
            else if (imc >= 25.0 && imc < 30.0)
            {
                return ("Sobrepeso.");
            }
            else if (imc >= 30.0 && imc < 35.0)
            {
                return ("Obesidade Grau I.");
            }
            else if (imc >= 35.0 && imc < 40.0)
            {
                return ("Obesidade Grau II.");
            }
            else if (imc >= 40.0)
            {
                return ("Obesidade Grau III.");
            }
            else
            {
                return ("IMC inválido.");
            }
        }
    }
}
