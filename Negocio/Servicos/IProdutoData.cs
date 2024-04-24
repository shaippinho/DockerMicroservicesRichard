using Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Servicos
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
