using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    class Card
    {
        private int value;
        //0 - heart, 1 - club, 2 - diamon, 3 - spade       
        private int sign;
        public Card(int value, int sign)
        {
            this.value = value;
            this.sign = sign;
        }
        public int GetValue()
        {
            return this.value;
        }
        public int GetSign()
        {
            return this.sign;
        }
        public override string ToString()
        {
            string[] signs = { "Heart", "Club", "Diamond", "Spade" };
            string[] values = { "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King", "Ace" };
            return $"({values[this.value - 2]} of {signs[this.sign]})";
        }
    }
}
