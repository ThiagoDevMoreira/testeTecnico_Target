using System;

class Program
{
    static void Main() {
        Console.Write("Digite um número inteiro: ");
        int numero = Console.ReadLine()

        bool ehFibonacci = Verificar(numero);

        if (ehFibonacci) {
            Console.WriteLine($"O número {numero} pertence à sequência de Fibonacci.");
        }
        else {
            Console.WriteLine($"O número {numero} NÃO pertence à sequência de Fibonacci.");
        }
    }

    static bool Verificar(int numero)
    {
        int a = 0, b = 1;

        while (b <= numero) {
		
            if (b == numero) {
                return true;
            }
			
            int aux = a;
            a = b;
            b = temp + b;
        }
		
        return false; 
    }
}
