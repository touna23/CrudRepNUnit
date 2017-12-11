using System;
using CF.Data;
using CF.Repo.Common;

namespace CF.Repo
{
    public interface IStudentRepository : IRepository<Student>
    {
        Student GetById(int id);
        void GetInfoGrid();
    }
}
