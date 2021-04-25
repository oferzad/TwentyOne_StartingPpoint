using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    class CardDeck
    {
        private Card[] deck; //cards in deck
        private int numCards; // number of cards in deck
        private Card[] usedCards; //used cards
        private int numUsedCards; //num of used cards
        private Random r; //Random for getting a random card
        public CardDeck()
        {
            this.deck = new Card[52]; //deck is full with 52 cards
            this.numCards = 52; //deck starts full
            this.usedCards = new Card[52];
            this.numUsedCards = 0; //used cards starts empty
            this.r = new Random(); //create the random object
            //fill the deck ith all cards (4 signs * 13 values 2-14)
            for (int i = 0; i < 4; i++) //signs
                for (int j = 0; j < 13; j++) //values
                {
                    this.deck[i * 13 + j] = new Card(j + 2, i);
                    this.usedCards[i * 13 + j] = null;
                }
        }
        public Card GetCard()
        {
            //check if deck is not empty!
            if (this.numCards > 0)
            {
                //get a random number
                int index = r.Next(this.numCards);
                Card c = this.deck[index]; //get the random card
                //delete the card from the deck!
                for (int i = index; i < this.deck.Length - 1; i++)
                    this.deck[i] = this.deck[i + 1];
                this.deck[this.numCards - 1]  = null;
                this.numCards--;
                //add the card to the used cards array
                this.usedCards[this.numUsedCards] = c;
                this.numUsedCards++;
                return c;
            }
            else
                return null;
        }

        //Move all used cards back to the deck
        public void RefillDeck()
        {
            //loop through all used cards
            for (int i = 0; i < this.numUsedCards; i++)
            {
                //add the used card to the deck
                this.deck[this.numCards] = this.usedCards[i];
                this.numCards++;
                //set the used card array  cell to null
                this.usedCards[i] = null;
            }
            this.numUsedCards = 0;
        }
    }
}
