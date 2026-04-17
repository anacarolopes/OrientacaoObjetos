namespace OrientacaoObjetos
{
    public class ContaPoupança : ContaBancaria
    {
        public double TaxaRendimento { get; set; }

        public void AplicarRendimento()
        {
            double rendimento = Saldo * TaxaRendimento;
            Saldo += rendimento;
            Console.WriteLine($"Rendimento calculado: R${rendimento} aplicado. Saldo atual: R${Saldo}");
        }

        public override void MostrarDados() // override -> sobrescreve o método da classe pai (ContaBancaria) polimorfismo
        {
            Console.WriteLine("------------Dados da Conta Poupança------------");
            base.MostrarDados(); // chama o método da classe pai (ContaBancaria)
            Console.WriteLine($"Taxa de Rendimento: {TaxaRendimento * 100}%");
            Console.WriteLine("----------------------------------");
        }
    }
}
