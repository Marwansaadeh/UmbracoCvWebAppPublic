using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Umbraco.Web.WebApi;
using UmbracoCvWebApp.ViewModels;

namespace UmbracoCvWebApp
{
    public class ContacFormController: Umbraco.Web.Mvc.SurfaceController
    {
        public const string PARTIAL_VIEW_FOLDER = "~/Views/Partials/Contact/";
        public ActionResult RenderForm()
        {
            return PartialView(PARTIAL_VIEW_FOLDER + "_Contact.cshtml");
        }
        [HttpPost]
        public ActionResult SendMessage(ContactViewModel model)
        {
            if (ModelState.IsValid)
            {
                model.EmailAddress = "hello@gmail.com";
                ModelState.Clear();
                
                return PartialView(PARTIAL_VIEW_FOLDER + "_Confirmation.cshtml", true);
            }
            return PartialView(PARTIAL_VIEW_FOLDER + "_Confirmation.cshtml", false);
        }
        public ActionResult Sendmail(ContactViewModel model)
        {
            return PartialView(PARTIAL_VIEW_FOLDER + "_Confirmation.cshtml", false);

        }
    }
}