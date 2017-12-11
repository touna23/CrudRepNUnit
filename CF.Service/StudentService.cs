using CF.Data;
using CF.Repo;
using CF.Repo.Common;
using CF.Service.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CF.Service
{
    public class StudentService : EntityService<Student>, IStudentService
    {
        IUnitOfWork _unitOfWork;
        IStudentRepository _studentRepository;

        public StudentService(IUnitOfWork unitOfWork, IStudentRepository studentRepository)
            : base(unitOfWork, studentRepository)
        {
            _unitOfWork = unitOfWork;
            _studentRepository = studentRepository;
        }


        public Student GetById(long Id)
        {
            return _studentRepository.GetById(Id);
        }

        public void GetInfoGrid()
        {
            _studentRepository.GetInfoGrid();
        }
    }
}
