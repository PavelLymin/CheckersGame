using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckersGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int BoardSize
        {
            get
            {
                string boardSize = "";
                string text = comboBox1.SelectedItem.ToString();
                for (int i = 0; i < text.Length; i++)
                {
                    if (text[i] != 'X')
                        boardSize += text[i];
                    else
                        break;
                }
                return Convert.ToInt32(boardSize);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var form2 = new FormGameSetings(BoardSize);
            form2.form1 = this;
            form2.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}