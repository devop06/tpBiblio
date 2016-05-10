using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BiblioAsp.Models;
using System.Web.Mvc;

namespace BiblioAsp.ViewModels
{
    public class LivreViewModel
    {
        public Livre Livre { get; set; }
        public DateTime Date { get; set; }
        public IEnumerable<Auteur> SelectedAuteur { get; set; }
        public IEnumerable<SelectListItem> Auteurs { get; set; }
   
    }
}
