using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TarefaWorks.API.Models;
using TarefaWorks.API.Repositories;

namespace TarefaWorks.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CardController : ControllerBase
    {
        private readonly ICardRepository _card;
        public CardController(ICardRepository card)
        {
            _card = card;
        }

        [HttpPost]
        public ActionResult<Card> Post([FromBody] Card card)
        {
            try
            {
                _card.AddCard(card);
                return Ok(card);
            }
            catch (Exception)
            {
                return BadRequest(new { Message = "Não foi possível criar o card" });
            }
        }

        [HttpPut("{id}")]
        [Authorize(Roles = "PO")]
        public ActionResult<Card> Put(int id, [FromBody] Card card)
        {
            try
            {
                if(id != card.Id)
                {
                    return NotFound($"Não foi possível encontrar o card");
                }

                _card.UpdateInformationCard(card);
                return Ok(card);
            }
            catch (Exception)
            {
                return BadRequest(new { Message = "Não foi possível atualizar o card" });
            }
        }

        [HttpGet]
        public ActionResult<Card> GetCards()
        {
            try
            {
                var cards = _card.GetCards();
                return Ok(cards);
            }
            catch (Exception)
            {
                return BadRequest(new { Message = "Não foi possível obter os cards" });
            } 
        }

        [HttpGet("{status}")]
        public ActionResult<Card> GetCardsByStatus(string status)
        {
            try
            {
                var cards = _card.GetCardsByStatus(status);
                return Ok(cards);
            }
            catch (Exception)
            {
                return BadRequest(new { Message = "Não foi possível obter os cards" });
            }
        }
    }
}
