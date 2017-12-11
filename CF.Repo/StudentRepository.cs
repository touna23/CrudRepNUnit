using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CF.Data;
using CF.Repo.Common;

namespace CF.Repo
{
    public class StudentRepository : Repository<Student>, IStudentRepository
    {
        public StudentRepository(SampleDbEntities context)
              : base(context)
        {

        }
        public Student GetById(int id)
        {
            return FindBy(x => x.Id == id).FirstOrDefault();
        }

        public void GetInfoGrid()
        {
            using (var context = new SampleDbEntities())
            {
                var students = (from stud in context.Students
                                select new
                                {
                                    stud.Id,
                                    stud.FirstName,
                                    stud.LastName,
                                    stud.Email,
                                    stud.EnrollmentNumber,
                                    Department = stud.Departement.Title
                                }).ToList();               
            }
        }
    }
}
