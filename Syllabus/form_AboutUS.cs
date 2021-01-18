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

namespace Syllabus
{
    public partial class form_AboutUS : Form
    {
        private bool isEnglish;
        public form_AboutUS(bool isEnglish)
        {
            InitializeComponent();
            this.isEnglish = isEnglish;
            if(this.isEnglish)
            {
                linkLabel2.Text = "Help File";
            }
            else
            {
                linkLabel2.Text = "Yardım Dosyası";
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(@"https://github.com/ozkaanay/se302proj");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string sPath = Directory.GetCurrentDirectory() + @"\Resource\helpf.docx";
            System.Diagnostics.Process.Start(sPath);
        }
    }
}
