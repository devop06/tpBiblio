using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioAsp.Models
{
    public class Livre
    {

        [ForeignKey("Client")]
        public int Id { get; set; }
        public string Titre { get; set; }
        public DateTime DateParution { get; set; }
        [Required]
        public virtual Auteur Auteur { get; set; }
    
        public virtual Client Client { get; set; }
    }
}
