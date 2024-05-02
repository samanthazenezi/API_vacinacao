using Api_Vacinacao_Cachorro.Models;

namespace Api_Vacinacao_Cachorro.Service
{
    public class CachorroService
    {
        public List<CachorroModel> listaDeCachorros;

        public CachorroService()
        {
           listaDeCachorros = new List<CachorroModel>();
        }
    }
}
