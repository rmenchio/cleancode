/*
 * A ideia principal é evitar ao máximo uma função que tenha
 * tanto o objetivo de consulta quanto o de ação.
 * 
 * Esse padrão é um dos pilares do CQRS.
 */
namespace CleanCode.Cap3Funcoes
{
	public class SepararComandoDeConsulta
	{
        /* 
		 * O exemplo aqui será um pouco maior.
		 * 
		 * Baseado na ideia de uma lista com 3 objetos, utilizarei uma função
		 * para alterar um atributo desses objetos, mas terá uma regra.
		 * Essa alteração só pode ocorrer se um campo bool for true.
		 * 
		 */

        void ExemploComandoConsultaJuntos()
        {
            TesteSepararComandoDeConsulta.ExemploComandoConsultaJuntos("Rodrigo", "Digão");
        }

        /*
         * Um exemplo para mostrar como ficaria essa separação é o seguinte
         * 
         * Consultar primeiro o objeto e só assim alterar o nome.
         */

        void ExemploComandoConsultaSeparados()
        {
            /* Abstraindo a construção do objeto */
            ObjetoTesteSepararComandoDeConsulta objeto =
                new ObjetoTesteSepararComandoDeConsulta();

            // Suponha que seja uma consulta em uma base de dados.
            bool objetoExite = TesteSepararComandoDeConsulta.ExemploConsulta("Rodrigo");

            if (objetoExite)
                objeto.ExemploComando("Digão");

        }

        /*
         * Talvez pareça mais simples utilizar uma função só para resolver
         * o problema, mas além de quebrar diversos padrões, pode lhe trazer
         * grandes problemas no futuro, como bugs e sistemas 
         * legado precocemente. 
         */

    }

    public static class TesteSepararComandoDeConsulta
	{
        static List<ObjetoTesteSepararComandoDeConsulta> lista =
            new List<ObjetoTesteSepararComandoDeConsulta>
            {
                        new ObjetoTesteSepararComandoDeConsulta
                        {
                            Nome = "Maria",
                            PodeAlterarNome = true
                        },
                        new ObjetoTesteSepararComandoDeConsulta
                        {
                            Nome = "Joao",
                            PodeAlterarNome = false
                        },
                        new ObjetoTesteSepararComandoDeConsulta
                        {
                            Nome = "Rodrigo",
                            PodeAlterarNome = false
                        }
            };

        public static void ExemploComandoConsultaJuntos(string nome, string novoNome)
        {
            /* Abstraindo a implementação */

            // Tenha em mente que o código verificará
            // se o campo "PodeAlterarNome" é true,
            // para o objeto com o nome = "Rodrigo" e só então vai
            // alterar para digão.
        }

        public static bool ExemploConsulta(string nome)
        {
            /* Abstraindo a implementação */

            return true;
        }
    }

	public class ObjetoTesteSepararComandoDeConsulta
	{
		public string Nome { get; set; }
		public bool PodeAlterarNome { get; set; }

        public void ExemploComando(string novoNome)
        {
            /* Abstraindo a implementação */
        }
    }
}