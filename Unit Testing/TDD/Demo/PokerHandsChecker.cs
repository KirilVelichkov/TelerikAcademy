using System;
using System.Linq;

namespace Poker
{
    public class PokerHandsChecker : IPokerHandsChecker
    {
        public bool IsValidHand(IHand hand)
        {
            bool result = false;
            if (hand.Cards.Count == 5)
            {
                for (int i = 0; i < 5; i++)
                {
                    for (int j = i+1; j < 5; j++)
                    {
                        if(hand.Cards[i].ToString() == hand.Cards[j].ToString())
                        {
                            return false;
                        }
                    }
                }
                result = true;
            }

            return result;
        }

        public bool IsStraightFlush(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsFourOfAKind(IHand hand)
        {
            var count = hand.Cards.Count(x => x.Face.ToString() == hand.Cards.FirstOrDefault().Face.ToString());

            return count >= 4;
        }

        public bool IsFullHouse(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsFlush(IHand hand)
        {
            return hand.Cards.All(x => x.Suit.ToString() == hand.Cards.First().Suit.ToString());
        }

        public bool IsStraight(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsThreeOfAKind(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsTwoPair(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsOnePair(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsHighCard(IHand hand)
        {
            throw new NotImplementedException();
        }

        public int CompareHands(IHand firstHand, IHand secondHand)
        {
            throw new NotImplementedException();
        }
    }
}
