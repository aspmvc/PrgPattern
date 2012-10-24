namespace PrgPattern.Infrastructure
{
    using System.Web.Mvc;

    public static class RedirectWithModelStateResultExtensions
    {
        public static RedirectWithModelStateResult WithModelState(this RedirectToRouteResult result)
        {
            return new RedirectWithModelStateResult(result);
        }

        public static RedirectWithModelStateResult WithModelState(this RedirectResult result)
        {
            return new RedirectWithModelStateResult(result);
        }
    }
}