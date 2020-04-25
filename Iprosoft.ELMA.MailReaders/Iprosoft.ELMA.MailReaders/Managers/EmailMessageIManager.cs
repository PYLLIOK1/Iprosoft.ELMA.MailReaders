using EleWise.ELMA.Actions;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
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
        /// <summary>
        /// Методы не работают
        /// </summary>
        /// <param name="obj">The object.</param>
        /// <returns></returns>
        public override ActionCheckResult CanDelete(IEMailMessageI obj)
        {
            return obj != null
                ? new ActionCheckResult(false, "Запись нельзя удалить!")
                { Result = false, ErrorMessage = "Запись нельзя удалить!" }
                : base.CanDelete(obj);
        }

        public override void Delete(IEMailMessageI obj)
        {

            if (obj != null) throw new Exception("Запись нельзя удалить!");
            base.Delete(obj);
        }

        public override void Save(IEMailMessageI obj)
        {
            var findedEMailMessage = LoadOrNull(GetUniqueGuid(obj));
            if (obj.IsNew())
            {
                if (findedEMailMessage != null)
                    throw new Exception("Такая запись уже есть!");
            }
            else
            {
                if (findedEMailMessage != null && obj.Id != findedEMailMessage.Id)
                    throw new Exception("Такая запись уже есть!");
            }
            obj.Uid = GetUniqueGuid(obj);

            base.Save(obj);
        }

        /// <summary>
        /// Методы не работают
        /// </summary>
        /// <param name="obj">The object.</param>
        /// <returns></returns>
        public override ActionCheckResult CanSave(IEMailMessageI obj)
        {
            var findedEMailMessage = LoadOrNull(GetUniqueGuid(obj));
            return findedEMailMessage != null
                ? new ActionCheckResult(false, "Такая запись уже есть!")
                { Result = false, ErrorMessage = "Такая запись уже есть!" }
                : base.CanSave(obj);
        }

        private Guid GetUniqueGuid(IEMailMessageI obj)
        {
            return $"{obj}".GetDeterministicGuid();
        }
    }
}
