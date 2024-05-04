using Dominio.Entidades;
using Microsoft.AspNetCore.Mvc;
using Negocio.Servicos;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CadastroProduto.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public static class produtosController
    {

        public static void ConfigureApi(this WebApplication app)
        {
            app.MapGet("/Produtos", ObterProdutos);
            app.MapGet("/Produto/{id}", ObterProduto);
            app.MapPost("/Produto", Inserirproduto);
            app.MapPut("/Produto", AtualizarProduto);
            app.MapDelete("/Produto/{id}", DeletarProduto);

        }

        [HttpGet]
        private static async Task<IResult> ObterProdutos(IProdutoData data)
        {
            try
            {
                return Results.Ok(await data.ObterListaProduto());
            }
            catch (Exception ex)
            {

                return Results.Problem(ex.Message);
            }
        }

        [HttpGet("{id}")]
        private static async Task<IResult> ObterProduto(int id, IProdutoData data)
        {
            try
            {
                var produto = await data.ObterProduto(id);
                if (produto == null) return Results.NotFound();

                return Results.Ok(produto);
            }
            catch (Exception ex)
            {

                return Results.Problem(ex.Message);
            }
        }

        [HttpPost]
        private static async Task<IResult> Inserirproduto(Produto produto, IProdutoData data)
        {
            try
            {
                await data.InserirProduto(produto);
                return Results.Ok("O produto foi inserido com sucesso!");
            }
            catch (Exception ex)
            {

                return Results.Problem(ex.Message);
            }
        }

        [HttpPut]
        private static async Task<IResult> AtualizarProduto(Produto produto, IProdutoData data)
        {
            try
            {
                await data.AtualizarProduto(produto);

                return Results.Ok("O produto foi atualizado com sucesso!");
            }
            catch (Exception ex)
            {

                return Results.Problem(ex.Message);
            }
        }

        [HttpDelete]
        private static async Task<IResult> DeletarProduto(int id, IProdutoData data)
        {
            try
            {
                await data.DeletarProduto(id);

                return Results.Ok("O produto foi deletado com sucesso!");
            }
            catch (Exception ex)
            {

                return Results.Problem(ex.Message);
            }
        }
    }
}
