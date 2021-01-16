using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.Mvc;

namespace Livedev.Controllers
{
    public class PageController : Controller
    {

        //string connectionString = WebConfigurationManager.ConnectionStrings["Livedev"].ConnectionString;
        private ErpContext db = new ErpContext();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult SubModulePage()
        {
            //var SubmoduleList = db.Utl_Dynamic_Module_Category.ToList();
            //ViewBag.subModuleList = SubmoduleList;
            return View();
        }

        public ActionResult Pages(int? id)
        {
            ViewBag.ID = id;
            return View();
        }

        public ActionResult Table(int? id)
        {
            ViewBag.ID = id;
            return View();
        }

        public ActionResult EditSubModule(int? submoduleId)
        {

            return View();
        }


        public ActionResult SelectById(int? pageId)
        {
            return View();
        }
        public ActionResult SelectTableById(int? tableId)
        {
            return View();
        }

        public ActionResult EditPageById(int? pageId)
        {
            return View();
        }

        public ActionResult CreateSubModule(int? submoduleId)
        {
            return View();
        }

        public ActionResult CreatePage(int? cf)
        {
            return View();
        }
        public ActionResult CreateTable(int? cf)
        {
            return View();
        }






    }
}