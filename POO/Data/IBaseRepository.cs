using System;
using System.Collections.Generic;
using System.Text;

namespace POO.Data
{
    public interface IBaseRepository<Tentity>
    {
        void Save(Tentity tentity);
        void Update(int id);
        void Delete(int id);
        List<Tentity> ObterTodos();
    }
}
