using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nodepad_farsi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            richText.Font = fontDialog1.Font;
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void انتخابفرمToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            richText.Font = fontDialog1.Font;
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        bool documentchange = false;
        string pathsaved = "";
        private void سندجدیدToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (documentchange == true)
            {

                DialogResult dialogResult = MessageBox.Show("تغیراتی در سند شما اعمال شده است آیا میخواهید تغییرات را ذخیره کنید", "ذخیره سند جدید", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

                if (dialogResult == DialogResult.Yes)
                {

                    var resultsave = saveFileDialog1.ShowDialog();

                    if (resultsave == DialogResult.OK)
                    {
                        using (StreamWriter sw = new StreamWriter(saveFileDialog1.FileName))
                        {

                            sw.Write(richText.Text);
                        }
                    }




                    richText.Text = "";

                }
                else if (dialogResult == DialogResult.No)
                {

                    richText.Text = "";
                }
            }
            else { 
                richText.Text = ""; 
            }
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void richText_TextChanged(object sender, EventArgs e)
        {
            documentchange = true;
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void mnuopendocument_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = openFileDialog1.ShowDialog();
            
            if (dialogResult == DialogResult.OK) { 
            
            string text = "";

            using(StreamReader sr = new StreamReader(openFileDialog1.FileName))
            { 
                text = sr.ReadToEnd(); 
            }
            richText.Text = text;
            }
        }

        private void بازکردنپنجرهجدیدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string nameapp = Process.GetCurrentProcess().ProcessName;
            Process.Start(nameapp);
        }

        private void ذخیرهToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(pathsaved) == false)
            {
                using (StreamWriter sw = new StreamWriter(saveFileDialog1.FileName))
                {

                    sw.Write(richText.Text);
                }

            }
            else {
                var resultsave = saveFileDialog1.ShowDialog();

                if (resultsave == DialogResult.OK)
                {
                    using (StreamWriter sw = new StreamWriter(pathsaved))
                    {

                        sw.Write(richText.Text);
                    }
                }



                pathsaved = saveFileDialog1.FileName;
               


            }
        }

        private void خروجازبرنامهToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
           

        }

        private void نواروضعیتToolStripMenuItem_Click(object sender, EventArgs e)
        {
           if (statusbar.Visible==true) { 
            
            statusbar.Visible = false;
            }
            else
            {

                statusbar.Visible = true;
            }
        }

        private void statusStrip1_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void رونوشتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(richText.Text)) {

                Clipboard.SetText(richText.Text);

            }else { 
            
            Clipboard.SetText(richText.Text);
            }
        }

        private void چسباندنToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richText.Text += Clipboard.GetText(TextDataFormat.UnicodeText).ToString();
        }

        private void حذفToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if(!string.IsNullOrEmpty(richText.SelectedText))
            {
                richText.Text = richText.Text.Replace(richText.SelectedText, "");
            }
            else
            {

                richText.Text = richText.Text.Replace(richText.Text, "");
            }

            


        }

        private void پرشToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(richText.SelectedText))
            {
                Clipboard.SetText(richText.SelectedText);
                richText.Text = richText.Text.Replace(richText.SelectedText, "");
            }
            else
            {

                Clipboard.SetText(richText.SelectedText);
                richText.Text = richText.Text.Replace(richText.Text, "");
            }


        }

        private void انتخابهمهToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richText.SelectAll();
        }

        private void درجتاریخToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //richText.Text += DateTime.Now;

            richText.Text += $"{DateTime.Now.Year}  سال   {DateTime.Now.Month} ماه  {DateTime.Now.Day} روز ";
        }

        private void چاپToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printDialog1.Document = printDocument1;
             if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

        }

        private void جستجوجایگزینیToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            frmsearch search = new frmsearch(this);

            search.ShowDialog();

        }

        private void جایگزینیToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
