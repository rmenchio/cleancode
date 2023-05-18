/*
 * A ideia principal é isolar mais ainda as exceções,
 * para que fique mais legível ainda.
 * 
 * Baseado na classe CleanCode.Cap3Funcoes.PrefiraExcecoesDoQueRetornos, 
 * podemos melhoras mais ainda a visualização do nosso código.
 * 
 * Suponha que dentro de um try-catch haja 3 ações que podem gerar exceção.
 * Separa-las em uma quarta ação deixa o código muito legível. 
 */

namespace CleanCode.Cap3Funcoes
{
	public class ExtraiaBlocosTryCatch
	{
		void Exemplo1_TryCatchComplexo()
		{
			try
			{
				TesteExtraiaBlocosTryCatch.Acao1();
                TesteExtraiaBlocosTryCatch.Acao2();
                TesteExtraiaBlocosTryCatch.Acao3();

            }
			catch(Exception e)
			{
				Console.WriteLine(e.Message);
			}
		}

        void Exemplo2_TryCatchExtraido()
        {
            try
            {
                TesteExtraiaBlocosTryCatch.ExecutarAcoes();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }

	public static class TesteExtraiaBlocosTryCatch
	{
        public static void Acao1()
		{
			throw new Exception();
		}

        public static void Acao2()
        {
            throw new Exception();
        }

        public static void Acao3()
        {
            throw new Exception();
        }

        public static void ExecutarAcoes()
        {
            Acao1();
            Acao2();
            Acao3();
        }
    }
}