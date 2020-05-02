using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Managers;
using Iprosoft.ELMA.MailReaderConf.Models;
using MimeKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iprosoft.ELMA.MailReaders.ExtensionPoints.Impl.EmailMessageIHandler
{
    [Component]
    public class BodyEmailMessageIHandler : AbstractEmailMessageIHandler
    {
        public override bool CanExecute(MimeMessage message)
        {
            if (message.TextBody != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public override void Execute(MimeMessage message, IEMailMessageI eMail)
        {
            eMail.Name = DateTime.Now.ToString();
            eMail.CreationDate = DateTime.Now;
            eMail.Tema = message.Subject;
            eMail.Soobschenie = message.TextBody;
            eMail.DataPolucheniePisjma = message.Date.UtcDateTime;
            eMail.OtKogo = message.From.FirstOrDefault().Name;
            eMail.Save();
        }
    }
}
