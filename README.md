## Problema:

Dado um array de inteiros e um número de objetivo, deverá retornar o índice dos dois números cujo a soma seja o objetivo.


**Exemplo**: 

```
entrada = [2, 7, 11, 15] e objetivo = 9
resposta; [0, 1]
```

## Soluções:

Ao estudar este problema, optei por tentar resolve-lo sem antes saber como fazer isso, e ao final cheguei a uma possibilidade semelhante a resposta original.

**Solução 1:**
	A primeira solução remete em verificar se o complemento de ```objetivo - atual``` está cadastrada em um dicionário de resultados. Caso positivo informa que uma resposta foi encontrada.
	Exemplo:
		Elemento 2:
			`9 - 2 = 7` -> valor 7 não está cadastrado no dicionário. Cadastramos o valor 2 no dicionário.
		Elemento 7:
			`9 - 7 = 2` -> o valor 2 está cadastrado no dicionário. Encontramos a soma.

**Solução 2:**
	A segunda solução remete em verificar se o valor atual do loop é um possível complemento para a soma.
	Exemplo:
		Elemento 2:
			`9 - 2 = 7` -> valor 2 não está cadastrado no dicionário. Cadastramos o valor 7 no dicionário.
		Elemento 7:
			`9 - 7 = 2` -> o valor 7 está cadastrado no dicionário. Encontramos a soma.

Ao implementar a segunda solução para este problema, notei um mínimo detalhe a respeito, não é necessário calcular o valor do complemento todas as vezes. Visto que comparamos o valor atual e não o valor do complemento. Reduzindo assim um ciclo de processamento desnecessário. (~no código irei deixar de uma maneira que as 2 soluções funcionem.~)

## Complexidade:

Por fim, a complexidade de ambas as implementações é **O(n)** pois iteramos sobre a lista apenas uma vez, passando por todos os elementos dela.