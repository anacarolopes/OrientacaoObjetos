using System;
namespace OrientacaoObjetos
{
    public class ContaCorrente : ContaBancaria
    {
        public double LimiteChequeEspecial { get; set; }

        public void UsarChequeEspecial(double valor)
        {
           var podeSacar = Saldo + LimiteChequeEspecial >= valor;
           
                if(podeSacar)
                {
                    Console.WriteLine("---------------------------------------");
                    Console.WriteLine("É possivel sacar o valor solicitado:");
                    Console.WriteLine($"Valor solicitado: R${valor}");
                    Console.WriteLine($"Saldo + cheque especial: R${Saldo + LimiteChequeEspecial}");
                    Console.WriteLine("---------------------------------------");
                }
                else
                {
                    Console.WriteLine("---------------------------------------");
                    Console.WriteLine("Não é possivel sacar o valor solicitado:");
                    Console.WriteLine($"Valor solicitado: R${valor}");
                    Console.WriteLine($"Saldo + cheque especial: R${Saldo + LimiteChequeEspecial}");
                    Console.WriteLine("---------------------------------------");
                }
        }

        public override void MostrarDados() //override -> sobrescreve o método da classe pai (ContaBancaria)
        {
            Console.WriteLine("------------Dados da Conta Corrente------------");
            base.MostrarDados(); // chama o método da classe pai (ContaBancaria)
            Console.WriteLine($"Limite do Cheque Especial: R${LimiteChequeEspecial}");
            Console.WriteLine("----------------------------------");
        }

    }
}