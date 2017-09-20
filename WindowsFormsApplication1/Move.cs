using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Move
    {
        Player _player;
        int _time;
        int _time_taken;
        Tile _tile;

        Game _game;

        public Move(Player player, Tile tile , Game game)
        {
            _player = player;
            _tile = tile;
            _game = game;
        }
        public Move(Player player,int tile , Game game)
        {
            _player = player;
            _game = game;
            _tile = _game.Tiles[tile];
        }
    }
}
