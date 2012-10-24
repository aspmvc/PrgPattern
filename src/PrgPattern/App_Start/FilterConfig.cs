namespace PrgPattern
{
    using System.Web.Mvc;
    using Infrastructure;

    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(new ImportModelStateAttribute());
        }
    }
}