using Dominio.Entidades;
using Refit;

namespace AcessoDados.Interfaces
{
    public interface IProdutoRefit
    {
        [Get("/Produto/{id}")]
        Task<Produto> ObterProduto(int Id);

        [Get("/Produtos")]
        Task<IEnumerable<Produto>> ObterProdutos();

        [Post("/Produto")]
        Task<string> InserirProduto([Body] Produto produto);

        [Put("/Produto")]
        Task<string> AtualizarProduto([Body] Produto produto);

        [Delete("/Produto/{id}")]
        Task<string> DeletarProduto(int Id);
    }
}
