using Microsoft.EntityFrameworkCore;
using TarefaWorks.API.Data;
using TarefaWorks.API.Models;

namespace TarefaWorks.API.Repositories
{
    public class CardRepository : ICardRepository
    {
        private readonly DataContext _context;
        public CardRepository(DataContext context)
        {
            _context = context;
        }

        public void AddCard(Card card)
        {
            _context.Cards.Add(card);
            _context.SaveChanges();
        }

        public IEnumerable<Card> GetCards()
        {
            return _context.Cards.AsNoTracking().OrderBy(x => x.Status).ToList();
        }

        public IEnumerable<Card> GetCardsByStatus(string status)
        {
            return _context.Cards.AsNoTracking().Where(x => x.Status == status).OrderBy(x => x.Status).ToList();
        }

        public void UpdateInformationCard(Card card)
        {
            _context.Entry(card).State = EntityState.Modified;
            _context.SaveChanges();

        }

    }
}
