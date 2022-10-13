using SnakeGame.entity;
using SnakeGame.exception;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGameTest.entity
{
    [TestClass]
    public class GameTest {
        public Game Game { get; set; }
        public Player Player { get; set; }


        public GameTest() {
            Game = new Game("jeu");
            Player = new Player("Martin");
        }

        [TestMethod]
        public void CheckIfGameNameIsNullOrEmpty() {
            Assert.IsNotNull(Game.Name);
            Assert.IsTrue(Game.Name != "");
        }

        [TestMethod]
        public void CheckIfBoardSizeIsCorrect() {
            Assert.AreEqual(50, Game.BoardSize);
        }

        [TestMethod]
        public void CheckIfBoardDefaultPositionIsCorrect() {
            Assert.AreEqual(25, Game.BoardDefaultPosition);
        }

        [TestMethod]
        public void AddPlayerToGamePlayerList() {
            Game.AddPlayer(Player);
            Assert.AreEqual(1, Game.PlayerList.Count);
        }

        [TestMethod]
        public void RemovePlayerToGamePlayerList() {
            Game.AddPlayer(Player);
            Assert.AreEqual(1, Game.PlayerList.Count);
            Game.RemovePlayer("Martin");
            Assert.AreEqual(0, Game.PlayerList.Count);
        }

        [TestMethod]
        public void AddPlayerXAndRemovePlayerXToGamePlayerList() {
            Game.AddPlayer(Player);
            Assert.AreEqual(Player, Game.RemovePlayer("Martin"));
        }

        [TestMethod]
        public void RemoveNonExistingPlayerToGamePlayerList() {
            Game.AddPlayer(Player);
            Assert.ThrowsException<NonExistingPlayerException>(() => Game.RemovePlayer("Maurice"));
        }

        [TestMethod]
        public void CheckIfPlayerListIsNullOrEmptyWithoutPlayer() {
            Assert.IsTrue(Game.IsPlayerListEmpty());
        }

        [TestMethod]
        public void CheckIfPlayerListIsNullOrEmptyWithPlayer() {
            Game.AddPlayer(Player);
            Assert.IsFalse(Game.IsPlayerListEmpty());
        }

        [TestMethod]
        public void AddBonusPositionToGameBonusList() {
            Game.AddBonusPosition(10);
            Game.AddBonusPosition(20);
            Game.AddBonusPosition(30);
            Assert.AreEqual(3, Game.BoardBonusPositionList.Count);
        }

        [TestMethod]
        public void RemovePlayerToGameBonusList() {
            Game.AddBonusPosition(10);
            Assert.AreEqual(1, Game.BoardBonusPositionList.Count);
            Game.RemoveBonusPosition(10);
            Assert.AreEqual(0, Game.BoardBonusPositionList.Count);
        }

        [TestMethod]
        public void RemoveNonExistingBonusPositionToGameBonusList() {
            Game.AddBonusPosition(10);
            Assert.ThrowsException<NonExistingBonusPositionException>(() => Game.RemoveBonusPosition(2));
        }

        [TestMethod]
        public void CheckIfBonusListIsNullOrEmptyWithoutBonus() {
            Assert.IsTrue(Game.IsBonusPositionListEmpty());
        }

        [TestMethod]
        public void CheckIfBonusListIsNullOrEmptyWithBonus() {
            Game.AddBonusPosition(10);
            Assert.IsFalse(Game.IsBonusPositionListEmpty());
        }

        [TestMethod]
        public void StartGameWithoutPlayerButBonusPosition() {
            Game.AddBonusPosition(10);
            Game.AddBonusPosition(15);
            Game.AddBonusPosition(20);
            Game.AddBonusPosition(25);
            Assert.ThrowsException<GameException>(() => Game.Start());
        }

        [TestMethod]
        public void StartGameWithoutBonusPositionButPlayer() {
            Game.AddPlayer(new Player("Martin"));
            Game.AddPlayer(new Player("Maurice"));
            Game.AddPlayer(new Player("Michel"));
            Game.AddPlayer(new Player("Marcel"));
            Assert.ThrowsException<GameException>(() => Game.Start());
        }

        [TestMethod]
        public void StartGameWithoutPlayerOrBonusPosition() {
            Assert.ThrowsException<GameException>(() => Game.Start());
        }
    }
}
