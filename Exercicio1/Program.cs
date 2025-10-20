﻿/*
Você está desenvolvendo uma calculadora para um sistema de caixa. 
Para facilitar o uso, o sistema precisa de um método de soma que funcione tanto com dois 
números inteiros quanto com três, e também com números decimais.

Sua missão é criar uma classe chamada Calculadora que possua um método chamado Somar. 
Esse método deve ser sobrecarregado para permitir as seguintes versões:

Somar dois inteiros.
Somar três inteiros.
Somar dois números decimais (double).
Depois, crie uma instância da classe e chame os três métodos, exibindo os resultados.

Exemplo de entrada:

Calculadora calc = new Calculadora();
Console.WriteLine(calc.Somar(10, 20));
Console.WriteLine(calc.Somar(5, 10, 15));
Console.WriteLine(calc.Somar(3.5, 2.8));
Copiar código
Exemplo de saída:

30
30
6,3
*/
using Exercicio1;

Calculadora calc = new Calculadora();
Console.WriteLine(calc.Somar(10, 20));
Console.WriteLine(calc.Somar(5, 10, 15));
Console.WriteLine(calc.Somar(3.5, 2.8));