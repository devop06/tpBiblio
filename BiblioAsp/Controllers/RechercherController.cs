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
        // GET: Rechercher
       public ActionResult Livre(String titre)
        {
            var lesLivres = this.dal.RechercheLivre(titre);
            ViewData["recherche"] = lesLivres;
            if (lesLivres.Count > 0)
                return View("TrouveLivre");
            else
                return View("../Error");
        }
    }
}