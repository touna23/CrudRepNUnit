using CF.Repo;
using CF.Service;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Configuration;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudRepository
{
    public class ContainerExtension
    {
        public static IUnityContainer container;
        
        public static IUnityContainer ContainerInit()
        {
            container = new UnityContainer();
            UnityConfigurationSection section = (UnityConfigurationSection)ConfigurationManager.GetSection("unity");
            section.Containers.Default.Configure(container);

            container.RegisterType<IDepartementRepository, DepartementRepository>();
            container.RegisterType<IDepartementService, DepartementService>();
            container.RegisterType<IStudentRepository, StudentRepository>();
            container.RegisterType<IStudentService, StudentService>();

            return container;
        }
    }
}
