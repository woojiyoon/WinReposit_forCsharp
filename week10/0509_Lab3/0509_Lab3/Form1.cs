using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace _0509_Lab3
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "OPEN";
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string name = openFileDialog1.FileName;
                toolStripStatusLabel1.Text = name;
                //Fileread.ReadFile(str);
                string result = FileRead(name);
                textBox1.Text = result;
            }
        }

        private string FileRead(string filename)
        {
            string str;
            string str2="";
            //string zzz = "Not read yet";
            StreamReader r = new StreamReader(filename, Encoding.GetEncoding("euc-kr")); // for korean
            //
            

            while (!r.EndOfStream)
            {
                str = r.ReadLine();
                //Console.WriteLine("{0} 내용 : " + str);
                str2 += str;
                str2 += "\r\n";
            }

            r.Close();

            return str2;
        }

        private void writeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Write";
            if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string str = saveFileDialog1.FileName;
                toolStripStatusLabel1.Text = str;
                //StreamWriter r = new StreamWriter(str, false, Encoding.GetEncoding("euc-kr"));
                WriteFile(str,true);
                //r.Close();
            }
        }

        public void WriteFile(string fullfilename, bool append)
        {
            StreamWriter sw = new StreamWriter(fullfilename, append, Encoding.GetEncoding("euc-kr"));
            sw.WriteLine(textBox1.Text);
            sw.Close();
        }

    }
}
