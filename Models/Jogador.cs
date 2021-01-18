using System;

namespace E_Players_AspNetCore.Models
{
    public class Jogador
    {
        public int IdJogador { get; set; }
        public string Nome { get; set; }
        public int IdEquipe { get; set; }

        internal dynamic ReadAll()
        {
            throw new NotImplementedException();
        }

        internal void Create(Jogador novoJogador)
        {
            throw new NotImplementedException();
        }

        internal void Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}