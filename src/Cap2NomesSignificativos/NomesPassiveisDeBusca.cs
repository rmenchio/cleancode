/*
 * A ideia principal é escolher nomes que sejam fáceis de ser encontrados.
 * 
 * Escrever um nome que seja fácil de ser encontrado pelo control + f (windows)
 * ou command + f (macos) ajuda a elevar a produtividade.
 */
namespace CleanCode.Cap2NomesSignificativos
{
	public class NomesPassiveisDeBusca
	{
		void Exemplo1()
		{
			// Exemplo ruim, supondo que 34 seja um valor muito específico
			// para o seu negócio. Se você estiver procurando por algum número
			// que por coincidencia possua o 34, será um grande problema.

			int s = 0;
			int[] t = {1,2,3};

			for (int i = 0; i < 34; i++)
			{
				s += (t[i] * 4) / 5;
			}

			// Podemos resolver esse problema utilizando um nome para essa
			// constante, facilitando sua busca para um cenário futuro.

			const int NumeroMagicoDaEmpresa = 34;

            for (int i = 0; i < NumeroMagicoDaEmpresa; i++)
            {
                s += (t[i] * 4) / 5;
            }

			// Neste caso, se o numero mágico da empresa mudar, a busca
			// por esse número será muito mais simples.
        }

	}
}