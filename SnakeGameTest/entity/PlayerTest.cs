using SnakeGame.entity;

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

        [TestMethod]
        public void CheckIfPlayerPositionIncrementAfterPlayingATurn() {
            Player.Position = 20;
            Player.PlayTurn(50, 25);
            Assert.IsTrue(Player.Position > 20);
        }

        [TestMethod]
        public void CheckIfPlayerPositionIsSetToDefaultAfterPlayingATurnWithPositionOverBoardSize() {
            Player.Position = 60;
            Player.PlayTurn(50, 25);
            Assert.IsTrue(Player.Position == 25);
        }
    }
}
