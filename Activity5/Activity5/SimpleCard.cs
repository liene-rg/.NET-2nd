
using CSharp.Activity.Datastore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace CSharp.Activity.CardGame
{
    public class SimpleCard : ICard
    {
           
             
        public SimpleCard()
        {

        }
        public SimpleCard(int cardIndex) { 
            this.cardIndex = cardIndex;
        }
        private int cardIndex;
        public int CardAttribute { get { return this.cardIndex; } set { this.cardIndex = value; } }

        public  string  GetCardAttribute()
        {
            return this.CardAttribute.ToString();
        }

        string ICard.GetCardAttribute()
        {
            return this.CardAttribute.ToString();
        }   

        ICard card = new SimpleCard(1);
        
       

        public ICard GetCard(int index)
        {
           
             if(this.CardAttribute.Equals(index))
                return card;
             else return null;
        }
    }



}
