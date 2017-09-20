using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        bool Turn;

        Game Game;
        List<Button> buttons;
        public Form1()
        {
            InitializeComponent();
            Turn = false;

            Game = new Game();

            buttons = new List<Button>();
            buttons.Add(btn_1);
            buttons.Add(btn_2);
            buttons.Add(btn_3);
            buttons.Add(btn_4);
            buttons.Add(btn_5);
            buttons.Add(btn_6);
            buttons.Add(btn_7);
            buttons.Add(btn_8);
            buttons.Add(btn_9);
        }

        public void btn_Press(object sender ,EventArgs e)
        {
            Button b = (Button)sender;
            //b.Enabled = false;
            //if(Turn)
            //b.Text = "X";
            //else { b.Text = "O"; }
            //Turn = !Turn;


            string lastchar = b.Name.Substring(b.Name.Length - 1);
            int a;
            if(int.TryParse(lastchar, out a))
                Game.MakeMove(Game.moving_player,Convert.ToInt32(lastchar)-1);
            else { }
              
        }

        public void update_buttons()
        {
            foreach(var a in Game.Moves)
            {
                buttons[a._tile.id].Enabled = false;
                buttons[a._tile.id].Text = a._player.markierung;

            }

        }

        private void btn_optionen(object sender, EventArgs e)
        {
            Form_Optionen optionen = new Form_Optionen();
            optionen.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            try
            {
                Game.SecondElapsed();
            }catch(Exception ex)
            {
                
            }
            update_buttons();
            
        }
    }
}
