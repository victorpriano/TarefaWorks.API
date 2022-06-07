using TarefaWorks.API.Models;

namespace TarefaWorks.API.Repositories
{
    public interface ICardRepository
    {
        void AddCard(Card card);
        void UpdateInformationCard(Card card);
        IEnumerable<Card> GetCards();
        IEnumerable<Card> GetCardsByStatus(string status);
    }
}
