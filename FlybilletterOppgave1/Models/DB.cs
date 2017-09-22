using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace FlybilletterOppgave1.Models
{
    public class DB : DbContext
    {
        public DB()
            : base("name=Bestillinger") //navnet til connection strengen til databasen. 
        {
            Database.CreateIfNotExists();
        }
        public DbSet<Bestillinger> Bestillinger { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //må ha hvis vi progr på norsk og har norske navn. For å unngå s(flertall) bak tabellnavnet. 
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

    }
}