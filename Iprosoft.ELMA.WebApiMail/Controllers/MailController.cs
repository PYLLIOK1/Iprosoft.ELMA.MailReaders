using Iprosoft.ELMA.WebApiMail.Db;
using MailKit;
using MailKit.Net.Imap;
using MailKit.Search;
using MailKit.Security;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web.Http;

namespace Iprosoft.ELMA.WebApiMail.Controllers
{
    public class MailController : ApiController
    {
        // GET api/<controller>
        public IEnumerable<long> Get(string IMAP, int Port, string Login, string Password)
        {
            List<long> list = new List<long>();
            using (ImapClient client = new ImapClient())
            {
                var context = new ELMA3Entities();
                client.Connect(IMAP, Port, SecureSocketOptions.SslOnConnect);
                client.Authenticate(Login, Password);
                IMailFolder inbox = client.Inbox;
                inbox.Open(FolderAccess.ReadOnly);
                var uids = inbox.Search(SearchQuery.NotSeen);
                foreach (var item in uids)
                {
                    var message = inbox.GetMessage(item);
                    string a;
                    if(message.HtmlBody != null)
                    {
                        a = message.HtmlBody;
                    }
                    else
                    {
                        a = message.TextBody;
                    }
                    var b = context.CreateEmailMessageI(DateTime.Now.ToString(), DateTime.Now, message.Subject, a, message.Date.UtcDateTime, message.From.FirstOrDefault().Name);
                    list.Add(b.FirstOrDefault().Id);
                }
            }
            return list.AsEnumerable();
        }
    }
}