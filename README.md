# Clean Code com C# - .Net Core 7
Um repositório focado em disseminar os conhecimentos transmitidos através do livro Código Limpo, de Robert C. Martin, na linguagem C#.

A ideia é conseguir transmitir os conhecimentos do livro, principalmente em português, para ser acessível a pessoas que não compreendem o inglês e às pessoas que não tem condições de adquirir o livro. Nem todos os pontos serão abordados, pois há temáticas abstratas, onde a representação por código se torna dificultada.

# Práticas para evitar em determinados assuntos

### Comentários

- Informações inapropriadas nos comentários
    - Autor do código
    - Data da última atualização do código
- Comentários obsoletos
    - Regra de negócio antiga
- Comentários redundantes
    - Comentar o que o código faz exatamente, como por exemplo, “i++ // incrementa i”
- Comentário mal escrito
    - Falta de clareza
- Código como comentário

### Funções

- Parâmetros em excesso
- Parâmetros de saída
    - É melhor manipular o próprio objeto do que gerar um novo objeto como parâmetro de saída
- Parâmetros lógicos
- Função morta

### Geral

- Várias linguagens em um arquivo
- Comportamento óbvio de função não implementada
    - Tradução de string para dia não considerar SEG como segunda
- Comportamento incorreto nos limites de uma função
- Anular trechos de código de “segurança”, que impedem alguma ação
- Código duplicado
