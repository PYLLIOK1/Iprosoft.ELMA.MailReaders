using Iprosoft.ELMA.MailReaderConf.Models;
using MimeKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iprosoft.ELMA.MailReaders.ExtensionPoints.Impl.EmailMessageIHandler
{
    public abstract class AbstractEmailMessageIHandler : IEmailMessageIHandler
    {
        public virtual bool CanExecute(MimeMessage message)
        {
            return true;
        }

        public virtual void Execute(MimeMessage message, IEMailMessageI eMail)
        {
            throw new NotImplementedException();
        }
    }
}
