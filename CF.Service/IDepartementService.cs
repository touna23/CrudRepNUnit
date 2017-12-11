using CF.Data;
using CF.Service.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CF.Service
{
    public interface IDepartementService : IEntityService<Departement>
    {
        Departement GetById(int Id);
    }
}
