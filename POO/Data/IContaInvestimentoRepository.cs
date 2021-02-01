using POO.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace POO.Data
{
   public interface IContaInvestimentoRepository : IBaseRepository<ContaInvestimento>
    {
        void RegistrarTituloRendaFixa(ContaInvestimento contaInvestimento);
        void ComprarAcao(int id);
        void VenderAcao(int id);
        List<ContaInvestimento> ObterTodosInvestimentosPorData(DateTime dataInicio, DateTime dataFim);
    }
}
