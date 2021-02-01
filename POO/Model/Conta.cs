using System;
using System.Collections.Generic;
using System.Text;

namespace POO.Model
{
   public class Conta
    {
        public int Id { get; set; }
        public int Agencia { get; set; }
        public int NumeroConta { get; set; }
        public string Banco { get; set; }
        public double Saldo { get; set; }
    }
}
