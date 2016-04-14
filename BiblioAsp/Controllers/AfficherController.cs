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
        public ActionResult Livre(int? id)
        {
            var listeLivre = this.dal.ObtenirLesLivres((int)id);
            if (listeLivre.Count == 0)
                return View("../Error");
            ViewData["livres"] = listeLivre;
            return View("LivreParId");
        }

        public ActionResult Auteurs(int? id)
        {
            if(id == null)
            {
                List<Models.Auteur> lesAuteurs = this.dal.ObtenirLesAuteurs();
                ViewData["lesAuteurs"] = lesAuteurs;
                return View("Auteurs");
            }
            else
            {
                List<Models.Livre> livresByAuteur = this.dal.ObtenirLivresParAuteur((int)id);
                if (livresByAuteur.Count == 0)
                    return View("../error");
                else
                {
                    ViewData["livresByAuteur"] = livresByAuteur;
                    return View("LivreParAuteur");
                }
            }       
        }
    }
}