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
        [Required(ErrorMessage = "Renseignez un titre svp")]
        [MaxLength(150)]
        [Index(IsUnique = true)]
        public string Titre { get; set; }

        // [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
       [RegularExpression(@"^(3[01]|[12][0-9]|0[1-9])[-/](1[0-2]|0[1-9])[-/][0-9]{4}$", ErrorMessage = "tutu")]
        //[DataType(DataType.Date, ErrorMessage = "Please enter a valid date.")]
        public DateTime DateParution { get; set; }
        public virtual Auteur Auteur { get; set; }
        public virtual Client Client { get; set; }
    }
}
