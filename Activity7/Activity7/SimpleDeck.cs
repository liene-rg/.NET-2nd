using CSharp.Activity.Datastore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Activity.CardGame
{
    public class SimpleDeck : CardDeck, ICard
    {
        private ArrayStore<ICard> SimpleCard;

        int defaultDeckCount = 52;
        public override void InitializeDeck()
        {
            this.SimpleCard = new ArrayStore<ICard>(defaultDeckCount);
        }
        public override void InitializeDeck(int numOfCards)
        {
            this.SimpleCard = new ArrayStore<ICard>(numOfCards);
        }

      

       public ArrayStore<ICard> Cards
        {
            get { return this.SimpleCard; }
        }

        public void CardDeck()
        {
            InitializeDeck(defaultDeckCount);

        }

        public void CardDeck(int number)
        {
           
            InitializeDeck(number);
        }

       protected Random randomCard = new Random();
        

        public ICard GetCard() {


            if (this.SimpleCard.IsEmpty())
                return null;

            else
            randomCard.Next(this.CardCount);
                
            SimpleCard.Remove((ICard)randomCard);
            return (ICard)randomCard;
                            
        
        }

        public ICard GetCard(ICard card)
        {

            if (card == null)
                throw new ArgumentNullException();
            
            else
            for (int i = 0; i < SimpleCard.Count; i++)
            {
                if (SimpleCard[i].Equals(card))
                        SimpleCard.RemoveAt(i);

                    if (!SimpleCard[i].Equals(card))
                        return null;
            }
            return (ICard)card;
            
        }

        public bool PutCard(ICard card)
        {
            if (card == null)
                throw new ArgumentNullException();
            else

            if(SimpleCard.IsFull())
              return false;
            else
            SimpleCard.Add((ICard)card);
            return true;
           
        }

        public int CardCount { get { return this.SimpleCard.Count; } }

        private int cardIndex;
        public int CardAttribute { get { return this.cardIndex; } set { this.cardIndex = value; } }

        

        public string GetCardAttribute()
        {
            return "Card " + this.CardAttribute;
        }

        string ICard.GetCardAttribute()
        {
            return this.CardAttribute.ToString();
        }

       
    }
}
