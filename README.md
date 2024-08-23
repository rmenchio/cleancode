# Clean Code com C# - .Net Core 7
Um repositório focado em disseminar os conhecimentos transmitidos através do livro Código Limpo, de Robert C. Martin, na linguagem C#.

A ideia é conseguir transmitir os conhecimentos do livro, principalmente em português, para ser acessível a pessoas que não compreendem o inglês e às pessoas que não tem condições de adquirir o livro. Nem todos os pontos serão abordados, pois há temáticas abstratas, onde a representação por código se torna dificultada.

# Boas práticas

### Comentários

- Evitar informações inapropriadas nos comentários
    - Autor do código
    - Data da última atualização do código
- Evitar comentários obsoletos
    - Regra de negócio antiga
- Evitar comentários redundantes
    - Comentar o que o código faz exatamente, como por exemplo, “i++ // incrementa i”
- Evitar comentário mal escrito
    - Falta de clareza
- Evitar códigos como comentário

### Funções

- Evitar funções com parâmetros em excesso
- Evitar funções com parâmetros de saída
    - É melhor manipular o objeto recebido por parâmetro do que gerar um novo objeto como retorno da função
- Evitar funções com parâmetros lógicos (true/false)
- Evitar funções morta
    - Funções que não são utilizadas em nenhum lugar 

### Geral

- Evitar várias linguagens em um arquivo
- Evite funções sem um comportamento óbvio
    - Tradução de string para dia não considerar SEG como segunda
- Evite funções com comportamento incorreto nos limites
- Não remova trechos de código de “segurança” que impedem alguma ação para conseguir prosseguir com a ação
- Evite código duplicado
- Evite código morto
- Evite declarações de variáveis distantes do seu primeiro uso
- Não utilize múltiplas abordagens para resolver o mesmo problema em trechos diferentes de código
- Evite construtores sem implementação
- Evite propósitos de funções obscuras.
    - Geralmente pode ser evitado utilizado um nome autodescritivo para a ação da função 
- Não dê responsabilidades às funções de forma inadequada
- Evite variáveis não descritivas
- Evite nomes de funções sem clareza
- Evite números mágicos sem um nome adequado.
    - O melhor é utilizar um nome para um número mágico, por exemplo, SECONDS_PER_DAY = 86400
- Evite condições negativas para as funções booleanas
- Evite dar mais de uma responsabilidade para uma função

### Nomes

- Utilize nomes coerentes para funções e variáveis
- Escolha nomes apropriados para o nível de abstração
- Utilize convenções ao definir nomes
    - Async
    - toString
- O tamanho do nome de uma função deve ser proporcional ao seu escopo
- Se uma função tem mais de um efeito colateral, escreva um nome que explicite isso
    - FazAlgoOuRetornaErro()
