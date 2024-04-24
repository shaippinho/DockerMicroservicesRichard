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
            var results = await _db.CarregarDados<Produto, dynamic>("select * from produto where id_produto = @Id ", new { Id = id });
            return results.FirstOrDefault();
        }

        public Task InserirProduto(Produto produto) =>
            _db.SalvarDados("insert into dbo.Produtos (nm_produto, nu_valor) values (@nome, @valor);", new { produto.nome, produto.valor });

        public Task AtualizarProduto(Produto produto) =>
            _db.SalvarDados("update produtos set nm_produto = @nome, nu_valor = @valor where id_produto = @Id", produto);

        public Task DeletarProduto(int id) =>
            _db.SalvarDados("delete from produtos where id_produto = @Id", new { Id = id });

    }
}
