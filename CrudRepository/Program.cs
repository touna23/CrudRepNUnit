using CF.Repo;
using System;
using System.Windows.Forms;
using CF.Service;
using System.Configuration;
using Microsoft.Practices.Unity.Configuration;
using Microsoft.Practices.Unity;
using CF.Repo.Common;
using NLog;
using CrudRepository.Utils.FException;

namespace CrudRepository
{
    static class Program
    {
        //private static Logger logger = LogManager.GetCurrentClassLogger();

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {        
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //logger.Info("This is the first line of Main method.");

            try
            {
                throw new Exception("This is one badass exception. :)");
            }
            catch (Exception ex)
            {
                //logger.Error(ex, "It seems the exception happened. :(");
                Msg.TraceError("hello", ex);
            }

            //logger.Warn("This is your last warning!");
            //logger.Fatal("And this is fatal error...");

            
            //Instanciation du conteneur
            var form = ContainerExtension.ContainerInit();
            Application.Run(new FrmMain());
        }


    }
}
