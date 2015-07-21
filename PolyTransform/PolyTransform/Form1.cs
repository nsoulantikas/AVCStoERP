using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeTransform
{
    public partial class AVCStoERP : Form
    {
        public AVCStoERP()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            inENC.Checked = true;
            sgENC.Checked = true;
        }
        private void button1_Click(object sender, EventArgs e)
        {

            string path = "./file.txt";
            string message = String.Join(Environment.NewLine, File.ReadLines(path));
            rich.Text = message;
        }
        private void button2_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFile1 = new OpenFileDialog();
            openFile1.Filter = "Text Files|*.txt";

            // If the user selected a file, load its contents into the RichTextBox. 
            if (openFile1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                rich.LoadFile(openFile1.FileName, RichTextBoxStreamType.PlainText);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            string[] lines = rich.Lines;
            for (int i = 0; i < lines.Length; i++)
            {
                if (inENC.Checked)
                {
                    if (lines[i].Contains("IN"))
                    {
                        lines[i] = "AV" + lines[i] + "A";
                    }
                    else
                    {
                        if (sgENC.Checked)
                        {
                            if (lines[i].Contains("SG"))
                            {
                                lines[i] = "AV" + lines[i] + "A";
                            }
                            else
                            {
                                lines[i] = "AV" + lines[i] + "D";
                            }
                        }
                        else
                        {
                            lines[i] = "AV" + lines[i] + "D";
                        }
                    }
                }
                else if (sgENC.Checked)
                    if (lines[i].Contains("SG"))
                    {
                        lines[i] = "AV" + lines[i] + "A";
                    }
                    else
                    {
                        lines[i] = "AV" + lines[i] + "D";
                    }

                else
                {
                    lines[i] = "AV" + lines[i] + "D";
                }
            }
            rich.Lines = lines;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            {
                string[] lines = rich.Lines;
                for (int i = 0; i < lines.Length; i++)
                {
                    if (inENC.Checked)
                    {
                        if (lines[i].Contains("IN"))
                        {
                            lines[i] = "AV" + lines[i] + "A";
                        }
                        else
                        {
                            if (sgENC.Checked)
                            {
                                if (lines[i].Contains("SG"))
                                {
                                    lines[i] = "AV" + lines[i] + "A";
                                }
                                else
                                {
                                    lines[i] = "AV" + lines[i] + "C";
                                }
                            }
                            else
                            {
                                lines[i] = "AV" + lines[i] + "C";
                            }
                        }
                    }
                    else if (sgENC.Checked)
                        if (lines[i].Contains("SG"))
                        {
                            lines[i] = "AV" + lines[i] + "A";
                        }
                        else
                        {
                            lines[i] = "AV" + lines[i] + "C";
                        }

                    else
                    {
                        lines[i] = "AV" + lines[i] + "C";
                    }
                }
                rich.Lines = lines;
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            {
                string[] lines = rich.Lines;
                for (int i = 0; i < lines.Length; i++)
                {
                    if (inENC.Checked)
                    {
                        if (lines[i].Contains("IN"))
                        {
                            lines[i] = "AV" + lines[i] + "A";
                        }
                        else
                        {
                            if (sgENC.Checked)
                            {
                                if (lines[i].Contains("SG"))
                                {
                                    lines[i] = "AV" + lines[i] + "A";
                                }
                                else
                                {
                                    lines[i] = "AV" + lines[i] + "B";
                                }
                            }
                            else
                            {
                                lines[i] = "AV" + lines[i] + "B";
                            }
                        }
                    }
                    else if (sgENC.Checked)
                        if (lines[i].Contains("SG"))
                        {
                            lines[i] = "AV" + lines[i] + "A";
                        }
                        else
                        {
                            lines[i] = "AV" + lines[i] + "B";
                        }

                    else
                    {
                        lines[i] = "AV" + lines[i] + "B";
                    }
                }
                rich.Lines = lines;
            }
        }
        private void button6_Click(object sender, EventArgs e)
        {
            {
                string[] lines = rich.Lines;
                for (int i = 0; i < lines.Length; i++)
                {
                    if (inENC.Checked)
                    {
                        if (lines[i].Contains("IN"))
                        {
                            lines[i] = "AV" + lines[i] + "A";
                        }
                        else
                        {
                            if (sgENC.Checked)
                            {
                                if (lines[i].Contains("SG"))
                                {
                                    lines[i] = "AV" + lines[i] + "A";
                                }
                                else
                                {
                                    lines[i] = "AV" + lines[i] + "A";
                                }
                            }
                            else
                            {
                                lines[i] = "AV" + lines[i] + "A";
                            }
                        }
                    }
                    else if (sgENC.Checked)
                        if (lines[i].Contains("SG"))
                        {
                            lines[i] = "AV" + lines[i] + "A";
                        }
                        else
                        {
                            lines[i] = "AV" + lines[i] + "A";
                        }

                    else
                    {
                        lines[i] = "AV" + lines[i] + "A";
                    }
                }
                rich.Lines = lines;
            }
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            rich.Text = "";
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Transformation of AVCS codes to ERP codes\nVersion 1.0\n\n\nIdea & Development by:\nNikolaos Soulantikas\nn.soulantikas@hotmail.com", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void helpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1. Create a simple text file, with the AVCS codes row by row\n2. Click to Load the Text file\n3. Choose the duration of the AVCS\n4. Choose whether the Indian or the Singapore charts have an annual duration", "Help", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }
    }
}

