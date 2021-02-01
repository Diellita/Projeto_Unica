using System;
using System.Collections.Generic;
using System.Text;
using POO.Model;

namespace POO.Service
{
    public class InvestimentoService
    {
        public void OperacaoSaque()
        {
            Console.WriteLine("Insira um valor para saque.");
            var valorSaque = Convert.ToDouble(Console.ReadLine());
            var ContaInvestimento = new ContaInvestimento()
            {
                Agencia = 4875,
                Banco = "Money",
                Id = 12345,
                IdCarteira = 54321,
                NumeroConta = 896574,
                PerfilInvestidor = PerfilInvestidor.Conservador,
                Saldo = 6799134.78,
                TipoInvestimento = TipoInvestimento.RendaVariavel
            };

            Sacar(valorSaque, ContaInvestimento);
        }
        public void OperacaoDeposito()
        {
            Console.WriteLine("Insira um valor para depositar.");
            var valorDeposito = Convert.ToDouble(Console.ReadLine());

            var ContaInvestimento = new ContaInvestimento()
            {
                Agencia = 4875,
                Banco = "Poor",
                Id = 3456,
                IdCarteira = 33321,
                NumeroConta = 496574,
                PerfilInvestidor = PerfilInvestidor.Moderado,
                Saldo = 1000.14,
                TipoInvestimento = TipoInvestimento.Previdencia
            };
            Depositar(valorDeposito, ContaInvestimento);
        }
        public void OperacaoTransferencia()
        {
            Console.WriteLine("Insira um valor para transferir.");
            var valorTransferencia = Convert.ToDouble(Console.ReadLine());
            var contaOrigem = new ContaInvestimento()
            {
                Agencia = 4875,
                Banco = "Money",
                Id = 12345,
                IdCarteira = 54321,
                NumeroConta = 896574,
                PerfilInvestidor = PerfilInvestidor.Conservador,
                Saldo = 6799134.78,
                TipoInvestimento = TipoInvestimento.RendaVariavel
            };
            var contaDestino = new ContaInvestimento()
            {
                Agencia = 7875,
                Banco = "Card",
                Id = 12345,
                IdCarteira = 14321,
                NumeroConta = 965754,
                PerfilInvestidor = PerfilInvestidor.Agressivo,
                Saldo = 90799591.87,
                TipoInvestimento = TipoInvestimento.RendaFixa
            };
            Transferir(valorTransferencia, contaOrigem, contaDestino);
        }
        private void Sacar(double valorSaque, ContaInvestimento contaUsuario)
        {
            if (valorSaque <= contaUsuario.Saldo)
            {
                contaUsuario.Saldo = contaUsuario.Saldo - valorSaque;
                Console.WriteLine($"Saque realizado com sucesso. Seu saldo atual é de {contaUsuario.Saldo}");
            }
            else
            {
                Console.WriteLine($"Não foi possível concluir a transação. Seu saldo {contaUsuario.Saldo} é inferior ao valor do saque {valorSaque}");
            }
        }
        private void Depositar(double valor, ContaInvestimento contaUsuario)
        {
            if (valor > 0)
            {
                contaUsuario.Saldo = contaUsuario.Saldo + valor;
                Console.WriteLine($"Depósito realizado com sucesso. Seu saldo atual é de {contaUsuario.Saldo}");
            }
            else
            {
                Console.WriteLine("Não foi possível concluir a transação. O valor do depósito não pode ser menor que 0");
            }
        }
        private void Transferir(double valor, ContaInvestimento contaOrigem, ContaInvestimento contaDestino)
        {
            if (valor > 0 && contaOrigem.Saldo >= valor)
            {
                contaOrigem.Saldo = contaOrigem.Saldo - valor;
                contaDestino.Saldo = contaDestino.Saldo + valor;
                Console.WriteLine($"Transferência concluida com sucesso, seu saldo atual é de {contaOrigem.Saldo}");
            }
            else
            {
                Console.WriteLine("Não foi possível concluir a transferência");
            }
        }
    }
}
