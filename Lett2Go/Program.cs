using System;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Xml;
using Lett2Go.Core;
using Lett2Go.EmailMngr.Interfaces;
using Lett2Go.PM.Context;
using log4net;
using Unity;

namespace Lett2Go
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                #region Setup

                ConfigureLogger();
                AppCore.Logger.Info("App started");
                IoC.Configure(AppCore.Container);
                AppCore.Logger.Info("Container configured");
                _enableDebugStops = args.ToList().Any(i => i.ToUpper() == Constants.ParameterEnableDebuggingStops);

                #endregion
                Console.WriteLine("Hello World!");

                var annualLetterContext = new AnnualLetterContext();
                var i = annualLetterContext.ClientAddresses.Count(ca => ca.AddressType == "L");
                Console.WriteLine($@"Connected to database and checked some records. We have {i} ClientAddresses with AddressType L");
            }
            catch (Exception ex)
            {
                AppCore.Logger.Error(ex);
                var email = AppCore.Container.Resolve<IEmailManager>();
                email.SendErrorMessage(ex.ToString());

                StopIfDebugEnabled();
            }
            finally
            {
                AppCore.Logger.Info("App finished");
            }
        }

        #region Privates

        private static readonly ILog Log = LogManager.GetLogger(typeof(Program));
        private static bool _enableDebugStops;

        internal static void ConfigureLogger()
        {
            AppCore.Logger = Log;
            var log4NetConfig = new XmlDocument();
            log4NetConfig.Load(File.OpenRead("log4net.config"));
            var repo = log4net.LogManager.CreateRepository(Assembly.GetEntryAssembly(),
                typeof(log4net.Repository.Hierarchy.Hierarchy));
            log4net.Config.XmlConfigurator.Configure(repo, log4NetConfig["log4net"]);
        }

        private static void StopIfDebugEnabled()
        {
            if (_enableDebugStops)
            {
                // ReSharper disable once LocalizableElement
                Console.WriteLine("Got error. Press Enter key to continue");
                Console.ReadLine();
            }
        }

        #endregion

    }
}
