# 1) Observe o trecho de código abaixo: int INDICE = 13, SOMA = 0, K = 0;
# Enquanto K < INDICE faça { K = K + 1; SOMA = SOMA + K; }
# Imprimir(SOMA);
# Ao final do processamento, qual será o valor da variável SOMA?
# ** Resposta: no final a soma é 91**

# script em pyton correspondente ao exercício 1
def calcular_soma(num):
    soma = 0
    k = 0
    
    while k < num:
        k += 1
        soma += k
    
    return soma

# outra forma de fazer isso
def calcular_soma_sem_loop(num)
    return (num + 1) * (num / 2)
    
numero = int(input("Digite um número inteiro: "))
resultado = calcular_soma(num)

print(f"O valor da soma dos números de 1 a {num} é: {resultado}")
