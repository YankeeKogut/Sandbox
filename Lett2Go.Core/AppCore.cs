using System;
using log4net;
using System.Configuration;
using System.IO;
using Unity;

namespace Lett2Go.Core
{
    public static class AppCore
    {
        public static readonly UnityContainer Container = new UnityContainer();

        public static ILog Logger { get; set; }

        public static string SettingsOutputFileLocation
        {
            get => ConfigurationManager.AppSettings[Constants.SettingsOutputFileLocation];
            set => AddUpdateAppSettings(Constants.SettingsOutputFileLocation, value);
        }

        public static string SettingsIronPDFLicenseKey
        {
            get => ConfigurationManager.AppSettings[Constants.SettingsIronPDFLicenseKey];
            set => AddUpdateAppSettings(Constants.SettingsIronPDFLicenseKey, value);
        }

        public static string SettingsEmailTo
        {
            get => ConfigurationManager.AppSettings[Constants.SettingsEmailTo];
            set => AddUpdateAppSettings(Constants.SettingsEmailTo, value);
        }

        public static string SettingsEmailFrom
        {
            get => ConfigurationManager.AppSettings[Constants.SettingsEmailFrom];
            set => AddUpdateAppSettings(Constants.SettingsEmailFrom, value);
        }

        public static string SettingsEmailSubject
        {
            get => ConfigurationManager.AppSettings[Constants.SettingsEmailSubject];
            set => AddUpdateAppSettings(Constants.SettingsEmailSubject, value);
        }

        public static string SettingsEmailErrorSubject
        {
            get => ConfigurationManager.AppSettings[Constants.SettingsEmailErrorSubject];
            set => AddUpdateAppSettings(Constants.SettingsEmailErrorSubject, value);
        }


        public static string SettingsEmailSmtpHost
        {
            get => ConfigurationManager.AppSettings[Constants.SettingsEmailSmtpHost];
            set => AddUpdateAppSettings(Constants.SettingsEmailSmtpHost, value);
        }

        public static int SettingsEmailSmtpPort
        {
            get => int.Parse(ConfigurationManager.AppSettings[Constants.SettingsEmailSmtpPort]);
            set => AddUpdateAppSettings(Constants.SettingsEmailSmtpPort, value.ToString());
        }

        public static string SettingsEmailUsername
        {
            get => ConfigurationManager.AppSettings[Constants.SettingsEmailUsername];
            set => AddUpdateAppSettings(Constants.SettingsEmailUsername, value);
        }



        public static string SettingsEmailPassword
        {
            get => ConfigurationManager.AppSettings[Constants.SettingsEmailPassword];
            set => AddUpdateAppSettings(Constants.SettingsEmailPassword, value);
        }

        public static string SettingsFiserveCambridgeId
        {
            get => ConfigurationManager.AppSettings[Constants.SettingsFiserveCambridgeId];
            set => AddUpdateAppSettings(Constants.SettingsFiserveCambridgeId, value);
        }

        public static string SettingsEmailLogFolder
        {
            get
            {
                var value = ConfigurationManager.AppSettings[Constants.SettingsEmailOutputFileLocation];

                if (!Directory.Exists(value))
                {
                    try
                    {
                        Directory.CreateDirectory(value);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Cannot create folder for email logs");
                        Console.WriteLine(e);
                        throw;
                    }
                }

                return value;
            }
            set => AddUpdateAppSettings(Constants.SettingsEmailOutputFileLocation, value);
        }

        public static int DaysInThePastToCheck
        {
            get;
            set;
        }

        private static void AddUpdateAppSettings(string key, string value)
        {
            try
            {
                var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                var settings = configFile.AppSettings.Settings;
                if (settings[key] == null)
                {
                    settings.Add(key, value);
                }
                else
                {
                    settings[key].Value = value;
                }

                configFile.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection(configFile.AppSettings.SectionInformation.Name);
            }
            catch (ConfigurationErrorsException)
            {
                Console.WriteLine("Error writing app settings");
            }
        }
    }
}
