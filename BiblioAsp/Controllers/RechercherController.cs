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
            ViewData["recherche"] = this.dal.RechercheLivre(titre);
            return View("TrouveLivre");
        }
    }
}