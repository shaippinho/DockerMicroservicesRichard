
namespace AcessoDados.AcessoBanco
{
    public interface ISqlDataAccess
    {
        Task<IEnumerable<T>> CarregarDados<T, U>(string consulta, U parameters, string connectionId = "Default");
        Task SalvarDados<T>(string consulta, T parameters, string connectionId = "Default");
    }
}
