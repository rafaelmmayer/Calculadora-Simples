using System;

namespace CalculadoraLibrary
{
    public static class Operacoes
    {
        public static double Somar(double x, double y)
        {
            return x + y;
        }

        public static double Subtrair(double x, double y)
        {
            return x - y;
        }

        public static double Multiplicar(double x, double y)
        {
            return x * y;
        }

        public static double Dividir(double x, double y)
        {
            return x / y;
        }

        public static string ValidacaoNums(string x, string y)
        {
            if (!double.TryParse(x, out double parseX))
            {
                return "Valor 1 inválido";
            }

            if (!double.TryParse(y, out double parseY))
            {
                return "Valor 2 inválido";
            }

            return "Valores válidos";
        }
    }
}
