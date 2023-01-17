using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Brainstorm.Models
{
    public class DiscardPile : PileBase
    {
        public List<Card> GetAll()
        {
            return Cards.ToList();
        }
    }
}
