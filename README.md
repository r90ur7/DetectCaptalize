## Intuition  
Minha intuição para resolver este problema é identificar os padrões de uso correto das letras maiúsculas na palavra.  
A ideia principal é contar quantas letras estão em maiúsculas e, em seguida, comparar essa contagem com as condições válidas:

- Todas as letras são maiúsculas.  
- Todas as letras são minúsculas.  
- Apenas a primeira letra é maiúscula.  

---

## Approach  
A abordagem consiste em percorrer cada caractere da palavra para contar quantas letras estão em maiúsculas.  
Após essa contagem, o método verifica se:

1. A contagem é igual ao tamanho da palavra (todas maiúsculas),  
2. A contagem é zero (todas minúsculas), ou  
3. A contagem é um e a primeira letra é maiúscula (apenas a primeira letra maiúscula).  

Se uma dessas condições for atendida, a função retorna `true`; caso contrário, retorna `false`.  

---

## Complexity  
**Time complexity:**  
- O(n), onde `n` é o tamanho da palavra, já que cada caractere é analisado uma única vez.  

**Space complexity:**  
- O(1), pois o espaço utilizado é constante e independente do tamanho da entrada.
# DesafioApp

## Executando Testes

### Visual Studio

1. Abra o Visual Studio e carregue a solução do seu projeto.
2. No cli do projeto digite "dotnet test"

3. Os resultados serão obtidos na saida de seu comando

### Visual Studio Code

1. Abra o Visual Studio Code e carregue a pasta do seu projeto.

3. clique com o botão direito na Program.cs da Pasta DesafioAPP e clique em "executar testes"

4. Os resultados dos testes serão exibidos na janela de saída.

## Estrutura do Projeto

- `DesafioApp/Program.cs`: Contém a lógica principal do aplicativo.
- `DesafioTests/UnitTest1.cs`: Contém os testes unitários para o aplicativo.

## Dependências

- .NET
- xUnit

## Como Executar

1. Clone o repositório.
2. Abra o projeto no Visual Studio ou Visual Studio Code.
3. Siga as instruções acima para executar os testes.

