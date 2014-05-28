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
using System.Xml.Serialization;
using System.Xml;


namespace ImageViewer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            openFileDialog1.Filter = "JPG(*.jpg)|*.jpg|모든파일(*.*)|*.*";
            openFileDialog2.Filter = "XML(*.xml)|*.xml|모든파일(*.*)|*.*";
            saveFileDialog1.Filter = "XML(*.xml)|*.xml|모든파일(*.*)|*.*";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!(openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK))
                return;
            Image img = Image.FromFile(openFileDialog1.FileName);
            pictureBox1.Width = img.Width;
            pictureBox1.Height = img.Height;
            pictureBox1.Image = img;
            pictureBox1.Refresh(); // 다시그려주기 (확인용)
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(pictureBox1.Image); // Bitmap class
            ImageData joongil = new ImageData();
            joongil.SetSize(bmp.Width, bmp.Height);

            for(int i = 0; i < joongil.height; i++)
                for(int j = 0; j < joongil.width; j++)
                    joongil.pixel[i * joongil.width + j] = bmp.GetPixel(j,i).ToArgb();

            if (saveFileDialog1.ShowDialog() != System.Windows.Forms.DialogResult.OK)
                return;
            XmlSerializer xs = new XmlSerializer(typeof(ImageData));
            StreamWriter sw = new StreamWriter(saveFileDialog1.FileName, false);
            xs.Serialize(sw, joongil);
            sw.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // 디세리얼라이즈
            if (openFileDialog2.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                XmlSerializer xr = new XmlSerializer(typeof(ImageData));
                StreamReader sr = new StreamReader(openFileDialog2.FileName, Encoding.GetEncoding("euc-kr"));
                XmlReader rd = XmlReader.Create(sr);
                ImageData joongil = new ImageData();
                joongil = (ImageData)xr.Deserialize(rd);
                sr.Close();
                
                Bitmap bmap = new Bitmap(joongil.width, joongil.height);
                for (int i = 0; i < joongil.height; i++)
                    for (int j = 0; j < joongil.width; j++)
                        bmap.SetPixel(j, i, Color.FromArgb(joongil.pixel[i * joongil.width + j]));
                
                pictureBox1.Image = bmap;

            }

        }
    }
}
