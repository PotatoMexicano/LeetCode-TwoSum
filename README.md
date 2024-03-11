## Problema:

Dado um array de inteiros e um n�mero de objetivo, dever� retornar o �ndice dos dois n�meros cujo a soma seja o objetivo.


**Exemplo**: 

```
entrada = [2, 7, 11, 15] e objetivo = 9
resposta; [0, 1]
```

## Solu��es:

Ao estudar este problema, optei por tentar resolve-lo sem antes saber como fazer isso, e ao final cheguei a uma possibilidade semelhante a resposta original.

**Solu��o 1:**
	A primeira solu��o remete em verificar se o complemento de ```objetivo - atual``` est� cadastrada em um dicion�rio de resultados. Caso positivo informa que uma resposta foi encontrada.
	Exemplo:
		Elemento 2:
			`9 - 2 = 7` -> valor 7 n�o est� cadastrado no dicion�rio. Cadastramos o valor 2 no dicion�rio.
		Elemento 7:
			`9 - 7 = 2` -> o valor 2 est� cadastrado no dicion�rio. Encontramos a soma.

**Solu��o 2:**
	A segunda solu��o remete em verificar se o valor atual do loop � um poss�vel complemento para a soma.
	Exemplo:
		Elemento 2:
			`9 - 2 = 7` -> valor 2 n�o est� cadastrado no dicion�rio. Cadastramos o valor 7 no dicion�rio.
		Elemento 7:
			`9 - 7 = 2` -> o valor 7 est� cadastrado no dicion�rio. Encontramos a soma.

Ao implementar a segunda solu��o para este problema, notei um m�nimo detalhe a respeito, n�o � necess�rio calcular o valor do complemento todas as vezes. Visto que comparamos o valor atual e n�o o valor do complemento. Reduzindo assim um ciclo de processamento desnecess�rio. (~no c�digo irei deixar de uma maneira que as 2 solu��es funcionem.~)

## Complexidade:

Por fim, a complexidade de ambas as implementa��es � **O(n)** pois iteramos sobre a lista apenas uma vez, passando por todos os elementos dela.