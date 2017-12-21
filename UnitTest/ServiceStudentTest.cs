using CF.Data;
using CF.Repo;
using CF.Repo.Common;
using CF.Service;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest
{
    [TestFixture]
    public class ServiceStudentTest
    {
        // test
        SampleDbEntities context;
        IUnitOfWork unitOfWork;
        IStudentRepository studentRepository;
        IStudentService studentService;
        Student stud;
        //hook
        [Test]
        public void TestMethodGetAllStudent()
        {
            context = new SampleDbEntities();
            unitOfWork = new UnitOfWork();
            studentRepository = new StudentRepository(context);
            studentService = new StudentService(unitOfWork, studentRepository);
            stud = new Student();
            
            int nb = studentService.GetAll().ToList().Count();
            //stud = studentService.GetById(i);
            Assert.AreEqual(3, nb);
        }

        [Test]
        public void TestInsertStudent()
        {
            context = new SampleDbEntities();
            unitOfWork = new UnitOfWork();
            studentRepository = new StudentRepository(context);
            studentService = new StudentService(unitOfWork,studentRepository);
            stud = new Student()
            {
                FirstName = "test name",
                LastName = "last name",
                Email = "testemail@email.com",
                EnrollmentNumber = "123456",
                AddedDate = DateTime.ParseExact("2017-12-07 14:40:52,531", "yyyy-MM-dd HH:mm:ss,fff",
                                       System.Globalization.CultureInfo.InvariantCulture),
                ModifiedDate = DateTime.ParseExact("2017-12-07 14:40:52,531", "yyyy-MM-dd HH:mm:ss,fff",
                                       System.Globalization.CultureInfo.InvariantCulture)
            };
            using (var dbContextTransaction = context.Database.BeginTransaction())
            {
                studentService.Create(stud);
                dbContextTransaction.Rollback(); 
            }
        }

        [Test]
        public void TestUpdateStudent()
        {
            string updatedName = "name updated";
            context = new SampleDbEntities();
            unitOfWork = new UnitOfWork();
            studentRepository = new StudentRepository(context);
            studentService = new StudentService(unitOfWork, studentRepository);
            stud = studentService.GetById(16);
            stud.FirstName = updatedName;

            using (var dbContextTransaction = context.Database.BeginTransaction())
            {
                studentService.Update(stud);
                dbContextTransaction.Rollback();
            }
        }


        [Test]
        public void TestDeleteStudent()
        {
            context = new SampleDbEntities();
            unitOfWork = new UnitOfWork();
            studentRepository = new StudentRepository(context);
            studentService = new StudentService(unitOfWork, studentRepository);
            stud = studentService.GetById(16);

            using (var dbContextTransaction = context.Database.BeginTransaction())
            {
                studentService.Delete(stud);
                dbContextTransaction.Rollback();
            }
        }
    }
}