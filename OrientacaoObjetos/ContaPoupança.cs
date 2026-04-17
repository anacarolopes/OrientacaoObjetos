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
    }
}
