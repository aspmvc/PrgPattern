namespace PrgPattern.Infrastructure
{
    using System.Web.Mvc;

    public class RedirectWithModelStateResult : ActionResult
    {
        public RedirectWithModelStateResult(ActionResult redirectBaseResult)
        {
            BaseResult = redirectBaseResult;
        }

        public ActionResult BaseResult { get; private set; }

        public override void ExecuteResult(ControllerContext context)
        {
            if (!context.Controller.ViewData.ModelState.IsValid)
            {
                if ((BaseResult is RedirectResult) || (BaseResult is RedirectToRouteResult))
                {
                    context.Controller.TempData[ImportModelStateAttribute.ModelStateTranferKey]
                                                                                = context.Controller.ViewData.ModelState;
                }
            }

            BaseResult.ExecuteResult(context);
        }
    }

}