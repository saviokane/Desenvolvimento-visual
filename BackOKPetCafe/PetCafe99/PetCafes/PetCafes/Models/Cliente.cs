using System.ComponentModel.DataAnnotations;

namespace PetCafes.Models
{
    public class Cliente
    {
        [Key]
        public string? Cpf { get; set; }
        public string? Nome { get; set; }
        
        public Cliente() { }

        public Cliente(string Cpf, string Nome)
        {
            this.Cpf = Cpf;
            this.Nome = Nome;
        }
    }
}
