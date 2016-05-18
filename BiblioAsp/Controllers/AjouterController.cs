using BiblioAsp.Models;
using BiblioAsp.Models.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BiblioAsp.Controllers
{
    public class AjouterController : Controller
    {
        private IDal dal;

        public AjouterController():this(new Dal())
        {

        }
        public AjouterController(IDal dal)
        {
            this.dal = dal;
        }
        // GET: Livre
        public ActionResult Livre()
        {
            BiblioAsp.ViewModels.AjoutLivreViewModel createLivre = new ViewModels.AjoutLivreViewModel();
            createLivre.Auteurs = this.dal.ObtenirLesAuteurs();
            createLivre.SelectValue = 1;
            return View(createLivre);
        }
        [HttpPost]
        public ActionResult Livre(ViewModels.AjoutLivreViewModel vM)
        {
            vM.Auteurs = this.dal.ObtenirLesAuteurs();
            if(ModelState.IsValid)
            {
                if (!this.dal.LivreExiste(vM.Titre))
                {
                    this.dal.AjouterLivre(vM.Titre, (DateTime)vM.DateParution, vM.SelectValue); // check datetime validation
                    return RedirectToAction("Index", "Home");
                }
                else
                    this.ModelState.AddModelError("Titre", "Le livre est déjà présent dans la base");
            }
            return View(vM);
        }
    }
}