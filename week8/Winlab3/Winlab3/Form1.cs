using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winlab3
{
    public partial class Form1 : Form
    {
        bool IsClick = false;
        const string MSG = "입력하세요";
        
        public Form1()
        {
            InitializeComponent();
            label1.Text = "Chatting ver 0.9";
            textBox2.Text = MSG;
            textBox1.KeyDown += new KeyEventHandler(entering);
        }

        private void entering(Object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {                                           // 아래 얇은 창 : textBox1,  위에 굵은 창 : textBox2
                if(radioButton1.Checked)
                {
                    label1.Text = "차용빈";
                    if (textBox2.Text == MSG)
                    {
                        textBox2.Text = "차용빈 : " + textBox1.Text;
                        //textBox1.Text = "";
                    }
                    else {
                        textBox2.Text = textBox2.Text + "\r\n" + "차용빈 : " + textBox1.Text;
                        //textBox1.Text = "";
                    }
                    textBox1.Text = "";
                }
                
                else
                {
                    label1.Text = "심심이";
                    if(textBox2.Text == MSG)
                    {
                        textBox2.Text = "심심이 : " + textBox1.Text;
                        textBox1.Text = "";
                    }
                    else
                    {
                        textBox2.Text = textBox2.Text + "\r\n" + "심심이 : " + textBox1.Text;
                        textBox1.Text = "";
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            textBox2.Text = MSG;
        }
    }
}
