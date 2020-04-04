using System.Web.Mvc;
using EleWise.ELMA.BPM.Mvc.Controllers;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Web.Mvc.Security;

namespace Iprosoft.ELMA.MailReaders.Web.Controllers
{
    [Permission(CommonPermissions.AdminPermissionId)]
    public class MailReadersSettingsController : BPMController
    {
        public MailReadersSettingsModule SettingsModule { get; set; }
        public MailReadersSettings Settings => SettingsModule.Settings;
        public new ActionResult View()
        {
            return PartialView(Settings);
        }
        public ActionResult Edit()
        {
            return PartialView(Settings);
        }

    }
}
