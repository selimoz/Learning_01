using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChessBoard
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Top = 0;
            Left = 0;
            Button[,] btn = new Button[8,8];

            for (int i = 0; i <= btn.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= btn.GetUpperBound(0); j++)
                {
                    if ((i+j)%2 == 0 )
                    {            
                        btn[i, j] = new Button();
                        btn[i, j].Width = 50;
                        btn[i, j].Height = 50;
                        btn[i, j].Left = Left;
                        btn[i, j].Top = Top;
                        btn[i, j].BackColor = Color.Black;
                        Left += 50;
                        this.Controls.Add(btn[i, j]);
                    }
                    else
                    {
                        btn[i, j] = new Button();
                        btn[i, j].Width = 50;
                        btn[i, j].Height = 50;
                        btn[i, j].Left = Left;
                        btn[i, j].Top = Top;
                        btn[i, j].BackColor = Color.White;
                        Left += 50;
                        this.Controls.Add(btn[i, j]);
                    }
                }
                Left = 0;
                Top += 50;
            }
        }
    }
}
