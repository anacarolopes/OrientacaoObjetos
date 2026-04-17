/*

Encapsulamento é o conceito de proteger os dados de uma classe, permitindo que eles sejam acessados e modificados
- public -> acessível de qualquer lugar.
- private -> acessível apenas dentro da própria classe.
- protected -> aceesível na própria classe e em classes filhas (quando houver herança).

*/

using OrientacaoObjetos;

Cliente clienteA = new Cliente()
{
    Nome = "João Silva",
    CPF = "123.456.789-00"
};

Cliente clienteB = new Cliente()
{
    Nome = "Ana Carolina",
    CPF = "777.888.556-11"
};

ContaCorrente contaCorrente = new ContaCorrente()
{
    Titular = clienteA,
    NumeroConta = "12345-6",
    Agencia = "0001",
    LimiteChequeEspecial = 500
};


ContaPoupança contaPoupança = new ContaPoupança()
{
    Titular = clienteB,
    NumeroConta = "65432-1",
    Agencia = "0001",
    TaxaRendimento = 0.01
};

contaCorrente.Depositar(500);
contaCorrente.Depositar(200, "Depósito para pagar contas");
