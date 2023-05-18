/*
 * A ideia principal é manter as funções com o menor numero
 * possível de parametros. Sendo o ideal mante-las com no máximo 2 parâmetros.
 * Utilizar 3 parametros deve ser em um caso especial.
 * 
 */
namespace CleanCode.Cap3Funcoes
{
	public class ParametrosDeFuncoes
	{
		/* 
		 * Um exemplo para reduzir a quantidade de parametros em uma função é
		 * transformar os parametros, se possível, em um objeto.
		 */

		string Nome = "Rodrigo";
		string Sobrenome = "Menchio";
		int Idade = 24;
		float Altura = 1.86f;

		void Exemplo1(string nome, string sobrenome, int idade, float Altura)
		{
			/* 
			 * O que quer que esse bloco faça, já assusta no primeiro momento,
			 * só pela quantidade de parametros, além de dificultar os testes
			 * de unidade.
			 */
		}

		object DadosPessoais = new
		{
			Nome = "Rodrigo",
			Sobrenome = "Menchio",
			Idade = 24,
			Altura = 1.86f
		};

		void Exemplo2(object DadosPessoais)
		{
			/* 
			 * Além da quantidade de parametros reduzida, os testes de unidade
			 * serão muito mais fáceis de serem construídos, por conta da 
			 * produtividade gerada pela legibilidade do código.
			 */
		}

        /*
		 * Notas: evite passar booleanos como parametro para uma função,
		 * "marretados", como por exemplo Funcao(true). 
		 * 
		 * Prefira por passar booleanos assinados com um nome na variavel.
		 * Algo como:
		 * bool verificar = true
		 * Funcao(verificar)
		 * pois deixa claro o objetivo do booleano.
		 */

        void Exemplo3()
		{
			// Prefira isso
			bool execucaoRapida = true;

            TestesParametrosDeFuncoes.Exemplo3(execucaoRapida);

            // Ao invés disso

            TestesParametrosDeFuncoes.Exemplo3(true);
        }

		
	}

	public static class TestesParametrosDeFuncoes
    {
        public static void Exemplo3(bool fazAlgo)
        {

        }
    }
}