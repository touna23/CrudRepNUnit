using CF.Data;
using CF.Repo.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CF.Repo
{
    public interface IDepartementRepository : IRepository<Departement>
    {
        Departement GetById(int id);
    }
}
