using POO.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace POO.Data
{
    public class ContaInvestimentoRepository : IContaInvestimentoRepository
    {
        public void ComprarAcao(int id)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<ContaInvestimento> ObterTodos()
        {
            throw new NotImplementedException();
        }

        public List<ContaInvestimento> ObterTodosInvestimentosPorData(DateTime dataInicio, DateTime dataFim)
        {
            throw new NotImplementedException();
        }

        public void RegistrarTituloRendaFixa(ContaInvestimento contaInvestimento)
        {
            throw new NotImplementedException();
        }

        public void Save(ContaInvestimento tentity)
        {
            throw new NotImplementedException();
        }

        public void Update(int id)
        {
            throw new NotImplementedException();
        }

        public void VenderAcao(int id)
        {
            throw new NotImplementedException();
        }
    }
}
