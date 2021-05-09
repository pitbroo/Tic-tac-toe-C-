using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kolko_i_krzyzyk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool isXorY = true;

        private void ClickButton(object sender, EventArgs e)
        {
            
            Button btn = sender as Button;
            
            btn.Text = isXorY ? "x" : "o";
            btn.Enabled = false;
            PlayerTurn.Text = isXorY ? "Kolej gracza 2" : "Kolej gracza 1";
            isXorY ^= true;
        }
        public void ResetFields()
        {
            
            button7.Text = string.Empty;
            button8.Text = string.Empty;
            button9.Text = string.Empty;
            button2.Text = string.Empty;
            button3.Text = string.Empty;
            button4.Text = string.Empty;
            button6.Text = string.Empty;
            button5.Text = string.Empty;
            button1.Text = string.Empty;
        }
        public void TurnOnButtons()
        {
            button8.Enabled = true;
            button9.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button6.Enabled = true;
            button5.Enabled = true;
            button1.Enabled = true;
            button7.Enabled = true;
        }

        private void newGame_Click(object sender, EventArgs e)
        {
            ResetFields();
            TurnOnButtons();
        }

    }
}
