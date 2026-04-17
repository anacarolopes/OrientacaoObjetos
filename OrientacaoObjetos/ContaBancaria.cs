/*

Getters e Setters são formas de acessar e modificar os valores de atributos de uma classe de maneira controlada.
- O getter (get) é reponsável por retornar o valor de um atributo.
- O setter (set) é usado para definir um novo valor para esse atribiuto.
Eles ajudam a proteger os dados e permitem aplicar regras, como não aceitar valores negativos, por exemplo.

*/

using System.Dynamic;

namespace OrientacaoObjetos
{
    public class ContaBancaria
    {
        public Cliente Titular;
        public string NumeroConta;
        public string Agencia;
        public double Saldo {get; protected set;}

        public void Depositar(double valor)
        {
            Saldo += valor;
            Console.WriteLine($"Depósito de R${valor} realizado. Saldo atual: R${Saldo}");
        }

        public void Sacar(double valor)
        {
            if(valor <= Saldo)
            {
                Saldo -= valor;
                Console.WriteLine($"Saque de R${valor} realizado. Saldo atual: R${Saldo}");
            }
            else
            {
                Console.WriteLine($"Saque no valor de R${valor} não realizado. Saldo insuficiente");
            }
        }

        public void MostrarDados()
        {
            Console.WriteLine("----------------------------------");
            Console.WriteLine($"Titular: {Titular.Nome} - CPF: {Titular.CPF}");
            Console.WriteLine($"Conta: {NumeroConta} - Agência: {Agencia}");
            Console.WriteLine($"Saldo: {Saldo}");
            Console.WriteLine("----------------------------------");
        }
    }
}