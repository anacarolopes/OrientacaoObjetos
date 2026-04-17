/*

Encapsulamento é o conceito de proteger os dados de uma classe, permitindo que eles sejam acessados e modificados
- public -> acessível de qualquer lugar.
- private -> acessível apenas dentro da própria classe.
- protected -> aceesível na própria classe e em classes filhas (quando houver herança).

*/

using OrientacaoObjetos;

Cliente clienteA = new Cliente();
clienteA.Nome = "Ana Carolina";
clienteA.CPF = "12345678912";

Cliente clienteB = new Cliente();
clienteB.Nome = "José da Silva";
clienteB.CPF = "87321654321";

ContaPoupança contaPoupança = new ContaPoupança();

contaPoupança.Titular = clienteA;
contaPoupança.NumeroConta = "12345-6";
contaPoupança.Agencia = "0001";
contaPoupança.TaxaRendimento = 0.01;

contaPoupança.Depositar(500);

contaPoupança.AplicarRendimento();

contaPoupança.MostrarDados();

ContaCorrente contaCorrente = new ContaCorrente
{
    Titular = clienteB,
    NumeroConta = "65432-1",
    Agencia = "0001",
    LimiteChequeEspecial = 500
};

contaCorrente.MostrarDados();
contaCorrente.UsarChequeEspecial(100);


