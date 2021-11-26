﻿using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSharp.Activity.CardGame;
using CSharp.Activity.Profile;

namespace Activity5.Test
{
    [TestClass]
    public class CardPlayerTest
    {
        private SimpleCard[] simpCard;
        private CardPlayer player;

        [TestInitialize]
        public void Initialize()
        {
            //Create an instance of CardPlayer and initialize with the required values
            player = new CardPlayer("Stupendous Man", PlayerProfile.MALE,
               new DateTime(1978, 4, 3), 5);

            //Initialize the SimpleCard object
            simpCard = new SimpleCard[6];

            //Add cards to the SimpleCard object
            for (int i = 0; i < simpCard.Length; i++)
            {
                simpCard[i] = new SimpleCard();
                simpCard[i].CardAttribute = i;
            }
        }

        [TestMethod]
        public void TestMethod1()
        {


            Assert.AreEqual("Stupendous Man", player.PlayerName);
            Assert.AreEqual(0, player.CardCount);
            Assert.AreEqual(5, player.MaxSize);

            for (int cardCount = 0; cardCount < 5; cardCount++)
            {
                player.AddCard(simpCard[cardCount]);
                Assert.AreEqual("Card " + cardCount, simpCard[cardCount].GetCardAttribute());
            }

            Assert.AreEqual(5, player.CardCount);

            Assert.IsTrue(player.IsFull());

            Assert.IsFalse(player.AddCard(simpCard[5]));

            Assert.IsTrue(player.RemoveCard(simpCard[2]));

            Assert.AreEqual(4, player.CardCount);
            Assert.AreEqual(5, player.MaxSize);
        }

        [TestMethod]
        [ExpectedException(typeof(System.ArgumentNullException))]
        public void TestAddCardNull()
        {
            player.AddCard(null);
        }
    }
}
