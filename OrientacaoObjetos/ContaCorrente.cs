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
    }
}