using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioAsp.Models
{
    public class BiblioContext : DbContext
    {
        public DbSet<Auteur> Auteurs { get; set; }
        public DbSet<Livre> Livres { get; set; }
    }

    public class BibilioInitializer : DropCreateDatabaseIfModelChanges<BiblioContext>
    {
    }
}
