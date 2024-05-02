namespace Api_Vacinacao_Cachorro.Models
{
    public class CachorroModel
    {
        public int IdCachorro { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Raca { get; set; }
        public List<VacinaModel> Vacinas { get; set; }
    }
}
