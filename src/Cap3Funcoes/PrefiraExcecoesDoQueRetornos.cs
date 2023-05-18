/*
 * A ideia principal é preferir por exceções do que retornos de erro.
 * Isso porque provavelmente se voce retornar erros, terá que fazer um
 * if-else para saber o que fazer.
 * 
 * Um bloco try-catch pode ser melhor nessa situação.
 */

namespace CleanCode.Cap3Funcoes
{
	public class PrefiraExcecoesDoQueRetornos
	{
		/* 
		 * Em um exemplo mais real, podemos imaginar uma consulta 
		 * a um banco de dados.
		 */

		void Exemplo1_SemExcecao()
		{
			var encontrou = TestePrefiraExcecoesDoQueRetornos.BancoDeDados_RetornoDeErro();

			if (encontrou)
				Console.WriteLine("Deu bom");
			else
                Console.WriteLine("Deu ruim");
        }

        void Exemplo1_ComExcecao()
        {
			try
			{
                TestePrefiraExcecoesDoQueRetornos.BancoDeDados_Excecao();
            }
			catch (Exception e)
			{
                Console.WriteLine(e.Message);
            }
        }
    }

	public static class TestePrefiraExcecoesDoQueRetornos
	{
		public static bool BancoDeDados_RetornoDeErro()
		{
			/* Abstraindo uma consulta de dados */

			// Suponha que false signifique que o sistema foi ao
			// banco de dados e não encontrou o que foi pedido.

			return false;
		}

        public static bool BancoDeDados_Excecao()
        {
			/* Abstraindo uma consulta de dados */

			// Suponha que a exceção signifique que o sistema foi ao
			// banco de dados e não encontrou o que foi pedido.

			throw new Exception("Deu ruim.");
        }
    }
}