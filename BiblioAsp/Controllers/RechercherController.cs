using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BiblioAsp.Controllers
{
    public class RechercherController : Controller
    {
        // GET: Rechercher
       public string Livre(String titre)
        {
            return "Livre titre recherché : " + titre;
        }
    }
}