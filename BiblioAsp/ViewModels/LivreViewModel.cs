using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BiblioAsp.Models;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;

namespace BiblioAsp.ViewModels
{
    public class LivreViewModel
    {
        public Livre Livre { get; set; }
        [Display(Name = "Auteurs :")]
        public List<Auteur> Auteurs { get; set; }
        public int SelectValue { get; set; }
    }
}
