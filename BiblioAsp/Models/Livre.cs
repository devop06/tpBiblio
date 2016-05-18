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
        public int Id { get; set; }

        [MaxLength(150)]
        [Index(IsUnique = true)]
        public string Titre { get; set; }
        public DateTime? DateParution { get; set; }
        public virtual Auteur Auteur { get; set; }
        public virtual Client Client { get; set; }
    }
}
