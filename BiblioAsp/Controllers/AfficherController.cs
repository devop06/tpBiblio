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
            if (lesLivres.Count == 0)
                return View("../Error");
            return View(lesLivres);
        }
        public ActionResult Livre(int? id)
        {
            List<Models.Livre> listeLivre = this.dal.ObtenirLesLivres((int)id);
            if (listeLivre.Count == 0)
                return View("../Error");
            return View("LivreParId", listeLivre);
        }

        public ActionResult Auteurs(int? id)
        {
            if(!id.HasValue)
            {
                List<Models.Auteur> lesAuteurs = this.dal.ObtenirLesAuteurs();
                return View(lesAuteurs);
            }
            else
            {
                List<Models.Livre> livresByAuteur = this.dal.ObtenirLivresParAuteur((int)id);
                if (livresByAuteur.Count == 0 || livresByAuteur == null)
                    return View("../error");
                else           
                    return View("livreParAuteur",livresByAuteur);
            }       
        }
    }
}