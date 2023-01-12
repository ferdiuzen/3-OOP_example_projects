using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dama_ex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Button button=new Button();  //1 buton oluşturma

            Button[,] buttons = new Button[8, 8];  // birden fazla buton oluşturma
            int left = 0;
            int top = 0;
            for (int i = 0; i <= buttons.GetUpperBound(0); i++)
            {
                // buttons[i] = new Button();  yeni butonlar oluşturulur
                // this.Controls.Add(buttons[i]);

                for (int j = 0; j <= buttons.GetUpperBound(1); j++)
                {
                    buttons[i, j] = new Button();
                    buttons[i, j].Width = 50;
                    buttons[i, j].Height = 50;
                    buttons[i, j].Left = left;

                    buttons[i, j].Top = top;
                    //this.Controls.Add(buttons[i, j]);
                    left += 50;
                    // Buton rengini değiştirmek için mod kullandık
                    if ((i + j) % 2 == 0)
                    {
                        buttons[i, j].BackColor = Color.Black;
                    }

                    this.Controls.Add(buttons[i, j]);

                }

                top += 50;
                left = 0;


            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
