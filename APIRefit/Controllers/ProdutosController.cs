using Dominio.Entidades;
using Dominio.Interfaces;
using Microsoft.AspNetCore.Http;
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
            var resulta = await _produtoRefit.ObterProdutoPorId(Id).ConfigureAwait(false);

            if (resulta is null)
                return NotFound();

            return Ok(resulta);
        }

        [HttpGet]
        public async Task<IActionResult> ObterProdutos()
        {
            try
            {
                var resulta = await _produtoRefit.ObterProdutos().ConfigureAwait(false);

                if (resulta is null)
                    return NotFound();

                return Ok(resulta);
            }
            catch(Exception exe)
            {
                return BadRequest();
            }
        }

        [HttpPost]
        public async Task<IActionResult> InserirProduto(Produto produto)
        {
            var resulta = await _produtoRefit.InserirProduto(produto).ConfigureAwait(false);

            if (resulta is null)
                return NotFound();

            return Ok(resulta);
        }


        [HttpPut]
        public async Task<IActionResult> AtualizarProduto(Produto produto)
        {
            var resulta = await _produtoRefit.AlterarProduto(produto).ConfigureAwait(false);

            if (resulta is null)
                return NotFound();

            return Ok(resulta);
        }


        [HttpDelete]
        [Route("Id")]
        public async Task<IActionResult> DeletarProduto(int Id)
        {
            var resulta = await _produtoRefit.DeletarProdutoPorId(Id).ConfigureAwait(false);

            if (resulta is null)
                return NotFound();

            return Ok(resulta);
        }

    }
}
