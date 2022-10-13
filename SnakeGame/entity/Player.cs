namespace SnakeGame.entity {
    public class Player {
        public string Name { get; set; }
        public int Position { get; set; }

        public Player(string name) {
            Name = name;
            Position = 0;
        }

        // need to be private
        public int ThrowDice() {
            Random random = new Random();
            return random.Next(1, 7);
        }

        public bool PlayTurn(int boardSize, int boardDefaultPosition) {
            Position += ThrowDice();
            return CheckPlayerPosition(boardSize, boardDefaultPosition);
        }

        // need to be private
        public bool CheckPlayerPosition(int boardSize, int boardDefaultPosition) {
            if (Position == boardSize) {
                Console.WriteLine($"{Name} reach the board limit and won the game !!!");
                return true;
            } else if (Position > boardSize) {
                Position = boardDefaultPosition;
                Console.WriteLine($"{Name} overcome the board limit : new player position {boardDefaultPosition}");
            } else {
                Console.WriteLine($"{Name} : new player position {Position}");
            }
            return false;
        }
    }
}
