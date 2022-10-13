using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SnakeGame.entity;
using SnakeGameTest;

namespace SnakeGameTest.entity {
    [TestClass]
    public class PlayerTest {

        public Player Player { get; set; }

        public PlayerTest() {
            this.Player = new Player("Martin");
        }

        [TestMethod]
        public void CheckIfNewlyCreatedPlayerNameIsNotEmpty() {
            Assert.IsNotNull(Player.Name);
        }

        [TestMethod]
        public void CheckIfNewlyCreatedPlayerCaseIsEgaleToZero() {
            Assert.AreEqual(0, Player.Position);
        }

        [TestMethod]
        public void CheckIfPlayerCanThrowDice() {
            Assert.AreNotEqual(0, Player.ThrowDice());
        }

        [TestMethod]
        public void CheckIfDiceResultIsCoherent() {
            Assert.IsTrue(Player.ThrowDice() >= 1 && Player.ThrowDice() <= 6);
        }

        [TestMethod]
        public void CheckPlayerPositionWin() {
            Player.Position = 50;
            Assert.IsTrue(Player.CheckPlayerPosition(50, 25));
        }

        [TestMethod]
        public void CheckPlayerPositionGoToDefaultBoardPosition() {
            Player.Position = 55;
            Assert.IsFalse(Player.CheckPlayerPosition(50, 25));
        }

        [TestMethod]
        public void CheckPlayerPositionNormalTurn() {
            Player.Position = 45;
            Assert.IsFalse(Player.CheckPlayerPosition(50, 25));
        }
    }
}
