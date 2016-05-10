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
            List<SelectListItem> listSelectListItems = new List<SelectListItem>();

            foreach (Auteur a in this.dal.ObtenirLesAuteurs())
            {
                SelectListItem selectList = new SelectListItem()
                {
                    Text = a.Nom,
                    Value = a.Id.ToString(),
                };
                listSelectListItems.Add(selectList);
            }
            createLivre.Auteurs = listSelectListItems;
            return View(createLivre);
        }
    }
}