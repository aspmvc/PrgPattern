namespace PrgPattern.Infrastructure
{
    using System.Web.Mvc;

    public class ImportModelStateAttribute : IActionFilter
    {
        public const string ModelStateTranferKey = "ModelStateKey";

        public void OnActionExecuted(ActionExecutedContext filterContext)
        {
            var modelState = filterContext.Controller.TempData[ModelStateTranferKey] as ModelStateDictionary;

            if (modelState == null)
            {
                return;
            }

            if (filterContext.Result is ViewResult)
            {
                filterContext.Controller.ViewData.ModelState.Merge(modelState);
            }
            else
            {
                filterContext.Controller.TempData.Remove(ModelStateTranferKey);
            }
        }

        public void OnActionExecuting(ActionExecutingContext filterContext)
        {
        }
    }
}