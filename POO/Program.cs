using POO.Model;
using POO.Service;
using System;


namespace POO
{
  public  class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite seu nome");
            var nome = Console.ReadLine();
            Console.WriteLine("Por favor informe o tipo da sua conta:\n Digite o numeral 1 para Conta Corrente (Pessoa Física) \n Digite o numeral 2 para Conta Investimento (Pessoa Jurídica)");
            var tipoConta = Convert.ToInt32(Console.ReadLine());

            if (tipoConta == 1)
            {
                Console.WriteLine("\n" + nome + ", agora você pode realizar algumas operações:\n Digite o numeral 1 para Saque \n Digite o numeral 2 para Depósito \n Digite o numeral 3 para Transferência");
                try
                {
                    int operacao = Convert.ToInt32(Console.ReadLine());

                    ContaCorrenteService contaCorrenteService = new ContaCorrenteService();
                    switch (operacao)
                    {
                        case 1:
                            contaCorrenteService.OperacaoSaque();
                            break;
                        case 2:
                            contaCorrenteService.OperacaoDeposito();
                            break;
                        case 3:
                            contaCorrenteService.OperacaoTransferencia();
                            break;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Operação falhou, " + nome + " por favor verifique se você digitou um número!");
                    throw;
                }
            }
            else if (tipoConta == 2)
            {
                Console.WriteLine("\n" + nome + ", agora você pode realizar algumas operações:\n Digite o numeral 1 para Saque \n Digite o numeral 2 para Depósito \n Digite o numeral 3 para Transferência");
                try
                {
                    int operacao = Convert.ToInt32(Console.ReadLine());

                    InvestimentoService InvestimentoService = new InvestimentoService();
                    switch (operacao)
                    {
                        case 1:
                            InvestimentoService.OperacaoSaque();
                            break;
                        case 2:
                            InvestimentoService.OperacaoDeposito();
                            break;
                        case 3:
                            InvestimentoService.OperacaoTransferencia();
                            break;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Operação falhou, " + nome + " por favor verifique se você digitou um número!");
                    throw;
                }
            }

            else
            {
                Console.WriteLine("Por favor digite um tipo de conta válida!");
                throw new Exception();
            }   
        }
    }
}
