/*
2) Dado a sequência de Fibonacci, onde se inicia por 0 e 1
e o próximo valor sempre será a soma dos 2 valores anteriores
(exemplo: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34...), escreva um programa
na linguagem que desejar onde, informado um número, ele calcule
a sequência de Fibonacci e retorne uma mensagem avisando se o 
número informado pertence ou não a sequência.
**OBS: escolhi C#**
*/
using System;

class Program
{
    static void Main() {
        Console.Write("Digite um número inteiro: ");
        int numero = Console.ReadLine()
        bool ehFibonacci = Verificar(numero);
	    
        if (ehFibonacci) {
            Console.WriteLine($"O número {numero} pertence à sequência de Fibonacci.");
        } else {
            Console.WriteLine($"O número {numero} NÃO pertence à sequência de Fibonacci.");
        }
    }

    static bool Verificar(int numero) {
        int a = 0, b = 1;
        while (b <= numero) {
            if (b == numero) {return true;}		
            int aux = a;
            a = b;
            b = temp + b;
        }
        return false; 
    }
}
