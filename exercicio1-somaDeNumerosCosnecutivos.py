# Script em pyton correspondente ao exercício 1
def calcular_soma(numero):
    soma = 0
    k = 0
    
    while k < numero:
        k += 1
        soma += k
    
    return soma
    
numero = int(input("Digite um número inteiro: "))
resultado = calcular_soma(numero)

print(f"O valor da soma dos números de 1 a {numero} é: {resultado}")
