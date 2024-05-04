using Dominio.Entidades;


namespace Dominio.Interfaces
{
    public interface IProdutoData
    {
        Task DeletarProduto(int id);
        Task<Produto?> ObterProduto(int id);
        Task<IEnumerable<Produto>> ObterListaProduto();
        Task InserirProduto(Produto produto);
        Task AtualizarProduto(Produto produto);
    }
}
