using SnakeGame.exception;
using SnakeGame.utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame.entity
{
    public class Game {
        private const int GameBoardSize = 50;
        private const int GameBoardDefaultPosition = 25;

        public string Name { get; set; }
        public int BoardSize { get; set; }
        public int BoardDefaultPosition { get; set; }
        public List<Player> PlayerList { get; set; }
        public List<int> BoardBonusPositionList { get; set; }
        public bool IsGameEnded { get; set; }


        public Game(string name) {
            Name = name;
            BoardSize = GameBoardSize;
            BoardDefaultPosition = GameBoardDefaultPosition;
            PlayerList = new List<Player>();
            BoardBonusPositionList = new List<int>();
        }

        // need to be private
        public bool IsPlayerListEmpty() {
            return PlayerList == null || PlayerList.Count == 0;
        }

        public void AddPlayer(Player player) {
            PlayerList.Add(player);
        }

        public Player RemovePlayer(string playerName) {
            foreach (Player CurrentPlayer in PlayerList) {
                if (CurrentPlayer.Name == playerName) {
                    PlayerList.Remove(CurrentPlayer);
                    return CurrentPlayer;
                }
            }
            throw new NonExistingPlayerException("Player not found in Player List");
        }

        public void AddBonusPosition(int bonusPosition) {
            BoardBonusPositionList.Add(bonusPosition);
        }

        public void RemoveBonusPosition(int bonusPosition) {
            foreach (int CurrentBonus in BoardBonusPositionList) {
                if (CurrentBonus == bonusPosition) {
                    BoardBonusPositionList.Remove(CurrentBonus);
                    return;
                }
            }
            throw new NonExistingBonusPositionException("Bonus Position not found in Bonus List");
        }

        // need to be private
        public bool IsBonusPositionListEmpty() {
            return BoardBonusPositionList == null || BoardBonusPositionList.Count == 0;
        }

        // need to be private
        private void CheckIfGameCanStart() {
            if (IsBonusPositionListEmpty() || IsPlayerListEmpty())
                throw new GameException("Impossible to start Game, Player and/or bonusPosition are null or empty");
        }

        public void Start() {
            CheckIfGameCanStart();

            Printer.PrintMenu(Name);
            IsGameEnded = false;
            while (!IsGameEnded) {
                foreach (Player currentPlayer in this.PlayerList) {
                    do {
                        IsGameEnded = currentPlayer.PlayTurn(BoardSize, BoardDefaultPosition);
                    } while (BoardBonusPositionList.Contains(currentPlayer.Position));
                    if (IsGameEnded) {
                        Printer.PrintFireworks(Name);
                        break;
                    }
                }
            }
        }

    }
}
