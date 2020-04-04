using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Runtime.Settings;

namespace Iprosoft.ELMA.MailReaders
{
    [Component]
    public class MailReadersSettingsModule : GlobalSettingsModuleBase<MailReadersSettings>
    {
        public override Guid ModuleGuid => new Guid("ACDEF5DC-3172-4EE5-A351-FD0F707842C3");

        public override string ModuleName => "Настройки модуля Iprosoft.ELMA.MailReaders";
    }
}
