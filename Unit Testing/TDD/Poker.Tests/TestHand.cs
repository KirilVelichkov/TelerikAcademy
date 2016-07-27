using NUnit.Framework;
using System.Collections.Generic;

namespace Poker.Tests
{
    [TestFixture]
    public class TestHand
    {
        [Test]
        public void HandToString_ShouldWorkProperly()
        {
            IList<ICard> cards = new List<ICard>()
            {
                 new Card(CardFace.Ace, CardSuit.Clubs),
                 new Card(CardFace.Eight, CardSuit.Hearts)
            };
            IHand hand = new Hand(cards);

            var expectedResult = "Ace of Clubs\r\nEight of Hearts";

            Assert.AreEqual(expectedResult, hand.ToString());
        }

        [Test]
        public void HandToString_ShouldNotReturnNull()
        {
            IList<ICard> cards = new List<ICard>()
            {
                 new Card(CardFace.Ace, CardSuit.Clubs),
                 new Card(CardFace.Eight, CardSuit.Hearts)
            };
            IHand hand = new Hand(cards);

            Assert.IsNotNull(hand.ToString());
        }

        [Test]
        public void IsValidHand_ShouldReturnTrue_IfHandIsValid()
        {
            IList<ICard> cards = new List<ICard>()
            {
                 new Card(CardFace.Ace, CardSuit.Clubs),
                 new Card(CardFace.Ace, CardSuit.Diamonds),
                 new Card(CardFace.Five, CardSuit.Diamonds),
                 new Card(CardFace.King, CardSuit.Spades),
                 new Card(CardFace.Jack, CardSuit.Hearts)

            };
            IHand hand = new Hand(cards);
            var checker = new PokerHandsChecker();
            Assert.IsTrue(checker.IsValidHand(hand));
        }

        [Test]
        public void IsValidHand_ShouldReturnFalse_IfHandIsNotValid()
        {
            IList<ICard> cards = new List<ICard>()
            {
                 new Card(CardFace.Ace, CardSuit.Clubs),
                 new Card(CardFace.Ace, CardSuit.Clubs),
                 new Card(CardFace.Five, CardSuit.Diamonds),
                 new Card(CardFace.King, CardSuit.Spades),
                 new Card(CardFace.Jack, CardSuit.Hearts)

            };
            IHand hand = new Hand(cards);
            var checker = new PokerHandsChecker();
            Assert.IsFalse(checker.IsValidHand(hand));
        }

        [Test]
        public void IsValidHand_ShouldNotReturn_Null()
        {
            IList<ICard> cards = new List<ICard>()
            {
                 new Card(CardFace.Ace, CardSuit.Clubs),
                 new Card(CardFace.Ace, CardSuit.Clubs),
                 new Card(CardFace.Five, CardSuit.Diamonds),
                 new Card(CardFace.King, CardSuit.Spades),
                 new Card(CardFace.Jack, CardSuit.Hearts)

            };
            IHand hand = new Hand(cards);
            var checker = new PokerHandsChecker();
            Assert.IsNotNull(checker.IsValidHand(hand));
        }

        [Test]
        public void IsFlush_ShouldReturnTrue_IfAllSuitsAreTheSame()
        {
            IList<ICard> cards = new List<ICard>()
            {
                 new Card(CardFace.Ace, CardSuit.Clubs),
                 new Card(CardFace.Eight, CardSuit.Clubs),
                 new Card(CardFace.Five, CardSuit.Clubs),
                 new Card(CardFace.King, CardSuit.Clubs),
                 new Card(CardFace.Jack, CardSuit.Clubs)

            };
            IHand hand = new Hand(cards);
            var checker = new PokerHandsChecker();
            Assert.IsTrue(checker.IsFlush(hand));
        }

        [Test]
        public void IsFlush_ShouldReturnFalse_IfNotAllSuitsAreTheSame()
        {
            IList<ICard> cards = new List<ICard>()
            {
                 new Card(CardFace.Ace, CardSuit.Diamonds),
                 new Card(CardFace.Eight, CardSuit.Clubs),
                 new Card(CardFace.Five, CardSuit.Clubs),
                 new Card(CardFace.King, CardSuit.Clubs),
                 new Card(CardFace.Jack, CardSuit.Clubs)

            };
            IHand hand = new Hand(cards);
            var checker = new PokerHandsChecker();
            Assert.IsFalse(checker.IsFlush(hand));
        }

        [Test]
        public void IsFourOfAKind_ShouldReturnTrue_IfThereAre4SameCardFace()
        {
            IList<ICard> cards = new List<ICard>()
            {
                 new Card(CardFace.Ace, CardSuit.Diamonds),
                 new Card(CardFace.Ace, CardSuit.Spades),
                 new Card(CardFace.Ace, CardSuit.Hearts),
                 new Card(CardFace.Ace, CardSuit.Clubs),
                 new Card(CardFace.Jack, CardSuit.Clubs)
            };
            IHand hand = new Hand(cards);
            var checker = new PokerHandsChecker();
            Assert.IsTrue(checker.IsFourOfAKind(hand));
        }
        [Test]
        public void IsFourOfAKind_ShouldReturnFalse_IfThereAreNot4SameCardFace()
        {
            IList<ICard> cards = new List<ICard>()
            {
                 new Card(CardFace.King, CardSuit.Diamonds),
                 new Card(CardFace.Ace, CardSuit.Spades),
                 new Card(CardFace.Ace, CardSuit.Hearts),
                 new Card(CardFace.Ace, CardSuit.Clubs),
                 new Card(CardFace.Jack, CardSuit.Clubs)
            };
            IHand hand = new Hand(cards);
            var checker = new PokerHandsChecker();
            Assert.IsFalse(checker.IsFourOfAKind(hand));
        }


    }
}
