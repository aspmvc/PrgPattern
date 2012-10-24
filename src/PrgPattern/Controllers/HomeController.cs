namespace PrgPattern.Controllers
{
    using System.Web.Mvc;
    using Infrastructure;
    using ViewModels;

    public class HomeController : Controller
    {
        public const string MessageKey = "Message";

        [HttpGet]
        public ActionResult Edit()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Edit(EditViewModel model)
        {
            if (ModelState.IsValid)
            {
                TempData[MessageKey] = "Object has been saved. You can refresh this page without resend form data.";
                RedirectToAction("Edit");
            }
            
            return RedirectToAction("Edit").WithModelState();
        }
    }
}
