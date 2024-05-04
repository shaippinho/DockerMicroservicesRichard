using AcessoDados.Interfaces;
using Dominio.Entidades;
using Microsoft.AspNetCore.Mvc;

namespace APIRefit.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutosController : ControllerBase
    {
        private readonly IProdutoRefit _produtoRefit;
        public ProdutosController(IProdutoRefit produtoRefit)
        {
            _produtoRefit = produtoRefit;
        }

        [HttpGet]
        [Route("Id")]
        public async Task<IActionResult> ObterProdutosPorId(int Id)
        {
            var result = await _produtoRefit.ObterProduto(Id).ConfigureAwait(false);

            if (result is null)
                return NotFound();

            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> ObterProdutos()
        {
            try
            {
                var result = await _produtoRefit.ObterProdutos().ConfigureAwait(false);

                if (result is null)
                    return NotFound();

                return Ok(result);
            }
            catch(Exception exe)
            {
                return BadRequest();
            }
        }

        [HttpPost]
        public async Task<IActionResult> InserirProduto(Produto produto)
        {
            var result = await _produtoRefit.InserirProduto(produto).ConfigureAwait(false);

            if (result is null)
                return NotFound();

            return Ok(result);
        }


        [HttpPut]
        public async Task<IActionResult> AtualizarProduto(Produto produto)
        {
            var resulta = await _produtoRefit.AtualizarProduto(produto).ConfigureAwait(false);

            if (resulta is null)
                return NotFound();

            return Ok(resulta);
        }


        [HttpDelete]
        [Route("Id")]
        public async Task<IActionResult> DeletarProduto(int Id)
        {
            var result = await _produtoRefit.DeletarProduto(Id).ConfigureAwait(false);

            if (result is null)
                return NotFound();

            return Ok(result);
        }

    }
}
