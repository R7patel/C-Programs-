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

namespace Notepad
{
    public partial class Form1 : Form
    {
        bool saveFirst = false;
        bool txtChg = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void saveASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult ds = saveFileDialog1.ShowDialog();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void newToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            /*Form1 f2 = new Form1();
            f2.Activate();*/
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(fontDialog1.ShowDialog() ==DialogResult.OK)
            {
                richTextBox1.SelectionFont = new Font(fontDialog1.Font.Name, fontDialog1.Font.Size, fontDialog1.Font.Style);
            }
            //richTextBox1.c
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult ds = saveFileDialog1.ShowDialog();
            //richTextBox1.Text;
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            //textBox1.Text = saveFileDialog1.FileName;
            richTextBox1.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.PlainText);
            saveFirst = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            textBox1.Height = this.Height - 10;
        }

        private void richTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void richTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode//==Keys.S && e.KeyCode ==Keys.Control)
            if (e.KeyCode == Keys.S && e.Control)
            {
                if (saveFirst == true)
                {
                    richTextBox1.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.PlainText);
                    txtChg = false;
                }
                else
                {
                  if( saveFileDialog1.ShowDialog()==DialogResult.OK)
                    {
                        richTextBox1.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.PlainText);
                        txtChg = false;
                    }
                }
            }
        }

        private void fontDialog1_Apply(object sender, EventArgs e)
        {

        }

        private void wordWrapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(wordWrapToolStripMenuItem.Checked==false)
            {
                richTextBox1.WordWrap = true;
                wordWrapToolStripMenuItem.Checked = true;
            }
            else
            {

                wordWrapToolStripMenuItem.Checked = false;
                richTextBox1.WordWrap = false;
            }
           
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(txtChg)
                Close();
            else
            {
                if(MessageBox.Show("Do you want to save file befre exit?", "Save file", MessageBoxButtons.YesNo)==DialogResult.Yes)
                {
                    if (txtChg == true)
                    {
                        if (saveFirst == true)
                        {
                            richTextBox1.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.PlainText);
                            txtChg = false;
                        }
                        else
                        {
                            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                            {
                                richTextBox1.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.PlainText);
                                txtChg = false;
                            }
                        }
                    }
                    else
                    {
                        Close();
                    }  
                }
            }
        }

        private void fontColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(colorDialog1.ShowDialog()==DialogResult.OK)
            {
                richTextBox1.SelectionColor= colorDialog1.Color;
            }
        }
    }
}
