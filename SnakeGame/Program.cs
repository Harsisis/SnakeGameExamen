

using SnakeGame.entity;
using System.IO;

namespace SnakeGame {
    class Program {
        static void Main(string[] args) {
            Game Game = new Game("jeu");
            Game.AddPlayer(new Player("Martin"));
            Game.AddPlayer(new Player("Maurice"));
            Game.AddBonusPosition(10);
            Game.AddBonusPosition(20);
            Game.AddBonusPosition(30);
            Game.AddBonusPosition(40);
            Game.AddBonusPosition(42);

            Game.Start();
        }
    }
}