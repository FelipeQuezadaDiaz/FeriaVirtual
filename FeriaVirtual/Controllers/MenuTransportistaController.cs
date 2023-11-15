using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FeriaVirtual.Controllers
{
    public class MenuTransportistaController : Controller
    {
        [Authorize]
        // GET: MenuTransportista
        public ActionResult Index()
        {
            return View();
        }
    }
}