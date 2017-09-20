using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Tile
    {
        public int id { get; set; }
        bool Pressed;
        Player pressed_by;

        public Tile(int _id )
        {
            id = _id;
        }
        
    }
}
