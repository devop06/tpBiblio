using BiblioAsp.Models.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioAsp.Models
{
    public class Dal : IDal
    {
        private BiblioContext bdd;

        public Dal()
        {
            this.bdd = new BiblioContext();
        }
        public void AjouterAuteur(string nom)
        {
            this.bdd.Auteurs.Add(new Auteur { Nom = nom });
            this.bdd.SaveChanges();
        }

        public List<Auteur> ObtenirLesAuteurs()
        {
            return this.bdd.Auteurs.ToList();
        }

        public void Dispose()
        {
            this.bdd.Dispose();
        }
    }
}
