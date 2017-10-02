using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    enum Tiles { A1,A2,A3,B1,B2,B3,C1,C2,C3};




    class Game
    {
        public List<Move> Moves;
        public List<Tile> Tiles;
        Player Player1;
        Player Player2;
        public Player moving_player { get; set; }

        bool won;
        int Time;
        
        public Game()
        {
            Tiles = new List<Tile>();
            Moves = new List<Move>();

            Player1 = new Player();
            Player2 = new Player();

            for(int i = 0; i < 9; i++)
            {
                Tiles.Add(new Tile(i));
            }

            Time = 0;
            won = false;

            moving_player = Player1;
            Player1.markierung = "X";
            Player2.markierung = "O";
            
        }

        public void Update()
        {
            while (!won)
            {

            }

        }

        public void SecondElapsed()
        {
            Time++;
        }

        public void MakeMove(Player player, Tile tile)
        {
            Moves.Add(new Move(player, tile, this));

            // Ändert den Spieler der am Zug ist
            if (moving_player == Player1)
            {
                moving_player = Player2;
            }
            else { moving_player = Player1; }
        }

        public void MakeMove(Player player , int tile_id)
        {
            Moves.Add(new Move(player, tile_id, this));

            // Ändert den Spieler der am Zug ist
            if (moving_player == Player1)
            {
                moving_player = Player2;
            }
            else { moving_player = Player1; }
        }

        public Player getPlayer(string _name)
        {
            if(Player1.Name == _name)
            {
                return Player1;
            }
            else if (Player2.Name == _name)
            {
                return Player2;
            }
            else { return null; }
        }

    }
}
