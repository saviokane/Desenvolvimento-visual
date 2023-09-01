using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Tasks.Models;

namespace Tasks.Data.map
{
    public class UsuarioMap : IEntityTypeConfiguration<UsuarioModel>
    {
        public void Configure(EntityTypeBuilder<UsuarioModel> builder)
        {
            builder.HasKey(x => x._id);
            builder.Property(x => x._name).IsRequired().HasMaxLength(255);
            builder.Property(x => x._email).IsRequired().HasMaxLength(145);
        }
    }
}
