using System.Web.Mvc;
using Sitecore.Mvc.Controllers;

namespace Elision.Feature.Template.Accordion.Areas.ElisionFeature.Controllers
{
    public class AccordionController : SitecoreController
    {       
        public ActionResult Accordion()
        {
            return View();
        }

        public ActionResult Section()
        {
            return View();
        }
    }
}