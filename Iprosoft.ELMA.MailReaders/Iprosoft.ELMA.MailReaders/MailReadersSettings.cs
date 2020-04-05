using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Runtime.Settings;
using EleWise.ELMA.Workflow.Managers;
using EleWise.ELMA.Workflow.Models;

namespace Iprosoft.ELMA.MailReaders
{
    public class MailReadersSettings : GlobalSettingsBase
    {
        [DisplayName("IMAP сервер")]
        public string IMAP { get; set; }

        [DisplayName("IMAP порт")]
        public int IMAPport { get; set; }

        [DisplayName("Логин")]
        public string Login { get; set; }

        [DisplayName("Пароль")]
        public string Password { get; set; }

        [DisplayName("Процесс обработки писем")]
        public IProcessHeader MailProcess
        {
            get =>
                MailProcessId.HasValue
                    ? ProcessHeaderManager.Instance.LoadOrNull(MailProcessId.Value)
                    : null;
            set => MailProcessId = value?.Id;
        }
        public long? MailProcessId { get; set; }

    }
}
