using System.Web;
using System.Web.Mvc;

namespace Net.Petricevic.Learnings.CSharp.MVCAppDB
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
