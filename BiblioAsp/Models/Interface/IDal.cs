using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioAsp.Models.Interface
{
    public interface IDal : IDisposable
    {
        List<Auteur> ObtenirLesAuteurs();
        void AjouterAuteur(string nom);
        List<Livre> ObtenirLesLivres();
        List<Livre> ObtenirLivresParAuteur(int id);
        List<Livre> ObtenirLesLivres(int id);
        List<Livre> RechercheLivre(string recherche);
        void AjouterLivre(string titre, DateTime date, int idAuteur);
        bool LivreExiste(string titre);
    }
}
