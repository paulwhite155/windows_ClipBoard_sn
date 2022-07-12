using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace windows_ClipBoard
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(this.textBox1.Text, TextDataFormat.UnicodeText);                      
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Boolean b;
            b = Clipboard.ContainsText();
            if (b == true)
            {
                this.textBox2.Text = Clipboard.GetText(TextDataFormat.UnicodeText);
            }
            else
            {
                MessageBox.Show("no text selected");
            }            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Clipboard.SetImage(this.pictureBox1.Image);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Boolean b;
            b = Clipboard.ContainsImage();

            if (b == true)
            {
                this.pictureBox2.Image = Clipboard.GetImage();
                this.BackgroundImage = this.pictureBox2.Image;
                this.BackgroundImageLayout = ImageLayout.Zoom;
            }
            else
            {
                MessageBox.Show("no image selected buddy");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
        }
    }
}
