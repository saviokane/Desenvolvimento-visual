using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula01
{
    internal class Cliente
    {
        // Atibutos
        private String _nome;
        private int _idade;
        public static List<Cliente> cliente = new();


        #region getter e setters
        public String Nome
        {
            get => _nome;
            set => _nome = value;
        }

        public int Idade
        {
            get => _idade;
            set => _idade = value;
        }

        #endregion

        #region propriedades públicas
        public Cliente()
        {
            _nome = String.Empty;
            _idade = 0;
        }       

        public Cliente(String cpf,int idade)
        {
            _nome = Nome;
            _idade = Idade;
        }
        #endregion

        #region constructors
        public Cliente(String nome)
        {
            Cliente cTemp = cliente.Find(x => x.Nome == nome);
            if(cTemp == null)
            {
                _idade = 0;
                _nome = string.Empty;
            }
            else
            {
                _idade = cTemp.Idade;
                _nome = cTemp.Nome;
                
            }
        }
        #endregion

        #region crud
        public void inserir()
        {
            cliente.Add(this);
        }
        #endregion
    }
}
