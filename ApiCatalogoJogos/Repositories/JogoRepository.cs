using ApiCatalogoJogos.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCatalogoJogos.Repositories
{
    public class JogoRepository : IJogoRepository
    {
        public Task Atualizar(Jogo jogo)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public Task Inserir(Jogo jogo)
        {
            throw new NotImplementedException();
        }

        public Task<List<Jogo>> Obter(int pagina, int quantidade)
        {
            throw new NotImplementedException();

        }

        public Task<Jogo> Obter(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Jogo>> Obter(string nome, string produtora)
        {
            throw new NotImplementedException();
        }

        public Task Remover(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
