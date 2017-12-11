using CF.Data;
using CF.Repo;
using CF.Repo.Common;
using CF.Service.Common;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Microsoft.Practices.Unity;
namespace CF.Service
{
    public class DepartementService : EntityService<Departement>, IDepartementService
    {
        IUnitOfWork _unitOfWork;
        IDepartementRepository _departementRepository;

        public DepartementService(IUnitOfWork unitOfWork, IDepartementRepository departementRepository)
            : base(unitOfWork, departementRepository)
        {
            _unitOfWork = unitOfWork;
            _departementRepository = departementRepository;
        }

        public Departement GetById(int Id)
        {
            return _departementRepository.GetById(Id);
        }
    }
}
