using System.Web.Mvc;

namespace myBoot2.Controllers
{
    public class AboutController : BaseController
    {
        //public ActionResult Index()
        public ActionResult Index(int bizId, int lg=0, int catId=0 , int subId=0)// 79357
        {
            //setViewBagVariables(bizId, lg);
            setViewBagMenuCatModel(bizId, lg);
            setViewBagMenuModel(bizId, lg);
            //setViewBagPageDataModel(id, lg);
            return View();
        }
	}
}