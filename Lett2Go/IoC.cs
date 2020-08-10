using Lett2Go.EmailMngr;
using Lett2Go.EmailMngr.Interfaces;
using Lett2Go.FileMngr;
using Lett2Go.FileMngr.Interfaces;
using Lett2Go.PDF;
using Lett2Go.PDF.Interfaces;
using Lett2Go.PM;
using Lett2Go.PM.Interfaces;
using Unity;

namespace Lett2Go
{
    class IoC
    {
        public static void Configure(IUnityContainer IoC)
        {
            //This will allow the IoC to display unsuccessful mappings
            IoC.AddExtension(new Diagnostic());

            //This will inject dependencies from the interface to the class
            IoC.RegisterType<IFileManager, FileManager>();
            IoC.RegisterSingleton<IPersistenceManager, PersistenceManager>();
            IoC.RegisterSingleton<IEmailManager, EmailManager>();
            IoC.RegisterSingleton<IPDFMngr, PDFMngr>();
        }
    }
}
