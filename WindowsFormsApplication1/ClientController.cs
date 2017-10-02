using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using __ClientSocket__;

namespace WindowsFormsApplication1
{
    class ClientController
    {
        private ClientSocket client;
        private string host;
        private int port;
        Game game;
        public ClientController(string _host, int _port)
        {
            host = _host;
            port = _port;
        }

        public bool writeZug(Move move)
        {
            
            try
            {
                
                client = new ClientSocket(host, port);
                client.connect();
                client.write(move._tile.id);
                client.write(move._player.Name);

                return true;

            }
            catch (Exception ex)
            {
                return false;
                throw ex;
            }
        }
        public Move readZug()
        {
            Move move;
            try
            {

                client = new ClientSocket(host, port);
                client.connect();
                int tilenum = client.read();
                string player_name = client.readLine();

                move = new Move(game.getPlayer(player_name), game.Tiles[tilenum], game);
                return move;

            }
            catch (Exception ex)
            {
                return null;
                throw ex;
            }
        }
    }
}
