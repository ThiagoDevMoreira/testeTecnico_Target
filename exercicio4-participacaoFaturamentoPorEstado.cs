/*
ecercicio4-participacaoFaturamentoPorEstado.cs
4) Dado o valor de faturamento mensal de uma distribuidora, detalhado por estado:
• SP – R$67.836,43
• RJ – R$36.678,66
• MG – R$29.229,88
• ES – R$27.165,48
• Outros – R$19.849,53
Escreva um programa na linguagem que desejar onde calcule o percentual de representação que cada estado teve dentro do valor total mensal da distribuidora.  
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.IO;

class Program
{
    static void Main()
    {
		Console.Write("Digite o caminho do arquivo JSON (URI local): ");
		string caminho_do_arquivo = Console.ReadLine();
		
        List<FaturamentoPorEstado> faturamento = Preparar_Lista_de_Faturamento_Mensal_Por_Estado(caminho_do_arquivo);
        float faturamento_total = Obter_Total_de_Faturamento(faturamento);
        foreach (var estado_da_vez in Obter_Lista_de_Estados(faturamento)) {
			
            float total_nominal_estadual = Obter_Faturamento_Estadual(faturamento, estado_da_vez);
            float representacao_percentual = Calcular_Representacao_Estadual(faturamento, estado_da_vez);
            Console.WriteLine($"Em {estado_da_vez}, o faturamento foi de {total_nominal_estadual}, representando {representacao_percentual:F2}% do total de {faturamento_total:F2}.");
        }
    }

    static List<FaturamentoPorEstado> Preparar_Lista_de_Faturamento_Mensal_Por_Estado(string caminho_do_arquivo)
		//string json = File.ReadAllText(caminho_do_arquivo);
        // Mock de dados
        string json = @"
        [
            {""Estado"": ""SP"", ""Valor"": 67836.43},
            {""Estado"": ""RJ"", ""Valor"": 36678.66},
            {""Estado"": ""MG"", ""Valor"": 29229.88},
            {""Estado"": ""ES"", ""Valor"": 27165.48},
            {""Estado"": ""Outros"", ""Valor"": 19849.53}
        ]";
        List<FaturamentoPorEstado> faturamento_por_estado = JsonSerializer.Deserialize<List<FaturamentoPorEstado>>(json);
        return faturamento_por_estado;
    }

    static float Calcular_Representacao_Estadual(List<FaturamentoPorEstado> faturamento_por_estado, string estado) {
        float faturamento_total = Obter_Total_de_Faturamento(faturamento_por_estado);
        float faturamento_estadual = Obter_Faturamento_Estadual(faturamento_por_estado, estado);
        // Retorno em porcentagem (0 ~ 100)
        return faturamento_estadual * 100 / faturamento_total;
    }

    static string[] Obter_Lista_de_Estados(List<FaturamentoPorEstado> faturamento_por_estado) {
        return faturamento_por_estado.Select(item => item.Estado).ToArray();
    }

    static float Obter_Total_de_Faturamento(List<FaturamentoPorEstado> faturamento_por_estado) {
        return faturamento_por_estado.Sum(item => item.Valor);
    }

    static float Obter_Faturamento_Estadual(List<FaturamentoPorEstado> faturamento_por_estado, string estado) {
        return faturamento_por_estado
            .Where(item => item.Estado == estado)
            .Sum(item => item.Valor);
    }
}

class FaturamentoPorEstado {
    public string Estado { get; set; }
    public float Valor { get; set; }
}
