using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LinkHubUI.Areas.Admin.Controllers
{
    public class ListUsersController : Controller
    {
        // GET: Admin/ListUsers
        public ActionResult Index()
        {
            return View();
        }
    }
}