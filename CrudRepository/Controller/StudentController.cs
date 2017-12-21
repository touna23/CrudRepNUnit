using CF.Data;
using CF.Repo;
using CF.Repo.Common;
using CF.Service;
using NLog;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.EntityClient;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudRepository.Controller
{
    public class StudentController
    {
        
        private IStudentService _studentService;

        
        public List<Student> DataSource { get; set; }
        public List<string> ColumnNames { get; set; }

        
        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
            GetColumNames();
        }

        public string ValidationMessage { get; set; }

       
        public List<Student> GetAllStudent()
        {
            return DataSource = _studentService.GetAll().ToList();
        }

        public List<Student> GetAll()
        {
            return _studentService.GetAll().ToList();
        }

        public void GetInfoGrid()
        {
            _studentService.GetInfoGrid();
        }

        public bool AddStudent(Student NewStudent)
        {
            try
            {
                _studentService.Create(NewStudent);
                return true;
            }
            catch (Exception ex)
            {                
                ValidationMessage = ex.ToString();
                return false;
            }            
        }

        public bool UpdateStudent(Student StudentEdit)
        {
            try
            {
                _studentService.Update(StudentEdit);
                return true;
            }
            catch (Exception ex)
            {
                ValidationMessage = ex.ToString();
                return false;
            }
        }

        public void deleteStudent(Student Student)
        {
            try
            {
                Student studenDelete = _studentService.GetById(Student.Id);
                _studentService.Delete(studenDelete);
            }
            catch (Exception ex)
            {
                ValidationMessage = ex.ToString();
            }
        }

        public Student GetByIdStudent(int id)
        {
            return _studentService.GetById(id);
        }

        private void GetColumNames()
        {
            ColumnNames = new List<string>();
            using (SampleDbEntities context = new SampleDbEntities())
            {
                var objectContext = ((IObjectContextAdapter)context).ObjectContext;
                var storageMetadata = ((EntityConnection)objectContext.Connection).GetMetadataWorkspace().GetItems(DataSpace.SSpace);
                var entityProps = (from sm in storageMetadata where sm.BuiltInTypeKind == BuiltInTypeKind.EntityType select sm as EntityType);
                // For your project, open the model browser to get the name for the model, will have namespace.Store

                var metaData = typeof(Student).GetProperties()
                        .Select(property => property.Name)
                        .ToArray();

                //var metaData = (from m in entityProps where m.FullName == "NORTHWNDModel.Store.Customers" select m.DeclaredProperties).ToList();
                foreach (var topItem in metaData)
                {
                    foreach (var item in topItem)
                    {
                        ColumnNames.Add(item.ToString());
                    }
                }
            }
        }

    }
}
