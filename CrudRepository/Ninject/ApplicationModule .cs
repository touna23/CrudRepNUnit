using CF.Repo;
using CF.Repo.Common;
using CF.Service;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudRepository.Ninject
{
    public class ApplicationModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IUnitOfWork>().To<UnitOfWork>();
            //Bind(typeof(IRepository<>)).To(typeof(Repository<>));
            Bind<IStudentRepository>().To<StudentRepository>();
            Bind<IStudentService>().To<StudentService>();
        }
    }
}
