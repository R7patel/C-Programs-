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

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        DirectoryInfo di;
        int idx = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(folderBrowserDialog1.ShowDialog()==DialogResult.OK)
            {
               di = new DirectoryInfo(folderBrowserDialog1.SelectedPath);
                timer1.Start();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int j=0;
            foreach(FileInfo fi in di.GetFiles())
               {
                   if(fi.Extension==".jpg" || fi.Extension == ".png" || fi.Extension == ".jpeg")
                   {
                        if(idx==j)
                        {
                        idx++;
                            pictureBox1.Image = Image.FromFile(fi.FullName);
                        return;
                        }
                    j++;
                   }

               }
            idx = 0;
            timer1_Tick(sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1_Tick(sender, e);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(idx==0)
            {
                idx = -1;
                foreach (FileInfo fi in di.GetFiles())
                {
                    idx++;
                }

            }
            else if(idx==1)
            {
                idx = -1;
                foreach (FileInfo fi in di.GetFiles())
                {
                    idx++;
                }
                timer1_Tick(sender, e);
                timer1_Tick(sender, e);
            }
            else
            {
                idx -= 2;
            }
            timer1_Tick(sender, e);
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {

        }
    }
}
