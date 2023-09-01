using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Tasks.Models;

namespace Tasks.Data.map
{
    public class TarefaMap : IEntityTypeConfiguration<TarefaModel>
    {
        public void Configure(EntityTypeBuilder<TarefaModel> builder)
        {
            builder.HasKey(x => x._id);
            builder.Property(x => x._nome).IsRequired().HasMaxLength(255);
            builder.Property(x => x._descricao).IsRequired().HasMaxLength(145);
            builder.Property(x => x._status).IsRequired();
        }
    }
}
