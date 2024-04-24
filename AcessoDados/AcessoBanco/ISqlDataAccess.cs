using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcessoDados.AcessoBanco
{
    public interface ISqlDataAccess
    {
        Task<IEnumerable<T>> CarregarDados<T, U>(string consulta, U parameters, string connectionId = "Default");
        Task SalvarDados<T>(string consulta, T parameters, string connectionId = "Default");
    }
}
