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
            BiblioAsp.ViewModels.LivreViewModel createLivre = new ViewModels.LivreViewModel();
            createLivre.Auteurs = this.dal.ObtenirLesAuteurs();
            createLivre.SelectValue = 1;
            return View(createLivre);
        }
        [HttpPost]
        public ActionResult Livre(ViewModels.LivreViewModel vM)
        {
            vM.Auteurs = this.dal.ObtenirLesAuteurs();
            if(ModelState.IsValid)
            {
                if (!this.dal.LivreExiste(vM.Livre.Titre))
                {
                    this.dal.AjouterLivre(vM.Livre.Titre, vM.Livre.DateParution, vM.SelectValue); // check datetime validation
                    return RedirectToAction("Index", "Home");
                }
                else
                    this.ModelState.AddModelError("Livre.Titre", "Le livre est déjà présent dans la base");
            }
            return View(vM);
        }
    }
}