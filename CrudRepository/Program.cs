using CF.Repo;
using System;
using System.Windows.Forms;
using CF.Service;
using System.Configuration;
using Microsoft.Practices.Unity.Configuration;
using Microsoft.Practices.Unity;
using CF.Repo.Common;

namespace CrudRepository
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            IUnityContainer container;           
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            container = ContainerExtension.ContainerInit();
            //var formManage = container.Resolve<frmManageDepartment>();
            var form = container.Resolve<FrmMain>();
            Application.Run(form);
        }


    }
}
