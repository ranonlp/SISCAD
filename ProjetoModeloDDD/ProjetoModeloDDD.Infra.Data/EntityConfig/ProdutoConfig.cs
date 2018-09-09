using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using ProjetoModeloDDD.Domain.Entities;

namespace ProjetoModeloDDD.Infra.Data.EntityConfig
{
    public class ProdutoConfig : EntityTypeConfiguration<Produto>
    {
        public ProdutoConfig()
        {
            HasKey(x => x.ProdutoId);
            Property(x => x.ProdutoId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.Nome).IsRequired().HasMaxLength(150);
            Property(x => x.Valor).IsRequired();
            Property(x => x.Disponivel).IsRequired();
            HasRequired(x => x.Cliente).WithMany().HasForeignKey(x => x.ClienteId);

        }


    }
}
