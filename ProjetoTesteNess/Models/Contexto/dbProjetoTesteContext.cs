using ProjetoTesteNess.Models.Mapping;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace ProjetoTesteNess.Models.Contexto
{
    public class dbProjetoTesteContext : DbContext
    {
        static dbProjetoTesteContext()
        {
            Database.SetInitializer<dbProjetoTesteContext>(null);
        }
        public dbProjetoTesteContext()
            : base("Name=dbProjetoTesteContext")
        {
        }

        public DbSet<Usuario> Usuario { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
  
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Configurations.Add(new UsuarioMap());

            modelBuilder.Properties<string>()
                .Configure(p=>p.HasColumnType("varchar"));
            modelBuilder.Properties<string>()
              .Configure(p => p.HasMaxLength(100));

        }
        public override int SaveChanges()
        {
       
            return base.SaveChanges();
        }

    }
}