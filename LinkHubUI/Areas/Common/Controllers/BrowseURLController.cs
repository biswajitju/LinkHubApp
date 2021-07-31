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
        public ActionResult Index(string sortOder , string sortBy)
        {
            ViewBag.SortOder = sortOder;
            ViewBag.SortBy = sortBy;
            //Adding filter - Only approved url 
            var URLs = urlBL.GetALL().Where(a => a.IsApproved == "A");
            switch (sortBy)
            {
                case "Title":
                    switch (sortOder)
                    {
                        case "Asc":
                            URLs = URLs.OrderBy(a => a.UrlTitle);
                            break;
                        case "Desc":
                            URLs = URLs.OrderByDescending(a => a.UrlTitle);
                            break;
                        default:
                            break;

                    }
                    break;
                case "Url":
                    switch (sortOder)
                    {
                        case "Asc":
                             URLs = URLs.OrderBy(a => a.Url);
                            break;
                        case "Desc":
                            URLs = URLs.OrderByDescending(a => a.Url);
                            break;
                        default:
                            break;

                    }
                    break;
                case "UrlDesc":
                    switch (sortOder)
                    {
                        case "Asc":
                            URLs = URLs.OrderBy(a => a.UrlDesc);
                            break;
                        case "Desc":
                             URLs = URLs.OrderByDescending(a => a.UrlDesc);
                            break;
                        default:
                            break;

                    }
                    break;
                case "Category":
                    switch (sortOder)
                    {
                        case "Asc":
                             URLs = URLs.OrderBy(a => a.tbl_Category.CategoryName);
                            break;
                        case "Desc":
                             URLs = URLs.OrderByDescending(a => a.tbl_Category.CategoryName);
                            break;
                        default:
                            break;
                    }
                    break;
                default:
                    URLs = URLs.OrderBy(a=>a.UrlTitle);
                    break;

            }

            return View(URLs);
        }
    }
}