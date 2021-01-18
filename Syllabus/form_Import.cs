using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Syllabus
{
    public partial class form_Import : Form
    {
        private bool isEnglish;
        public form_Import(bool isEnglish)
        {
            InitializeComponent();
            if (isEnglish)
                SetLanguage("en-US");
            else
                SetLanguage("");

            this.isEnglish = isEnglish;
        }

        public void SetLanguage(string culture)
        {
            Thread.CurrentThread.CurrentUICulture.ClearCachedData();
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(culture);

            button_import.Text = Syllabus.Resource.Locatization.button_import;
            label_Lesson.Text = Syllabus.Resource.Locatization.label_Lesson;
            label_Code.Text = Syllabus.Resource.Locatization.label_Code;
        }

        private void button_import_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) ||
                string.IsNullOrEmpty(textBox2.Text) ||
                string.IsNullOrEmpty(textBox3.Text))
                return;

            cSQL cS = new cSQL();
            List<Tuple<string, string, SqlDbType, int>> sParameters = new List<Tuple<string, string, SqlDbType, int>>();
            try
            {
                Uri url = new Uri(textBox1.Text);
                HTML html = new HTML(url);
                List<string> data = html.GetData();

                sParameters.Add(new Tuple<string, string, SqlDbType, int>("sLessonName", textBox2.Text.ToString(), SqlDbType.VarChar, -1));
                sParameters.Add(new Tuple<string, string, SqlDbType, int>("Code", textBox3.Text.ToString(), SqlDbType.VarChar, -1));

                sParameters.Add(new Tuple<string, string, SqlDbType, int>("Semester", data[0], SqlDbType.VarChar, -1));
                sParameters.Add(new Tuple<string, string, SqlDbType, int>("Theory", data[1], SqlDbType.VarChar, -1));
                sParameters.Add(new Tuple<string, string, SqlDbType, int>("Application", data[2], SqlDbType.VarChar, -1));
                sParameters.Add(new Tuple<string, string, SqlDbType, int>("Credits", data[3], SqlDbType.VarChar, -1));
                sParameters.Add(new Tuple<string, string, SqlDbType, int>("ECTS", data[4], SqlDbType.VarChar, -1));
                sParameters.Add(new Tuple<string, string, SqlDbType, int>("Prerequisites", data[5], SqlDbType.VarChar, -1));
                sParameters.Add(new Tuple<string, string, SqlDbType, int>("Language", data[6], SqlDbType.VarChar, -1));
                sParameters.Add(new Tuple<string, string, SqlDbType, int>("Type", data[7], SqlDbType.VarChar, -1));
                sParameters.Add(new Tuple<string, string, SqlDbType, int>("Level", data[8], SqlDbType.VarChar, -1));
                sParameters.Add(new Tuple<string, string, SqlDbType, int>("Coordinator", data[9], SqlDbType.VarChar, -1));

                sParameters.Add(new Tuple<string, string, SqlDbType, int>("Lecturer", "-", SqlDbType.VarChar, -1));
                sParameters.Add(new Tuple<string, string, SqlDbType, int>("Assistant", "-", SqlDbType.VarChar, -1));
                sParameters.Add(new Tuple<string, string, SqlDbType, int>("Objectives", "-", SqlDbType.VarChar, -1));
                sParameters.Add(new Tuple<string, string, SqlDbType, int>("Outcomes", "-", SqlDbType.VarChar, -1));
                sParameters.Add(new Tuple<string, string, SqlDbType, int>("Description", "-", SqlDbType.VarChar, -1));

                if (this.isEnglish)
                {
                    DialogResult dialog = new DialogResult();
                    dialog = MessageBox.Show("Do you approve course enrollment?", "CONFIRMATION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialog == DialogResult.Yes)
                    {
                        if (cS.CallProcedure("ADD_LESSON_FROM_HTML", sParameters, true) == 1)
                        {
                            MessageBox.Show("Course registration successfully created", "SUCCES", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Error encountered while creating lecture record", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }

                else
                {
                    DialogResult dialog = new DialogResult();
                    dialog = MessageBox.Show("Ders kaydını onaylıyor musunuz ?", "ONAY", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialog == DialogResult.Yes)
                    {
                        if (cS.CallProcedure("ADD_LESSON_FROM_HTML", sParameters, true) == 1)
                        {
                            MessageBox.Show("Ders kaydı başarıyla oluşturuldu", "BAŞARILI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Ders kaydı oluştururken hata ile karşılaşıldı", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch(Exception ee)
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
    }
}
