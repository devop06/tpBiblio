using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BiblioAsp.Controllers
{
    public class AfficherController : Controller
    {
        private Models.Interface.IDal dal;
        public AfficherController()
        {
            this.dal = new Models.Dal();
        }
        // GET: Afficher
        public ActionResult Index()
        {
            List<Models.Livre> lesLivres = this.dal.ObtenirLesLivres();
            ViewData["livres"] = lesLivres;
            return View("Index");
        }
        public string Livre(int?id)
        {
            return "livre " + id;
        }
        public string Auteurs(int? id)
        {
             return "les livres de l'auteur " + id;
        }
  
    }
}