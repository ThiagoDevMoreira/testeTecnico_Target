/*
3) Dado um vetor que guarda o valor de faturamento diário de uma distribuidora, faça um programa, na linguagem que desejar, que calcule e retorne:
  * O menor valor de faturamento ocorrido em um dia do mês;
  * O maior valor de faturamento ocorrido em um dia do mês;
  * Número de dias no mês em que o valor de faturamento diário foi superior à média mensal.

IMPORTANTE:
a) Usar o json ou xml disponível como fonte dos dados do faturamento mensal;
b) Podem existir dias sem faturamento, como nos finais de semana e feriados. Estes dias devem ser ignorados no cálculo da média;
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.IO;

class Program
{
    static void Main() {
		Console.Write("Digite o caminho do arquivo JSON (URI local): ");
		string caminho_do_arquivo = Console.ReadLine();

		float[] faturamento_diario = Preparar_Array_de_Faturamento_Diario(caminho_do_arquivo);

		float maior_faturamento = Obter_Maior_Faturamento(faturamento_diario);
		float menor_faturamento = Obter_Menor_Faturamento(faturamento_diario);
		float media_faturamento = Obter_Media_de_Faturamento(faturamento_diario);
		int dias_acima_da_media = Obter_Dias_Acima_da_Media(faturamento_diario);

		Console.WriteLine($"Maior faturamento: {maiorFaturamento}");
		Console.WriteLine($"Menor faturamento: {menorFaturamento}");
		Console.WriteLine($"Média de faturamento: {mediaFaturamento}");
		Console.WriteLine($"Dias com faturamento acima da média: {diasAcimaDaMedia}");
	}

	static float Obter_Maior_Faturamento (float[] faturamento_diario) {
		float maior = float.MinValue
		foreach (float valor in faturamento_diario) {
			if (valor > maior) {maior = valor} 
		}
		return maior
	}
	
    static float Obter_Menor_Faturamento (float[] faturamento_diario) {
        float menor = float.MaxValue
		foreach (float valor in faturamento_diario) {
			if (valor < menor) {menor = valor} 
		}
		return menor
	}
	
	static float Obter_Media_de_Faturamento (float[] faturamento_diario) {
		float soma = 0
		int dias_validos = 0
		foreach (float valor in faturamento_diario) {
			soma += valor
			if (valor > 0) {dias_validos += 1}
		}
		return soma / dias_validos
		/*
		Considerei usar a função `Average()` disponível pela bilbioteca Linq
		mas no outro exercício pede para não usar a solução "mais automática",
		então adotei essa abordagem aqui também.
		*/
	}
	
	static int Obter_Dias_Acima_da_Media (float[] faturamento_diario) {
		float media = Obter_Media_de_Faturamento(faturamento_diario)
		int dias_acima_da_media = 0
		foreach (float valor in faturamento_diario) {
			if (valor > media) { dias_acima_da_media += 1}
		}
		return dias_acima_da_media
	}
	
	static float[] Preparar_Array_de_Faturamento_Diario (string caminho_do_arquivo) {
            	string json = File.ReadAllText(caminho_do_arquivo);
		var dados_json = JsonSerializer.Deserialize<List<itemFaturamento>>(json);
 	    	float[] faturamento_diario = dados_json.Select(item => item.Valor).ToArray();
            	return faturamento_diario;
	}
}

class itemFaturamento {
    public integer Dia { get; set; }
    public float Valor { get; set; }
}
