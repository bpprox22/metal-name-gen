using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using metalnamegen;
using MetalNameGenWebApp.ViewModels;

namespace MetalNameGenWebApp.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            IndexViewModel ivm = new IndexViewModel();

            return View(ivm);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(int SelectedNameCountOptionValue)
        {
            IndexViewModel ivm = new IndexViewModel();
            Brutal b = new Brutal();

            ivm.MetalName = b.generateBrutalName(SelectedNameCountOptionValue);

            return View(ivm);
        }
    }
}