using POO.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace POO.Service
{
    public class ContaCorrenteService
    {
        public void OperacaoSaque()
        {
            Console.WriteLine("Insira um valor para saque.");
            var valorSaque = Convert.ToDouble(Console.ReadLine());
            var contaCorrente = new ContaCorrente()
            {
                Agencia = 6140,
                Numero = 0017896,
                Saldo = 87.91,
                Titular = "Regina Falange"
            };

            Sacar(valorSaque, contaCorrente);
        }
        public void OperacaoDeposito()
        {
            Console.WriteLine("Insira um valor para depositar.");
            var valorDeposito = Convert.ToDouble(Console.ReadLine());

            var contaCorrente = new ContaCorrente()
            {
                Agencia = 6140,
                Numero = 0017896,
                Saldo = 87.91,
                Titular = "Regina Falange"
            };
            Depositar(valorDeposito, contaCorrente);
        }
        public void OperacaoTransferencia()
        {
            Console.WriteLine("Insira um valor para transferir.");
            var valorTransferencia = Convert.ToDouble(Console.ReadLine());
            var contaOrigem = new ContaCorrente()
            {
                Agencia = 6140,
                Numero = 0017896,
                Saldo = 870.91,
                Titular = "Regina Falange"
            };
            var contaDestino = new ContaCorrente()
            {
                Agencia = 3687,
                Numero = 0963675,
                Saldo = 2694.99,
                Titular = "Pietra Maria da Silva"
            };
            Transferir(valorTransferencia, contaOrigem, contaDestino);
        }
        private void Sacar(double valorSaque, ContaCorrente contaUsuario)
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
        private void Depositar(double valor, ContaCorrente contaUsuario)
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
        private void Transferir(double valor, ContaCorrente contaOrigem, ContaCorrente contaDestino)
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
