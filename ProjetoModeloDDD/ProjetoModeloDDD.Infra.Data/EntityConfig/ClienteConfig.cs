using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoModeloDDD.Domain.Entities;

namespace ProjetoModeloDDD.Infra.Data.EntityConfig
{
    public class ClienteConfig : EntityTypeConfiguration<Cliente>
    {
        public ClienteConfig()
        {
            HasKey(x => x.ClienteId);
            Property(x => x.ClienteId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.Nome).IsRequired().HasMaxLength(150);
            Property(x => x.Sobrenome).IsRequired().HasMaxLength(150);
            Property(x => x.Email).IsRequired().HasMaxLength(150);
            Property(x => x.DataCadastro).IsRequired();
            Property(x => x.Ativo).IsRequired();    

        }

    }
}
