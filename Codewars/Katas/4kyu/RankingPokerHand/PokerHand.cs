using System.Collections.Generic;
using System.Linq;

namespace Katas._4kyu.RankingPokerHand {
    public class PokerHand {
        public PokerHand(string hand) {
            var cardStrings = hand.Split(' ');

            var cards = new List<Card>();
            foreach (var cardString in cardStrings) {
                cards.Add(new Card(cardString));
            }

            var orderedDescendingCards = cards.OrderByDescending(a => a.power);

            CalculateHandPower(orderedDescendingCards);

        }


        //poker = flash + straight 80
        //4 70
        //is this fullhouse  60
        //is this flash 50
        //is this straight 40
        // 3 30
        // 2 and 2 22 
        // 2 20
        // high card  == 10
        public long CalculateHandPower(IOrderedEnumerable<Card> orderedDescendingCards) {
            var handPower = 0;

            
            if (orderedDescendingCards.Select(a => a.CardColor).Distinct().Count() == 1)
                handPower = 5000;

            

            return handPower;
        }

        public Result CompareWith(PokerHand hand) {
            return Result.Tie;

        }
    }

    public enum Result {
        Win,
        Loss,
        Tie
    }
}

public class Card {
    public Card(string cardString) {
        if (cardString[0].Equals('A'))
            power = 14;
        else if (cardString[0].Equals('K'))
            power = 13;
        else if (cardString[0].Equals('Q'))
            power = 12;
        else if (cardString[0].Equals('J'))
            power = 11;
        else if (cardString[0].Equals('T'))
            power = 10;
        else {
            power = int.Parse(cardString[0].ToString());
        }
        CardColor = cardString[1];
    }

    public int power { get; set; }
    public char CardColor { get; set; }

    public override string ToString() {
        return power + " " + CardColor;

    }
}

public enum CardColor {
    C = 1,
    D = 2,
    H = 3,
    S = 4
}
