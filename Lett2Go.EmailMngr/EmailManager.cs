using System;
using System.IO;
using Lett2Go.Core;
using Lett2Go.EmailMngr.Interfaces;
using MailKit;
using MailKit.Net.Smtp;
using MailKit.Security;
using MimeKit;
using MimeKit.Text;

namespace Lett2Go.EmailMngr
{
    public class EmailManager : IEmailManager
    {
        public void SendMessage(string messageText)
        {
            SendMessage(AppCore.SettingsEmailSubject, messageText);
        }

        public void SendErrorMessage(string messageText)
        {
            SendMessage(AppCore.SettingsEmailErrorSubject, messageText);
        }

        #region Privates

        private void SendMessage(string subject, string messageText)
        {
            var d = DateTime.UtcNow.Date;
            var logFileName = Constants.EmailLogFileNameHeader + $"UTC {d.Year:D4}-{d.Month:D2}-{d.Day:D2}" +
                              Constants.EmailLogFileNameExtension;
            var logFileNameWithPath = Path.Combine(AppCore.SettingsEmailLogFolder, logFileName);
            using var client = new SmtpClient(new ProtocolLogger(logFileNameWithPath));
            client.Connect(AppCore.SettingsEmailSmtpHost, AppCore.SettingsEmailSmtpPort, SecureSocketOptions.None);
            client.Send(BuildEmailMessage(subject, messageText));
            client.Disconnect(true);
        }

        private static MimeMessage BuildEmailMessage(string subject, string messageText)
        {
            var message = new MimeMessage
            {
                From =
                {
                    MailboxAddress.Parse(AppCore.SettingsEmailFrom)
                },
                Subject = subject,
                Body = new TextPart(TextFormat.Plain)
                {
                    Text = messageText + Environment.NewLine +
                           $@"@{Environment.MachineName}"
                }
            };
            message.To.AddRange(ParseAddressList(AppCore.SettingsEmailTo));
            return message;
        }

        private static InternetAddressList ParseAddressList(string addressList)
        {
            var list = new InternetAddressList();
            var addresses = addressList.Split(';');

            foreach (var person in addresses)
            {
                if (person.Length > 0)
                {
                    list.Add(new MailboxAddress("To", person));
                }
            }
            return list;
        }
        #endregion
    }
}
