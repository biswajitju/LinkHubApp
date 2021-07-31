using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LinkHubUI.Areas.Common
{
    public class BrowseURLController : Controller
    {
        private UrlBL urlBL;
        public BrowseURLController()
        {
            urlBL = new UrlBL();
        }
        // GET: Common/BrowseURL
        public ActionResult Index()
        {
             var URLs = urlBL.GetALL();
            return View(URLs);
        }
    }
}