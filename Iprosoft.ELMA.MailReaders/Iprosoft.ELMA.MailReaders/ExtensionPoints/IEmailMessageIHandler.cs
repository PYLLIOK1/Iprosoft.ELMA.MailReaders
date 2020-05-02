using EleWise.ELMA.ComponentModel;
using Iprosoft.ELMA.MailReaderConf.Models;
using MimeKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iprosoft.ELMA.MailReaders.ExtensionPoints
{
    [ExtensionPoint]
    public interface IEmailMessageIHandler
    {
        /// <summary>
        /// Метод для проверки возможноси выполнить
        /// </summary>
        /// <returns></returns>
        bool CanExecute(MimeMessage message);
        /// <summary>
        /// Обработка сообщения
        /// </summary>
        void Execute(MimeMessage message, IEMailMessageI eMail);
    }
}
