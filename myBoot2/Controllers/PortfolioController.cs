﻿using System.Web.Mvc;
using myBoot2.ServiceReference1;
using System.Collections.Generic;
using System.Linq;
using System;

namespace myBoot2.Controllers
{
    public class PortfolioController : BaseController
    {
        ServiceReference1.Service1Client objService = new Service1Client();

        public ActionResult Index(int bizId= 72751 /*79357*/, int lg=0, int catId = 1306/*1595*/, int subId=0, int id=0)
        {
            setViewBagVariables("Portfolio", bizId, lg, catId, subId, id);
            setViewBagMenuModel(bizId, lg);
            setViewBagMenuCatModel(bizId, lg);
            setViewBagCatPdtModel(bizId, lg, catId, subId);
                        
            return View();
        }
    }
}
