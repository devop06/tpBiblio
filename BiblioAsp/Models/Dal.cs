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

        public List<Livre> ObtenirLesLivres()
        {
            return this.bdd.Livres.ToList();
        }
        public List<Livre> ObtenirLesLivres(int id)
        {
            return this.bdd.Livres.ToList().Where(l => l.Id == id).ToList();
        }
        public void Dispose()
        {
            this.bdd.Dispose();
        }

        public List<Livre> ObtenirLivresParAuteur(int id)
        {
           var liste = this.bdd.Livres.Where(l => l.Auteur.Id == id);
           return liste.ToList();
        }

        public List<Livre> RechercheLivre(string recherche)
        {
           var found = this.bdd.Livres.Where(l => l.Titre.ToLower().Contains(recherche.ToLower()) || l.Auteur.Nom.ToLower().Contains(recherche.ToLower()));
           return found.ToList();
        }

        public void AjouterLivre(string titre, DateTime date, int idAuteur)
        {
            Auteur auteur = this.bdd.Auteurs.FirstOrDefault(aut => aut.Id == idAuteur);
            Livre l = new Livre() { Titre = titre, DateParution = date, Auteur = auteur };
            this.bdd.Livres.Add(l);
            this.bdd.SaveChanges();
        }

        public bool LivreExiste(string titre)
        {
           return this.ObtenirLesLivres().Exists(l => l.Titre == titre);
        }
    }
}
