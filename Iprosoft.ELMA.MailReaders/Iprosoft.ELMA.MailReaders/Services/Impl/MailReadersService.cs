using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security;
using EleWise.ELMA.Workflow.Managers;
using Iprosoft.ELMA.MailReaderConf.Models;
using Iprosoft.ELMA.MailReaders.ExtensionPoints;
using MailKit;
using MailKit.Net.Imap;
using MailKit.Search;
using MailKit.Security;
using MimeKit;
using Newtonsoft.Json;

namespace Iprosoft.ELMA.MailReaders.Services.Impl
{
    [Service(InjectProperties = true, Scope = ServiceScope.Application, Type = ComponentType.All)]
    public class MailReadersService : IMailReadersService
    {
        public IComponentManager ComponentManager { get; set; }
        public ISecurityService SecurityService { get; set; }
        public MailReadersSettingsModule MailReadersSettingsModule { get; set; }

        public IEnumerable<IEMailMessageI> GetReadMailMessages(IMailRequestI mailRequest)
        {
            var mailMessages = new List<IEMailMessageI>();
            using (ImapClient client = new ImapClient())
            {
                client.Connect(MailReadersSettingsModule.Settings.IMAP, MailReadersSettingsModule.Settings.IMAPport, SecureSocketOptions.SslOnConnect);
                client.Authenticate(MailReadersSettingsModule.Settings.Login, MailReadersSettingsModule.Settings.Password);
                IMailFolder inbox = client.Inbox;
                inbox.Open(FolderAccess.ReadOnly);
                var uids = inbox.Search(SearchQuery.Seen);
                foreach (var item in uids)
                {
                    var message = inbox.GetMessage(item);
                    var mailMessage = EntityManager<IEMailMessageI>.Instance.Create();
                    mailMessage.Name = DateTime.Now.ToString();
                    mailMessage.CreationDate = DateTime.Now;
                    mailMessage.Tema = message.Subject;
                    mailMessage.Soobschenie = message.HtmlBody;
                    mailMessage.DataPolucheniePisjma = message.Date.UtcDateTime;
                    mailMessage.OtKogo = message.From.FirstOrDefault().Name;
                    mailMessage.Save();
                    mailMessages.Add(mailMessage);
                }
            }
            return mailMessages.AsEnumerable();
        }

        public IEnumerable<IEMailMessageI> GetUnreadMailMessages(IMailRequestI mailRequest)
        {
            var mailMessages = new List<IEMailMessageI>();
            using (ImapClient client = new ImapClient())
            {
                client.Connect(MailReadersSettingsModule.Settings.IMAP, MailReadersSettingsModule.Settings.IMAPport, SecureSocketOptions.SslOnConnect);
                client.Authenticate(MailReadersSettingsModule.Settings.Login, MailReadersSettingsModule.Settings.Password);
                IMailFolder inbox = client.Inbox;
                inbox.Open(FolderAccess.ReadOnly);
                var uids = inbox.Search(SearchQuery.NotSeen);
                foreach (var item in uids)
                {
                    var message = inbox.GetMessage(item);
                    var mailMessage = EntityManager<IEMailMessageI>.Instance.Create();
                    ExecuteEmailMessage(message, mailMessage);
                    mailMessages.Add(mailMessage);
                }
            }
            return mailMessages.AsEnumerable();
        }

        public void Method()
        {
            throw new NotImplementedException();
        }

        public void RunProcessesMailMassages(IMailRequestI mailRequest)
        {
            if (MailReadersSettingsModule.Settings.MailProcess != null)
                if (MailReadersSettingsModule.Settings.MailProcess.Published != null)
                {
                    WorkflowInstanceManager.Instance.StartProcess(
                    MailReadersSettingsModule.Settings.MailProcess.Published,
                    "Процесс обработки писем от " + DateTime.Today.ToString(),
                    new
                    {
                        Request = mailRequest
                    });
                }
        }

        public void RunProcessesMailMassagesApi()
        {
            List<long> list = new List<long>();
            WebRequest request = WebRequest.Create(MailReadersSettingsModule.Settings.AdressApi + MailReadersSettingsModule.Settings.IMAP + "/"
                + MailReadersSettingsModule.Settings.IMAPport + "/" + MailReadersSettingsModule.Settings.Login + "/" + MailReadersSettingsModule.Settings.Password);
            WebResponse response = request.GetResponse();
            using (Stream stream = response.GetResponseStream())
            {
                using (StreamReader reader = new StreamReader(stream))
                {
                    list.AddRange(Rootobject.FromJson(reader.ReadToEnd()));
                }
            }
            response.Close();
            if (MailReadersSettingsModule.Settings.MailProcessApi != null)
            {
                if (MailReadersSettingsModule.Settings.MailProcessApi.Published != null)
                {
                    foreach (var item in list)
                    {
                        var Message = EntityManager<IEMailMessageI>.Instance.Load(item);
                        WorkflowInstanceManager.Instance.StartProcess(
                        MailReadersSettingsModule.Settings.MailProcessApi.Published,
                        "Процесс обработки писем через api от " + DateTime.Today.ToString(),
                        new
                        {
                            Pisjmo = Message
                        });
                    }
                }
            }         
        }

        public void ExecuteEmailMessage(MimeMessage message, IEMailMessageI eMail)
        {
            //получаем реализации точки расширения
            var emailMessageHandlers = ComponentManager.GetExtensionPoints<IEmailMessageIHandler>()
                .Where(c => c.CanExecute(message));
            //вызываем обработчики
            emailMessageHandlers.ForEach(c => c.Execute(message,eMail ));
        }
    }
    public class Rootobject
    {
        public static long[] FromJson(string json) => JsonConvert.DeserializeObject<long[]>(json);
    }
}
