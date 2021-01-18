using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using HtmlAgilityPack;
using System.Globalization;

namespace Syllabus
{
    public partial class form_Main : Form
    {
        private bool isEnglish;
        public form_Main()
        {
            InitializeComponent();
            LoadDataset();
            radioButton1.Checked = true;
        }

        public void SetLanguage(string culture)
        {
            Thread.CurrentThread.CurrentUICulture.ClearCachedData();
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(culture);

            button1.Text = Syllabus.Resource.Locatization.button1;
            button2.Text = Syllabus.Resource.Locatization.button2;
            button3.Text = Syllabus.Resource.Locatization.button3;
            button4.Text = Syllabus.Resource.Locatization.button4;

            label1.Text = Syllabus.Resource.Locatization.label1;
            label2.Text = Syllabus.Resource.Locatization.label2;
            buttun_save_main.Text = Syllabus.Resource.Locatization.buttun_save_main;

        }

        public void LoadDataset()
        {
            cSQL cS = new cSQL();
            try
            {
                dataGridView1.DataSource = cS.CallProcedure("GET_LESSON", null, false, true);
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
            finally
            {
                cS = null;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            form_Lesson fm = new form_Lesson(this.isEnglish, false, 0);
            fm.ShowDialog();
        }

        private void buttun_save_main_Click(object sender, EventArgs e)
        {
            LoadDataset();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format("Code LIKE '%{0}%'", textBox1.Text);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
           SetLanguage("");
           this.isEnglish = false;

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            SetLanguage("en-US");
            this.isEnglish = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            form_Import fm = new form_Import(this.isEnglish);
            fm.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            form_AboutUS fm = new form_AboutUS(this.isEnglish);
            fm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            form_Export fm = new form_Export(this.isEnglish);
            fm.ShowDialog();
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (dataGridView1 != null && dataGridView1.Rows.Count > 0)
            {
                if (e.Button == MouseButtons.Right)
                {
                    if (this.isEnglish)
                    {
                        ContextMenu mnu = new ContextMenu();
                        MenuItem updateLesson = new MenuItem("Update Lesson");
                        MenuItem deleteLesson = new MenuItem("Delete Lesson");
                        updateLesson.Click += new EventHandler(updateLesson_Click);
                        deleteLesson.Click += new EventHandler(deleteLesson_Click);
                        mnu.MenuItems.AddRange(new MenuItem[] { updateLesson, deleteLesson });
                        dataGridView1.ContextMenu = mnu;
                        int currentMouseOverRow = dataGridView1.HitTest(e.X, e.Y).RowIndex;
                        mnu.Show(dataGridView1, new Point(e.X, e.Y));
                    }
                    else
                    {
                        ContextMenu mnu = new ContextMenu();
                        MenuItem updateLesson = new MenuItem("Dersi Güncelle");
                        MenuItem deleteLesson = new MenuItem("Dersi Sil");
                        updateLesson.Click += new EventHandler(updateLesson_Click);
                        deleteLesson.Click += new EventHandler(deleteLesson_Click);
                        mnu.MenuItems.AddRange(new MenuItem[] { updateLesson, deleteLesson });
                        dataGridView1.ContextMenu = mnu;
                        int currentMouseOverRow = dataGridView1.HitTest(e.X, e.Y).RowIndex;
                        mnu.Show(dataGridView1, new Point(e.X, e.Y));
                    }
                }
            }
        }

        private void deleteLesson_Click(object sender, EventArgs e)
        {
            cSQL cS = new cSQL();
            List<Tuple<string, string, SqlDbType, int>> sParameters = new List<Tuple<string, string, SqlDbType, int>>();
            try
            {
                int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
                sParameters.Add(new Tuple<string, string, SqlDbType, int>("iID", selectedRow.Cells[0].Value.ToString(), SqlDbType.Int, -1));
                if (cS.CallProcedure("DELETE_LESSON", sParameters))
                {
                    LoadDataset();
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
            finally
            {
                cS = null;
                sParameters.Clear();
                sParameters = null;
            }
        }

        private void updateLesson_Click(object sender, EventArgs e)
        {
            int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
            form_Lesson fm = new form_Lesson(this.isEnglish, true, Convert.ToInt32(selectedRow.Cells["iID"].Value));
            fm.ShowDialog();
        }
    }
}
