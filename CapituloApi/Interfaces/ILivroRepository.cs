using CapituloApi.Models;

namespace CapituloApi.Interfaces
{
    public interface ILivroRepository
    {
        List<Livro> ler();
    }
}
