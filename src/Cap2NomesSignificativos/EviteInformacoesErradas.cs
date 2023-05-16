/*
 * A ideia principal é atentar-se a nomes que tenham muitos significados
 * em áres diferentes.
 * 
 * Um bom exemplo disso é um cenário onde você tem uma lista de informações,
 * mas que no universo dos códigos, não são uma lista propriamente.
 * 
 * Caso você utilize o nome lista, pode confundir futuros programadores ou até
 * você mesmo. Veja os exemplos.
 */

namespace CleanCode.Cap2NomesSignificativos
{
	public class EviteInformacoesErradas
	{
		void Exemplo1_NomesComMuitosSignificados()
		{
			var listaTelefonica = "Tele Lista";

			// Neste caso, utilizamos o nome "lista" para algo que
			// na realidade é uma string, o que pode gerar confusão.

			var hp = Math.Sqrt(25);

			// Neste exemplo acima, para mim fica claro que hp
			// significa hipotenusa, mas pode gerar uma grande confusão,
			// por significar tbm a empresa HP de impressoras ou alguma
			// outra coisa. Prefira pelo formato abaixo.

			var hipotenusa = Math.Sqrt(25);
        }

		void Exemplo2_NomesMuitoParecidos()
		{
			var areaDeUmTrianguloEscaleno = 110;

            var areaDeUmTrianguloEquilatero = 62;

			// Supondo que esses sejam recursos de uma classe importante
			// em seu sistema. O fato de terem nomes parecidos podem confundir
			// um programador no momento de sua importação ou uso. Evite isso.
        }

		void Exemplo3_LetrasParecidasComNumeros()
		{
			int a = 1;
			int o = 1;
			int l = 2;

			if (a-o == 0)
			{
				l = 1;
			}

			// A confusão visual que esse trecho de código causa reduz
			// bastante a produtividade. Evite ao máximo esse tipo de situação.
		}
	}
}