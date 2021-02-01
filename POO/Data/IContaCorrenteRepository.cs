using System;
using System.Collections.Generic;
using System.Text;

namespace POO.Data
{
   public interface IContaCorrenteRepository 
    {
        void CadastrarPix(string chave);
        void TransferirPix(string chave);
        void DeletarPix(string chave);
    }
}
