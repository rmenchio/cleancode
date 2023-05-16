/*
 * A ideia principal é escolher nomes que sejam autodescritivos
 * com o propósito da variável, classe, função...
 * 
 * Se um nome precisa de um comentário para descreve-lo,
 * não é um bom nome
 */

namespace CleanCode.Cap2NomesSignificativos
{
	public class NomesRevelamProposito
	{
        public void Exemplo1_Variaveis()
        {
            /* Exemplo 1 - Variáveis */

            int d; // dias decorridos a partir do início.

            int diasDesdeInicio;

            // No exemplo acima, a escolha de um nome melhor para a variável
            // dispensou o uso de comentários.
        }

        public void Exemplo2_Funcoes()
        {
            /* Exemplo 2 - Funções */

            int numeroInteiro = 24;

            var resultado = Verificar(numeroInteiro);

            bool Verificar(int n)
            {
                if (n % 2 == 0)
                    return true;
                return false;
            }

            // Com o exemplo simplificado acima, não fica claro o que a função
            // faz logo nos primeiros segundos. Claro que se analisarmos com
            // calma, perceberemos que ela verifica se o dia que passamos é
            // par ou impar. Observe agora a versão abaixo, utilizando o
            // princípio de que os nomes devem revelar seus propósitos.

            bool numeroEhPar = NumeroEhPar(numeroInteiro);

            bool NumeroEhPar(int numeroInteiro)
            {
                if (numeroInteiro % 2 == 0)
                    return true;

                return false;
            }

            // O objetivo desse método fica muito mais claro,
            // logo em um primeiro momento. Este exemplo é simples
            // comparado ao que você encontrará no dia a dia,
            // mas demonstra bem o objetivo desse padrão.
        }
    }
}