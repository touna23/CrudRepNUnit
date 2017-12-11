using CF.Data;
using CF.Repo;
using CF.Repo.Common;
using CF.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudRepository.Controller
{
    public class DepartementController
    {
        private IDepartementService _deptService;
        
        public List<Student> DataSource { get; set; }
        public List<string> ColumnNames { get; set; }

        
        public DepartementController(IDepartementService deptService)
        {

            this._deptService = deptService;
        }
        public string ValidationMessage { get; set; }

        public bool AddDepartement(Departement NewDept)
        {
            try
            {
                _deptService.Create(NewDept);
                return true;
            }
            catch (Exception ex)
            {
                ValidationMessage = ex.ToString();
                return false;
            }
        }

        public bool UpdateDepartement(Departement DeptEdit)
        {
            try
            {
                _deptService.Update(DeptEdit);
                return true;
            }
            catch (Exception ex)
            {
                ValidationMessage = ex.ToString();
                return false;
            }
        }

        public List<Departement> GetAll()
        {
            return _deptService.GetAll().ToList();
        }

        public Departement GetByIdDepartement(int id)
        {
            return _deptService.GetById(id);
        }
    }
}
