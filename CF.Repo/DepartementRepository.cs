using CF.Data;
using CF.Repo.Common;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CF.Repo
{
    public class DepartementRepository : Repository<Departement>, IDepartementRepository
    {
        public DepartementRepository(SampleDbEntities context)
            : base(context)
        {

        }
        public Departement GetById(int id)
        {
            return FindBy(x => x.Id == id).FirstOrDefault();
        }
       
    }
}
