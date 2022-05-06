using Application.CardQuery;
using card_sorting_api1.Domain;
using Microsoft.AspNetCore.Mvc;

namespace card_sorting_api1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : Controller
    {
        public readonly ICardQuery _cardQuery;
        public HomeController(ICardQuery cardQuery)
        {
            _cardQuery = cardQuery;
        }
        [HttpPost]
        public IEnumerable<Card> GetSortedCards(IEnumerable<Card> cards)
        {
            return cards.OrderBy(card=>card.priority);

        }
        [HttpGet]
        public IEnumerable<Card> Get()
        {
            var cards = _cardQuery.Get();
            return cards;

        }
    }
}
