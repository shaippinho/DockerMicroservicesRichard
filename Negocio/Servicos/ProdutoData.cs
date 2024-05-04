using AcessoDados.AcessoBanco;
using Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Servicos
{
    public class ProdutoData : IProdutoData
    {
        private readonly ISqlDataAccess _db;
        public ProdutoData(ISqlDataAccess db)
        {
            _db = db;
        }

        public Task<IEnumerable<Produto>> ObterListaProduto() =>
            _db.CarregarDados<Produto, dynamic>("select * from produtos", new { });

        public async Task<Produto?> ObterProduto(int id)
        {
            var results = await _db.CarregarDados<Produto, dynamic>("select * from produtos where idproduto = @idproduto", new { idproduto = id });
            return results.FirstOrDefault();
        }

        public Task InserirProduto(Produto produto) =>
            _db.SalvarDados("insert into dbo.Produtos (nmproduto, nuvalor) values (@nmproduto, @nuvalor);", new {produto.nmproduto, produto.nuvalor });

        public Task AtualizarProduto(Produto produto) =>
            _db.SalvarDados("update produtos set nmproduto = @nmproduto, nuvalor = @nuvalor where idproduto = @idproduto", produto);

        public Task DeletarProduto(int id) =>
            _db.SalvarDados("delete from produtos where idproduto = @idproduto", new { idproduto = id });

    }
}
