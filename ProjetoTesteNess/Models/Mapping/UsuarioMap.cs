using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace ProjetoTesteNess.Models.Mapping
{
    public class UsuarioMap : EntityTypeConfiguration<Usuario>
    {
        public UsuarioMap() 
        {

            // Primary Key
            this.HasKey(t => t.userID);

            // Properties
            this.Property(t => t.userID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.nome)
              .IsRequired()
              .HasMaxLength(30);
            this.Property(t => t.cpf)
               .IsRequired()
               .HasMaxLength(15);

            this.Property(t => t.telefone)
               .IsRequired()
               .HasMaxLength(30);

                this.ToTable("Usuario");
                this.Property(t => t.userID).HasColumnName("Id");
                this.Property(t => t.nome).HasColumnName("nome");
                this.Property(t => t.cpf).HasColumnName("cpf");
                this.Property(t => t.telefone).HasColumnName("telefone");
        }
    }
}