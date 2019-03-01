using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTocProject
{
    public partial class Form1 : Form
    {
        int turns = 0;
        int p1 = 0;
        int p2 = 0;
        int pd = 0;
        public Form1()
        {

            InitializeComponent();
            label1.Text = "player 1 wins:" + p1;
            label2.Text = "player 2 wins:" + p2;
            label3.Text = "draws:" + pd;
        }

        private void a1_Click(object sender, EventArgs e)
        {
            if ((sender as Button).Text == "")
            {
                if (turns % 2 == 0) (sender as Button).Text = "X";
                else (sender as Button).Text = "O";
                turns++;
            }
            WinCheck();
            if (turns == 9)
            {
                pd++;
                ResetClick(null, null);
            }
            label1.Text = "player 1 wins:" + p1;
            label2.Text = "player 2 wins:" + p2;
            label3.Text = "draws:" + pd;
        }

        private void NewGame(object sender, EventArgs e)
        {
            ResetClick(sender, e);
            p1 = p2 = pd = turns = 0;
        }
        private void ResetClick(object sender, EventArgs e)
        {
            a1.Text = a2.Text = a3.Text = a4.Text = a5.Text = a6.Text = a7.Text = a8.Text = a9.Text = "";
            turns = 0;
        }
        private void EndClick(object sender, EventArgs e)
        {
            Close();
        }
        public void WinCheck()
        {
            if (a1.Text == a2.Text && a2.Text == a3.Text)
            {
                if (a1.Text == "X")
                {
                    p1++;
                    ResetClick(null, null);
                }
                else if (a1.Text == "O") {
                    p2++;
                    ResetClick(null, null);
                }
            }
            if (a4.Text == a5.Text && a5.Text == a6.Text)
            {
                if (a4.Text == "X")
                {
                    p1++;
                    ResetClick(null, null);
                }
                else if (a4.Text == "O")
                {
                    p2++;
                    ResetClick(null, null);
                }
            }
            if (a7.Text == a8.Text && a9.Text == a3.Text)
            {
                if (a7.Text == "X")
                {
                    p1++;
                    ResetClick(null, null);
                }
                else if (a7.Text == "O")
                {
                    p2++;
                    ResetClick(null, null);
                }
            }
            if (a1.Text == a4.Text && a4.Text == a7.Text)
            {
                if (a1.Text == "X")
                {
                    p1++;
                    ResetClick(null, null);
                }
                else if (a1.Text == "O")
                {
                    p2++;
                    ResetClick(null, null);
                }
            }
            if (a2.Text == a5.Text && a5.Text == a8.Text)
            {
                if (a2.Text == "X")
                {
                    p1++;
                    ResetClick(null, null);
                }
                else if (a2.Text == "O")
                {
                    p2++;
                    ResetClick(null, null);
                }
            }
            if (a3.Text == a6.Text && a6.Text == a9.Text)
            {
                if (a3.Text == "X")
                {
                    p1++;
                    ResetClick(null, null);
                }
                else if (a3.Text == "O")
                {
                    p2++;
                    ResetClick(null, null);
                }
            }
            if (a1.Text == a5.Text && a5.Text == a9.Text)
            {
                if (a1.Text == "X")
                {
                    p1++;
                    ResetClick(null, null);
                }
                else if (a1.Text == "O")
                {
                    p2++;
                    ResetClick(null, null);
                }
            }
            if (a3.Text == a5.Text && a5.Text == a7.Text)
            {
                if (a3.Text == "X")
                {
                    p1++;
                    ResetClick(null, null);
                }
                else if (a3.Text == "O")
                {
                    p2++;
                    ResetClick(null, null);
                }
            }
        }
    }
}
