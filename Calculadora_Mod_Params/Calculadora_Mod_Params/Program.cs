using System;

namespace Calculadora_Mod_Params
{
    class Program
    {
        static void Main(string[] args){
            
            double[] numeros = new double[] { 2, 4, 6 };
            double s1 = Calculadora.Soma(numeros);
            Console.WriteLine("Resultado = " + s1);

        }
    }
}
