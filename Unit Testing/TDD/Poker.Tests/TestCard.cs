using NUnit.Framework;


namespace Poker.Tests
{
    [TestFixture]
    public class TestCard
    {
        [Test]
        public void CardToString_ShouldWorkProperly()
        {
            var card = new Card(CardFace.Ace, CardSuit.Clubs);

            var expectedResult = "Ace of Clubs";

            Assert.AreEqual(expectedResult, card.ToString());
        }

        [Test]
        public void CardToString_ShouldNotReturnNull()
        {
            var card = new Card(CardFace.Ace, CardSuit.Clubs);

            Assert.IsNotNull(card.ToString());
        }
    }
}
