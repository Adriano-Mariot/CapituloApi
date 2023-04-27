using CapituloApi.Contexts;
using CapituloApi.Interfaces;
using CapituloApi.Models;

namespace CapituloApi.Repositories
{
    public class LivroRepository : ILivroRepository
    {
        private readonly CapituloContext _capituloContext;
        public LivroRepository(CapituloContext context) 
        {
            _capituloContext= context;
        }

        public List<Livro> ler()
        {
            return _capituloContext.Livros.ToList();
        }
    }
}
