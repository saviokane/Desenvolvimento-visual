using Microsoft.EntityFrameworkCore;
using Tasks.Data;
using Tasks.Models;
using Tasks.Repositorios.Interface;

namespace Tasks.Repositorios
{
    public class UsuarioRepositorio : IUsuarioRepositorio
    {
        private readonly SysTaskDBContext _dbContext;

        public UsuarioRepositorio(SysTaskDBContext sysTaskDBContext)
        {
            _dbContext = sysTaskDBContext;
        }
        public async Task<UsuarioModel> BuscarPorId(int id)
        {
            return await _dbContext.Usuario.FirstOrDefaultAsync(x => x._id == id);
        }

        public async Task<List<UsuarioModel>> BuscarTodosUsuarios()
        {
            return await _dbContext.Usuario.ToListAsync();
        }

        public async Task<UsuarioModel> Adicionar(UsuarioModel usuario)
        {
            await _dbContext.Usuario.AddAsync(usuario);
            await _dbContext.SaveChangesAsync();

            return usuario;
        }

        public async Task<UsuarioModel> Atualizar(UsuarioModel usuario, int id)
        {
            UsuarioModel UsuarioPorID = await BuscarPorId(id);
            if (UsuarioPorID == null)
            {
                throw new Exception($"Usuario para o ID: {id} não foi encontrado no banco de dados.");
            }
                UsuarioPorID._name = usuario._name;
                UsuarioPorID._email = usuario._email;

                _dbContext.Usuario.Update(UsuarioPorID);
                await _dbContext.SaveChangesAsync();

                return usuario;

            
        }

        public async Task<bool> Apagar(int id)
        {

            UsuarioModel UsuarioPorID = await BuscarPorId(id);

            if (UsuarioPorID == null)
            {
                throw new Exception($"Usuario para o ID: {id} não foi encontrado no banco de dados.");
            }
            _dbContext.Usuario.Remove(UsuarioPorID);
            _dbContext.SaveChanges();

            return true;
        }

        

        
    }
}
