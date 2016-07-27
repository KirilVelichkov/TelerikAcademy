using NUnit.Framework;
using Santase.Logic;
using Santase.Logic.Cards;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Santase.Tests
{
    [TestFixture]
    public class TestDeck
    {
        [Test]
        public void DeckConstructor_ShouldCreateADeck_With24Cards()
        {
            IDeck deck = new Deck();
            Assert.AreEqual(24, deck.CardsLeft);
            
        }

        [Test]
        public void CardsLeft_ShouldBe24_ForANewDeck()
        {
            IDeck deck = new Deck();
            Assert.AreEqual(24, deck.CardsLeft);
        }

        [Test]
        public void CardsLeft_ShouldBe23_AfterDrawingOneCard()
        {
            IDeck deck = new Deck();
            deck.GetNextCard();
            Assert.AreEqual(23, deck.CardsLeft);
        }

        [Test]
        public void CardsLeft_ShouldBe0_AfterDrawing24Cards()
        {
            IDeck deck = new Deck();
            for (var i = 0; i < 24; i++)
            {
                deck.GetNextCard();
            }

            Assert.AreEqual(0, deck.CardsLeft);
        }

        [Test]
        public void GetNextCard_ShouldNot_ChangeTheTrumpCard()
        {
            IDeck deck = new Deck();
            var trumpBefore = deck.TrumpCard;
            deck.GetNextCard();
            var trumpAfter = deck.TrumpCard;
            Assert.AreEqual(trumpBefore, trumpAfter);
        }

        [Test]
        public void GetNextCard_ShouldThrowException_WhenCalled25Times()
        {
            IDeck deck = new Deck();

            for (int i = 0; i < 24; i++)
            {
                deck.GetNextCard();
            }

            Assert.Throws<InternalGameException>(() => deck.GetNextCard());
        }
        [Test]
        [TestCase(CardSuit.Club, CardType.Jack)]
        [TestCase(CardSuit.Heart, CardType.King)]
        [TestCase(CardSuit.Diamond, CardType.Queen)]
        [TestCase(CardSuit.Spade, CardType.Ace)]
        public void ChangeTrupmCard_ShouldChangeTheTrupmCardProperply(CardSuit cardSuit, CardType cardType)
        {
            IDeck deck = new Deck();
            var changeTrump = new Card(cardSuit, cardType);
            deck.ChangeTrumpCard(changeTrump);

            var trumpCard = deck.TrumpCard;

            Assert.AreSame(changeTrump, trumpCard);
        }
    }
}
