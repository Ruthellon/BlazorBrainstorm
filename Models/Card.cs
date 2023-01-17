using Brainstorm.Models.Common.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Brainstorm.Models
{
    public class Card
    {
        public CardSuit Suit { get; set; }
        public CardValue Value { get; set; }
        public bool IsCreature
        {
            get
            {
                return Suit == CardSuit.Clubs || Value >= CardValue.Jack || Value == CardValue.Ace;
            }
        }
        public string ImageName { get; set; }
        public bool IsVisible { get; set; }

        public bool IsRed
        {
            get
            {
                return Suit == CardSuit.Diamonds || Suit == CardSuit.Hearts;
            }
        }

        public bool IsBlack
        {
            get
            {
                return !IsRed;
            }
        }
    }
}
