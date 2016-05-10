using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BiblioAsp.Controllers
{
    public class RechercherController : Controller
    {
        public Models.Interface.IDal dal;
        public RechercherController()
        {
            this.dal = new Models.Dal();
        }

        public  ActionResult Index()
        {
            return View();
        }
        // GET: Rechercher
       public ActionResult Livre(String titre)
       {
            List<BiblioAsp.Models.Livre> lesLivres = this.dal.RechercheLivre(titre);
            if (lesLivres.Count > 0)
                return View("TrouveLivre", lesLivres);
            else
                return View("../Error");
       }
        

        [HttpPost]
        public ActionResult  Index(String titre)
        {
            return Livre(titre);
        }
    }
}