using Dominio.Entidades;
using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Interfaces
{
    public interface IProdutoRefit
    {
        [Get("/Produto/{id}")]
        Task<Produto> ObterProdutoPorId(int Id);

        [Get("/Produto")]
        Task<IEnumerable<Produto>> ObterProdutos();

        [Post("/Produto")]
        Task<string> InserirProduto([Body] Produto produto);

        [Post("/Produto")]
        Task<string> AlterarProduto([Body] Produto produto);

        [Get("/Produto/{id}")]
        Task<string> DeletarProdutoPorId(int Id);
    }
}
