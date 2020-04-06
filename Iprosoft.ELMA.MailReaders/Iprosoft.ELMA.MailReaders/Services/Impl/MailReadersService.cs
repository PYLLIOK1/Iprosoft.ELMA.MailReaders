using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Security;
using EleWise.ELMA.Workflow.Managers;
using Iprosoft.ELMA.MailReaderConf.Models;
using MailKit;
using MailKit.Net.Imap;
using MailKit.Search;
using MailKit.Security;

namespace Iprosoft.ELMA.MailReaders.Services.Impl
{
    [Service(InjectProperties = true, Scope = ServiceScope.Application, Type = ComponentType.All)]
    public class MailReadersService : IMailReadersService
    {
        public IComponentManager ComponentManager { get; set; }
        public ISecurityService SecurityService { get; set; }
        public MailReadersSettingsModule MailReaderSettingsModule { get; set; }

        public IEnumerable<IEMailMessageI> GetReadMailMessages(IMailRequestI mailRequest)
        {
            var mailMessages = new List<IEMailMessageI>();
            using (ImapClient client = new ImapClient())
            {
                client.Connect(MailReaderSettingsModule.Settings.IMAP, MailReaderSettingsModule.Settings.IMAPport, SecureSocketOptions.SslOnConnect);
                client.Authenticate(MailReaderSettingsModule.Settings.Login, MailReaderSettingsModule.Settings.Password);
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
                client.Connect(MailReaderSettingsModule.Settings.IMAP, MailReaderSettingsModule.Settings.IMAPport, SecureSocketOptions.SslOnConnect);
                client.Authenticate(MailReaderSettingsModule.Settings.Login, MailReaderSettingsModule.Settings.Password);
                IMailFolder inbox = client.Inbox;
                inbox.Open(FolderAccess.ReadOnly);
                var uids = inbox.Search(SearchQuery.NotSeen);
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

        public void Method()
        {
            throw new NotImplementedException();
        }

        public void RunProcessesMailMassages(IMailRequestI mailRequest)
        {
            if (MailReaderSettingsModule.Settings.MailProcess != null)
                if (MailReaderSettingsModule.Settings.MailProcess.Published != null)
                {
                    WorkflowInstanceManager.Instance.StartProcess(
                    MailReaderSettingsModule.Settings.MailProcess.Published,
                    "Процесс обработки писем от " + DateTime.Today.ToString(),
                    new
                    {
                        Request = mailRequest
                    });
                }


        }
    }
}
