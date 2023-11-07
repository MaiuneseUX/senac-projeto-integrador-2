using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_Integrador.Models
{
    public class Jogo
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string ImagemUrl { get; set; }
    }

    public class JogoRepository
    {
        private List<Jogo> jogos = new List<Jogo>
        {
            new Jogo { Id = 1, Nome = "Jogo 1", Descricao = "Descrição do Jogo 1", ImagemUrl = "/images/jogo1.jpg" },
            new Jogo { Id = 2, Nome = "Jogo 2", Descricao = "Descrição do Jogo 2", ImagemUrl = "/images/jogo2.jpg" },
            new Jogo { Id = 3, Nome = "Jogo 3", Descricao = "Descrição do Jogo 3", ImagemUrl = "/images/jogo3.jpg" }
        };

        public void Add(Jogo jogo)
        {
            jogo.Id = jogos.Count + 1;
            jogos.Add(jogo);
        }

        public List<Jogo> GetAll()
        {
            return jogos;
        }

        public Jogo GetById(int id)
        {
            return jogos.FirstOrDefault(j => j.Id == id);
        }

        public void Update(Jogo jogo)
        {
            var existingJogo = jogos.FirstOrDefault(j => j.Id == jogo.Id);
            if (existingJogo != null)
            {
                existingJogo.Nome = jogo.Nome;
                existingJogo.Descricao = jogo.Descricao;
            }
        }

        public void Delete(int id)
        {
            var jogo = jogos.FirstOrDefault(j => j.Id == id);
            if (jogo != null)
            {
                jogos.Remove(jogo);
            }
        }
    }
}
