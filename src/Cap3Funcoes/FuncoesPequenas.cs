/*
 * A ideia principal é manter as funções o menor possível,
 * e com objetivos claros, mantendo um dos princípios SOLID
 * 
 * É valido lembrar que esses exemplos são aleatórios e podem não
 * ter similaridade com o dia a dia de um programador, mas a ideia central
 * pode ser aplicada em diversos cenários.
 * 
 * O objetivo da função será descobrir se um numero qualquer é primo.
 * Caso seja primo, precisamos saber se é maior que 100.
 * E por fim, se for maior que 100, devemos dividir por 2, caso contrário,
 * somar 500. Se não for primo, o resultado é o valor dividido por 3.
 */

using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CleanCode.Cap3Funcoes
{
    public class FuncoesPequenas
    {
        /* Exemplo utilizando uma função ruim */
        void ExemploRuim()
        {
            int numero = 1231;
            int resultado;

            bool ehPrimo = true;

            if (numero <= 1)
            {
                ehPrimo = false;
            }

            for (int i = 2; i <= Math.Sqrt(numero); i++)
            {
                if (numero % i == 0)
                {
                    ehPrimo = false;
                }
            }

            if (ehPrimo)
            {
                if(numero > 100)
                {
                    resultado = numero / 2;
                }
                else
                {
                    resultado = numero + 500;
                }
            }
            else
            {
                resultado = numero / 3;
            }
        }

        /* 
         * Exemplo utilizando uma função boa
         * Pode parecer bobo em um primeiro momento, mas além de segregar
         * as responsabilidades, conseguimos dar títulos aos trechos de código.
         */
        void ExemploBom()
        {
            int numero = 1231;

            int resultado;

            bool numeroEhPrimo = VerificarPrimo(numero);

            if (numeroEhPrimo)
            {
                bool numeroMaiorQue100 = NumeroMaiorQue100(numero);

                if (numeroMaiorQue100)

                    resultado = numero / 2;
                else
                    resultado = numero / 3;
            }

        }

        private bool NumeroMaiorQue100(int numero)
        {
            if (numero > 100)
                return true;
            return false;
        }

        private bool VerificarPrimo(int numero)
        {
            if (numero <= 1)
                return false;

            for (int i = 2; i <= Math.Sqrt(numero); i++)
            {
                if (numero % i == 0)
                    return false;
            }

            return true;
        }
    }
}

