using System.ComponentModel.DataAnnotations;

namespace PetCafes.Models
{
    public class Produto
    {
        [Key]
        public int? Codigo { get; set; }        
        public string? Nome { get; set; }
        public string? Descricao { get; set; }
        public double? Valor { get; set; }

        public Produto() { }

        public Produto(string? nome, string? descricao, double? valor)
        {
            
            Nome = nome;
            Descricao = descricao;
            Valor = valor;
        }
    }
}