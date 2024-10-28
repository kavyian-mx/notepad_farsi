using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Tracing;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nodepad_farsi
{
    public partial class frmsearch : Form
    {
        Form1 form1;
        public frmsearch(Form1 frm )
        {
            form1 = frm;
            
            InitializeComponent();
        }
        List<searchresult> searchresults = new List<searchresult>();
        int showr = 0;

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void frmsearch_Load(object sender, EventArgs e)
        {

        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            string searchkay = textsearch.Text;
            
            form1.richText.SelectionBackColor = Color.White;
            
            
            if (searchresults.Count() > 0)
            {
                _showr();
                return;
            }
            else
            {
                searchresults = new List<searchresult>();
            }

            var searchoption = RichTextBoxFinds.None;
            if (rdbwholeword.Checked)
            {

                searchoption = RichTextBoxFinds.WholeWord;

            }
            int startindex = 0;
            while (startindex > form1.richText.TextLength )
            { 
                int wordstartindex = form1.richText.Find(searchkay, startindex,searchoption);
                if (wordstartindex != -1)
                {



                    searchresults.Add(new searchresult
                    {
                        selectionstart = wordstartindex,
                        selectionlength = searchkay.Length,
                        searchkey = searchkay

                    }); ;


                }else
                    break;
                startindex = wordstartindex + searchkay.Length;


            
            }
            _showr();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

     private void _showr()


        {
            var selected = searchresults[showr];
            form1.richText.SelectionStart = selected.selectionstart;
            form1.richText.SelectionLength = selected.selectionlength;
            form1.richText.SelectionColor = Color.Green;

            showr++;
            if(showr == searchresults.Count)
            {
                showr = 0;
                searchresults = new List<searchresult>();
            }
        }

        private void frmsearch_FormClosing(object sender, FormClosingEventArgs e)
        {
            form1.richText.SelectionBackColor = Color.White;
        }
    }

    public class searchresult
    {
        public int selectionstart { get; set; }
        public int selectionlength { get; set; }
        public string searchkey { get; set; }
    }
}



