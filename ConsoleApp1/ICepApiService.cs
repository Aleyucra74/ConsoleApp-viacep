using Refit;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    interface ICepApiService
    {

        [Get("/ws/{cep}/json")]
        Task<CepResponse> GetAddressAsync(string cep);

    }
}
