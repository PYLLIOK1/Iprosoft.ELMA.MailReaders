using Iprosoft.ELMA.MailReaderConf.Models;
using System.Collections.Generic;

namespace Iprosoft.ELMA.MailReaders.Services
{
    public interface IMailReadersService
    {
        /// <summary>
        /// Получить все не прочитанные письма
        /// </summary>
        /// <param name="mailRequest">The mail request.</param>
        /// <returns></returns>
        IEnumerable<IEMailMessageI> GetUnreadMailMessages(IMailRequestI mailRequest);

        /// <summary>
        /// Получить все прочитанные письма
        /// </summary>
        /// <param name="mailRequest">The mail request.</param>
        /// <returns></returns>
        IEnumerable<IEMailMessageI> GetReadMailMessages(IMailRequestI mailRequest);

        /// <summary>
        /// Interceptors the method.
        /// </summary>
        void Method();

        void RunProcessesMailMassages(IMailRequestI mailRequest);

        void RunProcessesMailMassagesApi();
    }
}
