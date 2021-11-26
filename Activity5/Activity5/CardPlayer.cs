using CSharp.Activity.Datastore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Activity.CardGame
{
    public class CardPlayer : Profile.PlayerProfile
    {

       public int maxNumCard;
        


        public CardPlayer(string name, char gender, DateTime birthDate, int maxNumCard) : base(name, gender, birthDate)
        {
            this.maxNumCard = maxNumCard;
        }


        ArrayStore<ICard> cardHand = new ArrayStore<ICard>();
               

        public int CardCount { get; protected set; }

        
        public int MaxSize => this.cardHand.Length;

        


        public bool AddCard(ICard card)
        {
            if (card == null)
                throw new ArgumentNullException();
            if (cardHand.IsFull())
                throw new IndexOutOfRangeException();
            

            else cardHand.Add(card);
            return true;
        }

        public bool RemoveCard(ICard card)
        {
            if (card == null)
                throw new ArgumentNullException();

            if (cardHand.IsEmpty())
                throw new InvalidOperationException();

            for (int i =0; i < cardHand.Count; i++)
            {
                if(cardHand[i].Equals(card))
                    cardHand.RemoveAt(i);
               
            }
            return true;

           
        }
        

        public bool IsFull()
        {
          if(this.cardHand.Length == MaxSize)
                return true;
          else return false;

        }

       


        }
    }

