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
        public Form1()
        {
            InitializeComponent();
            Turn = false;
        }

        public void btn_Press(object sender ,EventArgs e)
        {
            Button b = (Button)sender;
            b.Enabled = false;
            if(Turn)
            b.Text = "X";
            else { b.Text = "O"; }
            Turn = !Turn;
              
        }

        private void btn_optionen(object sender, EventArgs e)
        {
            Form_Optionen optionen = new Form_Optionen();
            optionen.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
