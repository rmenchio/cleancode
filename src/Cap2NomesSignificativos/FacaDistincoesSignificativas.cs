/*
 * A ideia principal é evitar variáveis que além de não possuirem 
 * nomes significativos, não possuem uma distinção fácil de ser compreendida.
 */

namespace CleanCode.Cap2NomesSignificativos
{
	public class FacaDistincoesSignificativas
	{
		void Exemplo1()
		{
			void CopiarListaRuim(int[] a1, int[] a2)
			{
				for (int i = 0; i < a1.Length; i++)
				{
					a2[i] = a1[i];
				}
			}

            void CopiarListaBom(int[] origem, int[] destino)
            {
                for (int i = 0; i < origem.Length; i++)
                {
                    destino[i] = origem[i];
                }
            }

			// Nos exemplos acima, fica claro como uma boa distinção
			// entre os nomes das variáveis já explica de cara seu objetivo.
        }

        void Exemplo2()
        {
            void GetContaAtiva(){ }
            void GetContasAtivas() { }
            void GetInfoContasAtivas() { }

            // Como um programador que chega ao projeto e se depara com esses 3
            // métodos pode decidir qual deles vai utilizar? O nome do método
            // não nos disse absolutamente nada. Evite ao máximo isso,
            // utilizando nomes de funções explicativas, assim como os
            // parametros.
        }
    }
}