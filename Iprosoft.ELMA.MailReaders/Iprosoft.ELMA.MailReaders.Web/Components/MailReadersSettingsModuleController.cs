using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Web.Mvc.Models.Settings;
using Microsoft.Web.Mvc.Html;

namespace Iprosoft.ELMA.MailReaders.Web.Components
{
    [Component]
    public class MailReadersSettingsController : GlobalSettingsModuleControllerBase<MailReadersSettings, MailReadersSettingsModule>
    {
        public MailReadersSettingsController(MailReadersSettingsModule module) : base(module)
        {
        }

        public override MvcHtmlString RenderDisplay(HtmlHelper html)
        {
            return html.Partial("MailReadersSettings/View", Module.Settings);
        }

        public override MvcHtmlString RenderEdit(HtmlHelper html)
        {
            return html.Partial("MailReadersSettings/Edit", Module.Settings);
        }
    }
}