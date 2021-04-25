using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    class Player
    {
        public const int MAX_CARDS = 10; //maximum number of cards open for a player
        public const int ACE_VALUE = 14; //value of Ace in Card class
        public const int ACE_GAME_VALUE = 11; //value of Ace in twenty one
        public const int TWENTY_ONE = 21; //the goal of sum of cards!
        public const int PICTURE_VALUE = 10; //the value in thegame of any king, queen, jack
        private string name; //name of player
        private Card[] cards; //open cards array
        private int numCards; //num of open cards
        public Player(string name) //constructor
        {
            
        }
        public void AddCard(Card c) //add an open card to the array
        {
            
        }
        public Card FirstCard()
        {
            return null;
        } //Return the first card (used for dealer player only)
        public int GetSumValue() //calculate the maximum sum of card values that is less than 21 (in case of aces)
        {
            return 0;
        }

        private int GetNumOfAces()
        {
            return 0;
        }
        public void EmptyCards()
        {
            
        }

        public override string ToString()
        {
            return "";
        } //create a string with player name and all of its cards
    }
}
