﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BiblioAsp.Models;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;

namespace BiblioAsp.ViewModels
{
    public class AjoutLivreViewModel
    {
        [Required(ErrorMessage = "Renseignez un titre svp")]
        public string Titre { get; set; }
        [Required(ErrorMessage = "Veuillez indiquer une date de parution")] // expression régulière
        public DateTime? DateParution { get; set; } // voir contrôle 
        [Display(Name = "Auteurs :")]
        public List<Auteur> Auteurs { get; set; }
        public int SelectValue { get; set; }
    }
}