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
