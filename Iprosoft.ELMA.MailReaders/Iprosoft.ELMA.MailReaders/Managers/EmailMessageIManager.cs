using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Managers;
using Iprosoft.ELMA.MailReaderConf.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iprosoft.ELMA.MailReaders.Managers
{
    [Component]
    public class EmailMessageIManager: EntityManager<IEMailMessageI, long>
    {
        public IEMailMessageI CreateInSqlrocedure(string Name, DateTime CreationDate, string Tema, string Soobschenie, DateTime DataPolucheniePisjma, string OtKogo)
        {
            var IdResult = SessionProvider.GetSession("")
                .GetNamedQuery("ExecCreateEmailMessageI")
                .SetParameter("Name", Name)
                .SetParameter("CreationDate", CreationDate)
                .SetParameter("Tema", Tema)
                .SetParameter("Soobschenie", Soobschenie)
                .SetParameter("DataPolucheniePisjma", DataPolucheniePisjma)
                .SetParameter("OtKogo", OtKogo)
                .SetTimeout(0).UniqueResult<long>();
            return Instance.Load(IdResult);
        }
    }
}
