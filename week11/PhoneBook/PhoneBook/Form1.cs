using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;// for io
using System.Xml.Serialization; // for seralization
using System.Xml;

namespace PhoneBook
{
    public partial class Form1 : Form
    {
        PhoneBook pb;
        public Form1()
        {
            InitializeComponent();
            pb = new PhoneBook();
            //pb.Add("우재우", "없음", "1학기솔로");
            //pb.Add("김중일", "031-222-4444", "교수");
            //pb.Add("홍길동", "011-123-1234", "도둑");
 
            saveFileDialog1.Filter = "저장파일(*.xml)|*.xml|전부(*.*)|*.*";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str;

            if (!(openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK))
                return;
            StreamReader sr = new StreamReader(openFileDialog1.FileName,Encoding.GetEncoding("euc-kr"));

            XmlSerializer xs = new XmlSerializer(typeof(PhoneBook));//PhoneBook을 시리얼라이즈 할거야.

            //XmlReader rd = XmlReader.Create(sr);

            pb = (PhoneBook)xs.Deserialize(sr);

            sr.Close();

            textBox1.Text = pb.getAllData();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!(saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK))
                return;

            StreamWriter sw = new StreamWriter(saveFileDialog1.FileName, false, Encoding.GetEncoding("euc-kr"));
            //sw.WriteLine(textBox1.Text);
            
            XmlSerializer xs = new XmlSerializer(typeof(PhoneBook));//PhoneBook을 시리얼라이즈 할거야.
            xs.Serialize(sw, pb); // txt파일화하기
            sw.Close();
        }
    }
}
