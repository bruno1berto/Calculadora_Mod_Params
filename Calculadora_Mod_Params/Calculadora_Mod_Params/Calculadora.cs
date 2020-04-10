

namespace Calculadora_Mod_Params
{
    class Calculadora
    {
        public static double Soma(params double[] numeros){
            double soma=0;
            foreach (int num in numeros){
                soma += num;
            }
            return soma;
        }
    }
}
