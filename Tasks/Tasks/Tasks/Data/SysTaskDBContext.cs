using Microsoft.EntityFrameworkCore;
using Tasks.Data.map;
using Tasks.Models;
namespace Tasks.Data
{
    public class SysTaskDBContext : DbContext
    {
        public SysTaskDBContext(DbContextOptions<SysTaskDBContext> options)
            : base(options)
        {
        }

        public DbSet<UsuarioModel> Usuario { get; set; }

        public DbSet<TarefaModel> Tarefas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
            {

                modelBuilder.ApplyConfiguration(new UsuarioMap());
                modelBuilder.ApplyConfiguration(new TarefaMap());

                base.OnModelCreating(modelBuilder);
            }
        }

    }

