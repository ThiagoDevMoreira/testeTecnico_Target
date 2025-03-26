/*
exercicio5-InverteString.cs
5) Escreva um programa que inverta os caracteres de um string.
IMPORTANTE:
a) Essa string pode ser informada através de qualquer entrada de sua preferência ou pode ser previamente definida no código;
b) Evite usar funções prontas, como, por exemplo, reverse;
NÃO SE ESQUEÇA DE INSERIR O LINK DO SEU REPOSITÓRIO NO GITHUB COM O CÓDIGO FONTE QUE VOCÊ DESENVOLVEU
*/
using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite uma texto para inverter: ");
        string texto_para_inverter= Console.ReadLine();
        string texto_invertido = Inverter_Texto(texto_para_inverter);
        Console.WriteLine($"Texto invertido: {texto_invertido}");
    }
	
    static string Inverter_Texto(string texto) {
        string texto_invertido = "";

        for (int i = texto.Length - 1; i >= 0; i--) {
            texto_invertido += texto[i];
        }
        return texto_invertido;
    }
}
