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
        List<Move> Moves;
        public List<Tile> Tiles;
        Player Player1;
        Player Player2;

        bool won;
        int Time;
        
        public Game()
        {
            for(int i = 0; i < 9; i++)
            {
                Tiles.Add(new Tile());
            }

            Time = 0;
            won = false;
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
        }

        public void MakeMove(Player player , int tile_id)
        {
            Moves.Add(new Move(player, tile_id, this));
        }

    }
}
