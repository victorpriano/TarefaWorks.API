
namespace TarefaWorks.API.Models
{
    public class Card
    {
        public Card(int id, string projeto, string objetivo, string descricao, DateTime dataPrevista, double tempoPrevisto, string equipe)
        {
            Id = id;
            Projeto = projeto;
            Objetivo = objetivo;
            Descricao = descricao;
            DataPrevista = dataPrevista;
            TempoPrevisto = tempoPrevisto;
            TempoSaldo = DateTime.Now.Hour - TempoPrevisto;
            Equipe = equipe;
            Status = "Aguardando";
        }

        public int Id { get; set; }
        public string Projeto { get; set; }
        public string Objetivo { get; set; }
        public string Descricao { get; set; }
        public DateTime DataPrevista { get; set; }
        public double TempoPrevisto { get; set; }
        public double TempoSaldo { get; set; }
        public string Equipe { get; set; }
        public string Status { get; set; }

    }
}
