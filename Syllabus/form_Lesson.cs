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
    public partial class form_Lesson : Form
    {
        private bool isEnglish;
        private bool isUpdate;
        private int iID;
        public form_Lesson(bool isEnglish, bool isUpdate, int iID)
        {
            InitializeComponent();
            this.isEnglish = isEnglish;
            this.isUpdate = isUpdate;
            this.iID = iID;

            if (this.isEnglish)
                SetLanguage("en-US");
            else
                SetLanguage("");

            if (isUpdate)
            {
                if (this.isEnglish)
                    buttun_save.Text = "Update";
                else
                    buttun_save.Text = "Güncelle";
                FieldBox(iID);
            }
        }

        public void FieldBox(int iID)
        {
            cSQL cS = new cSQL();
            DataTable dt = new DataTable();
            List<Tuple<string, string, SqlDbType, int>> sParameters = new List<Tuple<string, string, SqlDbType, int>>();
            try
            {
                sParameters.Add(new Tuple<string, string, SqlDbType, int>("iID", iID.ToString(), SqlDbType.Int, -1));
                dt = cS.CallProcedure("GET_LESSON_FOR_UPDATE", sParameters, false, true);

                textBox1.Text = dt.Rows[0]["sLessonName"].ToString();
                textBox7.Text = dt.Rows[0]["Code"].ToString();
                textBox5.Text = dt.Rows[0]["Semester"].ToString();
                textBox6.Text = dt.Rows[0]["Theory"].ToString();
                textBox4.Text = dt.Rows[0]["Application"].ToString();
                textBox2.Text = dt.Rows[0]["Credits"].ToString();
                textBox3.Text = dt.Rows[0]["ECTS"].ToString();
                textBox9.Text = dt.Rows[0]["Prerequisites"].ToString();
                textBox8.Text = dt.Rows[0]["Language"].ToString();
                textBox10.Text = dt.Rows[0]["Type"].ToString();
                textBox12.Text = dt.Rows[0]["Level"].ToString();
                textBox11.Text = dt.Rows[0]["Coordinator"].ToString();
                textBox13.Text = dt.Rows[0]["Lecturer"].ToString();
                textBox14.Text = dt.Rows[0]["Assistant"].ToString();
                richTextBox1.Text = dt.Rows[0]["Objectives"].ToString();
                richTextBox2.Text = dt.Rows[0]["Outcomes"].ToString();
                richTextBox3.Text = dt.Rows[0]["Description"].ToString();
                string temp = string.Empty;

                temp = dt.Rows[0]["CoreCoursesChecked"].ToString();
                if (string.Equals(temp, CoreCourses.Text))
                    checkBox1.Checked = true;
                if (string.Equals(temp, MajorAreaCourses.Text))
                    checkBox2.Checked = true;
                if (string.Equals(temp, SupportiveCourses.Text))
                    checkBox3.Checked = true;
                if (string.Equals(temp, MediaandManagementSkillsCourses.Text))
                    checkBox4.Checked = true;
                if (string.Equals(temp, TransferableSkillCourses.Text))
                    checkBox5.Checked = true;

                textBox15.Text = dt.Rows[0]["week_1_Related"].ToString();
                textBox31.Text = dt.Rows[0]["week_1_Subjects"].ToString();
                textBox19.Text = dt.Rows[0]["week_2_Subjects"].ToString();
                textBox32.Text = dt.Rows[0]["week_2_Related"].ToString();
                textBox17.Text = dt.Rows[0]["week_3_Subjects"].ToString();
                textBox33.Text = dt.Rows[0]["week_3_Related"].ToString();
                textBox16.Text = dt.Rows[0]["week_4_Subjects"].ToString();
                textBox34.Text = dt.Rows[0]["week_4_Related"].ToString();
                textBox20.Text = dt.Rows[0]["week_5_Subjects"].ToString();
                textBox35.Text = dt.Rows[0]["week_5_Related"].ToString();
                textBox21.Text = dt.Rows[0]["week_6_Subjects"].ToString();
                textBox36.Text = dt.Rows[0]["week_6_Related"].ToString();
                textBox24.Text = dt.Rows[0]["week_7_Subjects"].ToString();
                textBox37.Text = dt.Rows[0]["week_7_Related"].ToString();
                textBox25.Text = dt.Rows[0]["week_8_Subjects"].ToString();
                textBox38.Text = dt.Rows[0]["week_8_Related"].ToString();
                textBox22.Text = dt.Rows[0]["week_9_Subjects"].ToString();
                textBox39.Text = dt.Rows[0]["week_9_Related"].ToString();
                textBox18.Text = dt.Rows[0]["week_10_Subjects"].ToString();
                textBox40.Text = dt.Rows[0]["week_10_Related"].ToString();
                textBox23.Text = dt.Rows[0]["week_11_Subjects"].ToString();
                textBox41.Text = dt.Rows[0]["week_11_Related"].ToString();
                textBox26.Text = dt.Rows[0]["week_12_Subjects"].ToString();
                textBox42.Text = dt.Rows[0]["week_12_Related"].ToString();
                textBox27.Text = dt.Rows[0]["week_13_Subjects"].ToString();
                textBox43.Text = dt.Rows[0]["week_13_Related"].ToString();
                textBox30.Text = dt.Rows[0]["week_14_Subjects"].ToString();
                textBox44.Text = dt.Rows[0]["week_14_Related"].ToString();
                textBox28.Text = dt.Rows[0]["week_15_Subjects"].ToString();
                textBox45.Text = dt.Rows[0]["week_15_Related"].ToString();
                textBox29.Text = dt.Rows[0]["week_16_Subjects"].ToString();
                textBox46.Text = dt.Rows[0]["week_16_Related"].ToString();

                richTextBox6.Text = dt.Rows[0]["Textbooks"].ToString();
                richTextBox5.Text = dt.Rows[0]["Materials"].ToString();

                textBox78.Text = dt.Rows[0]["Participation_Number"].ToString();
                textBox62.Text = dt.Rows[0]["Participation_Weight"].ToString();
                textBox74.Text = dt.Rows[0]["Laboratory_Applicationxtbooks_Number"].ToString();
                textBox61.Text = dt.Rows[0]["Laboratory_Applicationxtbooks_Weight"].ToString();
                textBox76.Text = dt.Rows[0]["FieldWork_Number"].ToString();
                textBox60.Text = dt.Rows[0]["FieldWork_Weight"].ToString();
                textBox77.Text = dt.Rows[0]["Quizzes_StudioCritiques_Number"].ToString();
                textBox59.Text = dt.Rows[0]["Quizzes_StudioCritiques_Weight"].ToString();
                textBox73.Text = dt.Rows[0]["Homework_Assignments_Number"].ToString();
                textBox58.Text = dt.Rows[0]["Homework_Assignments_Weight"].ToString();
                textBox72.Text = dt.Rows[0]["Presentation_Jury_Number"].ToString();
                textBox57.Text = dt.Rows[0]["Presentation_Jury_Weight"].ToString();
                textBox69.Text = dt.Rows[0]["Project_Number"].ToString();
                textBox56.Text = dt.Rows[0]["Project_Weight"].ToString();
                textBox68.Text = dt.Rows[0]["Seminar_Workshop_Number"].ToString();
                textBox55.Text = dt.Rows[0]["Seminar_Workshop_Weight"].ToString();
                textBox71.Text = dt.Rows[0]["OralExams_Number"].ToString();
                textBox54.Text = dt.Rows[0]["OralExams_Weight"].ToString();
                textBox75.Text = dt.Rows[0]["Midterm_Number"].ToString();
                textBox53.Text = dt.Rows[0]["Midterm_Weight"].ToString();
                textBox70.Text = dt.Rows[0]["FinalExam_Number"].ToString();
                textBox52.Text = dt.Rows[0]["FinalExam_Weight"].ToString();

                textBox90.Text = dt.Rows[0]["TheoreticalCourseHours_Num"].ToString();
                textBox79.Text = dt.Rows[0]["TheoreticalCourseHours_Duration"].ToString();
                textBox93.Text = dt.Rows[0]["TheoreticalCourseHours_Workload"].ToString();
                textBox86.Text = dt.Rows[0]["Laboratory_Application_Hours_Number"].ToString();
                textBox67.Text = dt.Rows[0]["Laboratory_Application_Hour_Duration"].ToString();
                textBox94.Text = dt.Rows[0]["Laboratory_Application_Hours_Workload"].ToString();
                textBox88.Text = dt.Rows[0]["Study_Hours_Out_of_Class_Number"].ToString();
                textBox66.Text = dt.Rows[0]["Study_Hours_Out_of_Class_Duration"].ToString();
                textBox95.Text = dt.Rows[0]["Study_Hours_Out_of_Class_Workload"].ToString();
                textBox89.Text = dt.Rows[0]["Field_Work_Number"].ToString();
                textBox65.Text = dt.Rows[0]["Field_Work_Duration"].ToString();
                textBox96.Text = dt.Rows[0]["Field_Work_Workload"].ToString();
                textBox85.Text = dt.Rows[0]["Quizzes_Studio_Critiques_Number"].ToString();
                textBox64.Text = dt.Rows[0]["Quizzes_Studio_Critiques_Duration"].ToString();
                textBox97.Text = dt.Rows[0]["Quizzes_Studio_Critiques_Workload"].ToString();
                textBox84.Text = dt.Rows[0]["Homework_Assignmentss_Number"].ToString();
                textBox63.Text = dt.Rows[0]["Homework_Assignmentss_Duration"].ToString();
                textBox98.Text = dt.Rows[0]["Homework_Assignmentss_Workload"].ToString();
                textBox81.Text = dt.Rows[0]["Presentation_Juryy_Number"].ToString();
                textBox51.Text = dt.Rows[0]["Presentation_Juryy_Duration"].ToString();
                textBox99.Text = dt.Rows[0]["Presentation_Juryy_Workload"].ToString();
                textBox80.Text = dt.Rows[0]["Projectt_Number"].ToString();
                textBox50.Text = dt.Rows[0]["Projectt_Duration"].ToString();
                textBox100.Text = dt.Rows[0]["Projectt_Workload"].ToString();
                textBox83.Text = dt.Rows[0]["Seminar_Workshopp_Number"].ToString();
                textBox49.Text = dt.Rows[0]["Seminar_Workshopp_Duration"].ToString();
                textBox101.Text = dt.Rows[0]["Seminar_Workshopp_Workload"].ToString();
                textBox87.Text = dt.Rows[0]["Oral_Exam_Number"].ToString();
                textBox48.Text = dt.Rows[0]["Oral_Exam_Duration"].ToString();
                textBox102.Text = dt.Rows[0]["Oral_Exam_Workload"].ToString();
                textBox82.Text = dt.Rows[0]["Midtermss_Number"].ToString();
                textBox47.Text = dt.Rows[0]["Midtermss_Duration"].ToString();
                textBox103.Text = dt.Rows[0]["Midtermss_Workload"].ToString();
                textBox91.Text = dt.Rows[0]["Final_Exam_Number"].ToString();
                textBox92.Text = dt.Rows[0]["Final_Exam_Duration"].ToString();
                textBox104.Text = dt.Rows[0]["Final_Exam_Workload"].ToString();


                textBox105.Text = dt.Rows[0]["Outcomes_1_Text"].ToString();
                numericUpDown1.Value = Convert.ToInt32(dt.Rows[0]["Outcomes_1_Value"]);
                textBox106.Text = dt.Rows[0]["Outcomes_2_Text"].ToString();
                numericUpDown2.Value = Convert.ToInt32(dt.Rows[0]["Outcomes_2_Value"]);
                textBox107.Text = dt.Rows[0]["Outcomes_3_Text"].ToString();
                numericUpDown3.Value = Convert.ToInt32(dt.Rows[0]["Outcomes_3_Value"]);
                textBox108.Text = dt.Rows[0]["Outcomes_4_Text"].ToString();
                numericUpDown4.Value = Convert.ToInt32(dt.Rows[0]["Outcomes_4_Value"]);
                textBox109.Text = dt.Rows[0]["Outcomes_5_Text"].ToString();
                numericUpDown5.Value = Convert.ToInt32(dt.Rows[0]["Outcomes_5_Value"]);
                textBox110.Text = dt.Rows[0]["Outcomes_6_Text"].ToString();
                numericUpDown6.Value = Convert.ToInt32(dt.Rows[0]["Outcomes_6_Value"]);
                textBox111.Text = dt.Rows[0]["Outcomes_7_Text"].ToString();
                numericUpDown7.Value = Convert.ToInt32(dt.Rows[0]["Outcomes_7_Value"]);
                textBox112.Text = dt.Rows[0]["Outcomes_8_Text"].ToString();
                numericUpDown8.Value = Convert.ToInt32(dt.Rows[0]["Outcomes_8_Value"]);
                textBox113.Text = dt.Rows[0]["Outcomes_9_Text"].ToString();
                numericUpDown9.Value = Convert.ToInt32(dt.Rows[0]["Outcomes_9_Value"]);
                textBox114.Text = dt.Rows[0]["Outcomes_10_Text"].ToString();
                numericUpDown10.Value = Convert.ToInt32(dt.Rows[0]["Outcomes_10_Value"]);
                textBox115.Text = dt.Rows[0]["Outcomes_11_Text"].ToString();
                numericUpDown11.Value = Convert.ToInt32(dt.Rows[0]["Outcomes_11_Value"]);
                textBox116.Text = dt.Rows[0]["Outcomes_12_Text"].ToString();
                numericUpDown12.Value = Convert.ToInt32(dt.Rows[0]["Outcomes_12_Value"]);
                textBox117.Text = dt.Rows[0]["Outcomes_13_Text"].ToString();
                numericUpDown13.Value = Convert.ToInt32(dt.Rows[0]["Outcomes_13_Value"]);
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
            finally
            {
                cS = null;
                dt.Dispose();
                sParameters.Clear();
                sParameters = null;
            }
        }

        public void SetLanguage(string culture)
        {
            Thread.CurrentThread.CurrentUICulture.ClearCachedData();
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(culture);

            sLessonName.Text = Syllabus.Resource.Locatization.sLessonName;

            Code.Text = Syllabus.Resource.Locatization.Code;
            Semester.Text = Syllabus.Resource.Locatization.Semester;
            Theory.Text = Syllabus.Resource.Locatization.Theory;
            Application.Text = Syllabus.Resource.Locatization.Application;
            Credits.Text = Syllabus.Resource.Locatization.Credits;
            ECTS.Text = Syllabus.Resource.Locatization.ECTS;

            Prerequisites.Text = Syllabus.Resource.Locatization.Prerequisites;
            Language.Text = Syllabus.Resource.Locatization.Language;
            Type.Text = Syllabus.Resource.Locatization.Type;
            Level.Text = Syllabus.Resource.Locatization.Level;
            Coordinator.Text = Syllabus.Resource.Locatization.Coordinator;
            Lecturer.Text = Syllabus.Resource.Locatization.Lecturer;
            Assistant.Text = Syllabus.Resource.Locatization.Assistant;

            Objectives.Text = Syllabus.Resource.Locatization.Objectives;
            Outcomes.Text = Syllabus.Resource.Locatization.Outcomes;
            Description.Text = Syllabus.Resource.Locatization.Description;

            CourseCategory.Text = Syllabus.Resource.Locatization.CourseCategory;
            CoreCourses.Text = Syllabus.Resource.Locatization.CoreCourses;
            MajorAreaCourses.Text = Syllabus.Resource.Locatization.MajorAreaCourses;
            SupportiveCourses.Text = Syllabus.Resource.Locatization.SupportiveCourses;
            MediaandManagementSkillsCourses.Text = Syllabus.Resource.Locatization.MediaandManagementSkillsCourses;
            TransferableSkillCourses.Text = Syllabus.Resource.Locatization.TransferableSkillCourses;

            Week.Text = Syllabus.Resource.Locatization.Week;
            Subjects.Text = Syllabus.Resource.Locatization.Subjects;
            RelatedPreparation.Text = Syllabus.Resource.Locatization.RelatedPreparation;

            Textbooks.Text = Syllabus.Resource.Locatization.Textbooks;
            Materials.Text = Syllabus.Resource.Locatization.Materials;

            SemesterActivities.Text = Syllabus.Resource.Locatization.SemesterActivities;
            Number.Text = Syllabus.Resource.Locatization.Number;
            Weigthing.Text = Syllabus.Resource.Locatization.Weigthing;
            Participation.Text = Syllabus.Resource.Locatization.Participation;
            Laboratory_Applicationxtbooks.Text = Syllabus.Resource.Locatization.Laboratory_Applicationxtbooks;
            FieldWork.Text = Syllabus.Resource.Locatization.FieldWork;
            Quizzes_StudioCritiques.Text = Syllabus.Resource.Locatization.Quizzes_StudioCritiques;
            Homework_Assignments.Text = Syllabus.Resource.Locatization.Homework_Assignments;
            Presentation_Jury.Text = Syllabus.Resource.Locatization.Presentation_Jury;
            Project.Text = Syllabus.Resource.Locatization.Project;
            Seminar_Workshop.Text = Syllabus.Resource.Locatization.Seminar_Workshop;
            OralExams.Text = Syllabus.Resource.Locatization.OralExams;
            Midterm.Text = Syllabus.Resource.Locatization.Midterm;
            FinalExam.Text = Syllabus.Resource.Locatization.FinalExam;


            SemesterActivitiess.Text = Syllabus.Resource.Locatization.SemesterActivitiess;
            Numberr.Text = Syllabus.Resource.Locatization.Numberr;
            Duration.Text = Syllabus.Resource.Locatization.Duration;
            Workload.Text = Syllabus.Resource.Locatization.Workload;
            TheoreticalCourseHours.Text = Syllabus.Resource.Locatization.TheoreticalCourseHours;
            Laboratory_Application_Hours.Text = Syllabus.Resource.Locatization.Laboratory_Application_Hours;
            Study_Hours_Out_of_Class.Text = Syllabus.Resource.Locatization.Study_Hours_Out_of_Class;
            Field_Work.Text = Syllabus.Resource.Locatization.Field_Work;
            Quizzes_Studio_Critiques.Text = Syllabus.Resource.Locatization.Quizzes_Studio_Critiques;
            Homework_Assignmentss.Text = Syllabus.Resource.Locatization.Homework_Assignmentss;
            Presentation_Juryy.Text = Syllabus.Resource.Locatization.Presentation_Juryy;
            Projectt.Text = Syllabus.Resource.Locatization.Projectt;
            Seminar_Workshopp.Text = Syllabus.Resource.Locatization.Seminar_Workshopp;
            Oral_Exam.Text = Syllabus.Resource.Locatization.Oral_Exam;
            Midtermss.Text = Syllabus.Resource.Locatization.Midtermss;
            Final_Exam.Text = Syllabus.Resource.Locatization.Final_Exam;

            Program_Competencies_Outcomes.Text = Syllabus.Resource.Locatization.Program_Competencies_Outcomes;
            Contribution_Level.Text = Syllabus.Resource.Locatization.Contribution_Level;

            buttun_save.Text = Syllabus.Resource.Locatization.buttun_save;
        }

        private void buttun_save_Click(object sender, EventArgs e)
        {
            cSQL cS = new cSQL();
            List<Tuple<string, string, SqlDbType, int>> sParameters = new List<Tuple<string, string, SqlDbType, int>>();
            try
            {
                sParameters.Add(new Tuple<string, string, SqlDbType, int>("sLessonName", textBox1.Text.ToString(), SqlDbType.VarChar, -1));
                sParameters.Add(new Tuple<string, string, SqlDbType, int>("Code", textBox7.Text.ToString(), SqlDbType.VarChar, -1));
                sParameters.Add(new Tuple<string, string, SqlDbType, int>("Semester", textBox5.Text.ToString(), SqlDbType.VarChar, -1));
                sParameters.Add(new Tuple<string, string, SqlDbType, int>("Theory", textBox6.Text.ToString(), SqlDbType.VarChar, -1));
                sParameters.Add(new Tuple<string, string, SqlDbType, int>("Application", textBox4.Text.ToString(), SqlDbType.VarChar, -1));
                sParameters.Add(new Tuple<string, string, SqlDbType, int>("Credits", textBox2.Text.ToString(), SqlDbType.VarChar, -1));
                sParameters.Add(new Tuple<string, string, SqlDbType, int>("ECTS", textBox3.Text.ToString(), SqlDbType.VarChar, -1));

                sParameters.Add(new Tuple<string, string, SqlDbType, int>("Prerequisites", textBox9.Text.ToString(), SqlDbType.VarChar, -1));
                sParameters.Add(new Tuple<string, string, SqlDbType, int>("Language", textBox8.Text.ToString(), SqlDbType.VarChar, -1));
                sParameters.Add(new Tuple<string, string, SqlDbType, int>("Type", textBox10.Text.ToString(), SqlDbType.VarChar, -1));
                sParameters.Add(new Tuple<string, string, SqlDbType, int>("Level", textBox12.Text.ToString(), SqlDbType.VarChar, -1));
                sParameters.Add(new Tuple<string, string, SqlDbType, int>("Coordinator", textBox11.Text.ToString(), SqlDbType.VarChar, -1));
                sParameters.Add(new Tuple<string, string, SqlDbType, int>("Lecturer", textBox13.Text.ToString(), SqlDbType.VarChar, -1));
                sParameters.Add(new Tuple<string, string, SqlDbType, int>("Assistant", textBox14.Text.ToString(), SqlDbType.VarChar, -1));
                sParameters.Add(new Tuple<string, string, SqlDbType, int>("Objectives", richTextBox1.Text.ToString(), SqlDbType.VarChar, -1));
                sParameters.Add(new Tuple<string, string, SqlDbType, int>("Outcomes", richTextBox2.Text.ToString(), SqlDbType.VarChar, -1));
                sParameters.Add(new Tuple<string, string, SqlDbType, int>("Description", richTextBox3.Text.ToString(), SqlDbType.VarChar, -1));

                string temp = string.Empty;
                if (checkBox1.Checked)
                    temp = CoreCourses.Text;

                if (checkBox2.Checked)
                    temp = MajorAreaCourses.Text;

                if (checkBox3.Checked)
                    temp = SupportiveCourses.Text;

                if (checkBox4.Checked)
                    temp = MediaandManagementSkillsCourses.Text;

                if (checkBox5.Checked)
                    temp = TransferableSkillCourses.Text;

                sParameters.Add(new Tuple<string, string, SqlDbType, int>("CoreCoursesChecked", temp, SqlDbType.VarChar, -1));

                sParameters.Add(new Tuple<string, string, SqlDbType, int>("week_1_Subjects", textBox15.Text.ToString(), SqlDbType.VarChar, -1));
                sParameters.Add(new Tuple<string, string, SqlDbType, int>("week_1_Related", textBox31.Text.ToString(), SqlDbType.VarChar, -1));

                sParameters.Add(new Tuple<string, string, SqlDbType, int>("week_2_Subjects", textBox19.Text.ToString(), SqlDbType.VarChar, -1));
                sParameters.Add(new Tuple<string, string, SqlDbType, int>("week_2_Related", textBox32.Text.ToString(), SqlDbType.VarChar, -1));

                sParameters.Add(new Tuple<string, string, SqlDbType, int>("week_3_Subjects", textBox17.Text.ToString(), SqlDbType.VarChar, -1));
                sParameters.Add(new Tuple<string, string, SqlDbType, int>("week_3_Related", textBox33.Text.ToString(), SqlDbType.VarChar, -1));

                sParameters.Add(new Tuple<string, string, SqlDbType, int>("week_4_Subjects", textBox16.Text.ToString(), SqlDbType.VarChar, -1));
                sParameters.Add(new Tuple<string, string, SqlDbType, int>("week_4_Related", textBox34.Text.ToString(), SqlDbType.VarChar, -1));

                sParameters.Add(new Tuple<string, string, SqlDbType, int>("week_5_Subjects", textBox20.Text.ToString(), SqlDbType.VarChar, -1));
                sParameters.Add(new Tuple<string, string, SqlDbType, int>("week_5_Related", textBox35.Text.ToString(), SqlDbType.VarChar, -1));

                sParameters.Add(new Tuple<string, string, SqlDbType, int>("week_6_Subjects", textBox21.Text.ToString(), SqlDbType.VarChar, -1));
                sParameters.Add(new Tuple<string, string, SqlDbType, int>("week_6_Related", textBox36.Text.ToString(), SqlDbType.VarChar, -1));

                sParameters.Add(new Tuple<string, string, SqlDbType, int>("week_7_Subjects", textBox24.Text.ToString(), SqlDbType.VarChar, -1));
                sParameters.Add(new Tuple<string, string, SqlDbType, int>("week_7_Related", textBox37.Text.ToString(), SqlDbType.VarChar, -1));

                sParameters.Add(new Tuple<string, string, SqlDbType, int>("week_8_Subjects", textBox25.Text.ToString(), SqlDbType.VarChar, -1));
                sParameters.Add(new Tuple<string, string, SqlDbType, int>("week_8_Related", textBox38.Text.ToString(), SqlDbType.VarChar, -1));

                sParameters.Add(new Tuple<string, string, SqlDbType, int>("week_9_Subjects", textBox22.Text.ToString(), SqlDbType.VarChar, -1));
                sParameters.Add(new Tuple<string, string, SqlDbType, int>("week_9_Related", textBox39.Text.ToString(), SqlDbType.VarChar, -1));

                sParameters.Add(new Tuple<string, string, SqlDbType, int>("week_10_Subjects", textBox18.Text.ToString(), SqlDbType.VarChar, -1));
                sParameters.Add(new Tuple<string, string, SqlDbType, int>("week_10_Related", textBox40.Text.ToString(), SqlDbType.VarChar, -1));

                sParameters.Add(new Tuple<string, string, SqlDbType, int>("week_11_Subjects", textBox23.Text.ToString(), SqlDbType.VarChar, -1));
                sParameters.Add(new Tuple<string, string, SqlDbType, int>("week_11_Related", textBox41.Text.ToString(), SqlDbType.VarChar, -1));

                sParameters.Add(new Tuple<string, string, SqlDbType, int>("week_12_Subjects", textBox26.Text.ToString(), SqlDbType.VarChar, -1));
                sParameters.Add(new Tuple<string, string, SqlDbType, int>("week_12_Related", textBox42.Text.ToString(), SqlDbType.VarChar, -1));

                sParameters.Add(new Tuple<string, string, SqlDbType, int>("week_13_Subjects", textBox27.Text.ToString(), SqlDbType.VarChar, -1));
                sParameters.Add(new Tuple<string, string, SqlDbType, int>("week_13_Related", textBox43.Text.ToString(), SqlDbType.VarChar, -1));

                sParameters.Add(new Tuple<string, string, SqlDbType, int>("week_14_Subjects", textBox30.Text.ToString(), SqlDbType.VarChar, -1));
                sParameters.Add(new Tuple<string, string, SqlDbType, int>("week_14_Related", textBox44.Text.ToString(), SqlDbType.VarChar, -1));

                sParameters.Add(new Tuple<string, string, SqlDbType, int>("week_15_Subjects", textBox28.Text.ToString(), SqlDbType.VarChar, -1));
                sParameters.Add(new Tuple<string, string, SqlDbType, int>("week_15_Related", textBox45.Text.ToString(), SqlDbType.VarChar, -1));

                sParameters.Add(new Tuple<string, string, SqlDbType, int>("week_16_Subjects", textBox29.Text.ToString(), SqlDbType.VarChar, -1));
                sParameters.Add(new Tuple<string, string, SqlDbType, int>("week_16_Related", textBox46.Text.ToString(), SqlDbType.VarChar, -1));



                sParameters.Add(new Tuple<string, string, SqlDbType, int>("Textbooks", richTextBox6.Text.ToString(), SqlDbType.VarChar, -1));
                sParameters.Add(new Tuple<string, string, SqlDbType, int>("Materials", richTextBox5.Text.ToString(), SqlDbType.VarChar, -1));


                sParameters.Add(new Tuple<string, string, SqlDbType, int>("Participation_Number", textBox78.Text.ToString(), SqlDbType.VarChar, -1));
                sParameters.Add(new Tuple<string, string, SqlDbType, int>("Participation_Weight", textBox62.Text.ToString(), SqlDbType.VarChar, -1));

                sParameters.Add(new Tuple<string, string, SqlDbType, int>("Laboratory_Applicationxtbooks_Number", textBox74.Text.ToString(), SqlDbType.VarChar, -1));
                sParameters.Add(new Tuple<string, string, SqlDbType, int>("Laboratory_Applicationxtbooks_Weight", textBox61.Text.ToString(), SqlDbType.VarChar, -1));

                sParameters.Add(new Tuple<string, string, SqlDbType, int>("FieldWork_Number", textBox76.Text.ToString(), SqlDbType.VarChar, -1));
                sParameters.Add(new Tuple<string, string, SqlDbType, int>("FieldWork_Weight", textBox60.Text.ToString(), SqlDbType.VarChar, -1));

                sParameters.Add(new Tuple<string, string, SqlDbType, int>("Quizzes_StudioCritiques_Number", textBox77.Text.ToString(), SqlDbType.VarChar, -1));
                sParameters.Add(new Tuple<string, string, SqlDbType, int>("Quizzes_StudioCritiques_Weight", textBox59.Text.ToString(), SqlDbType.VarChar, -1));

                sParameters.Add(new Tuple<string, string, SqlDbType, int>("Homework_Assignments_Number", textBox73.Text.ToString(), SqlDbType.VarChar, -1));
                sParameters.Add(new Tuple<string, string, SqlDbType, int>("Homework_Assignments_Weight", textBox58.Text.ToString(), SqlDbType.VarChar, -1));

                sParameters.Add(new Tuple<string, string, SqlDbType, int>("Presentation_Jury_Number", textBox72.Text.ToString(), SqlDbType.VarChar, -1));
                sParameters.Add(new Tuple<string, string, SqlDbType, int>("Presentation_Jury_Weight", textBox57.Text.ToString(), SqlDbType.VarChar, -1));

                sParameters.Add(new Tuple<string, string, SqlDbType, int>("Project_Number", textBox69.Text.ToString(), SqlDbType.VarChar, -1));
                sParameters.Add(new Tuple<string, string, SqlDbType, int>("Project_Weight", textBox56.Text.ToString(), SqlDbType.VarChar, -1));

                sParameters.Add(new Tuple<string, string, SqlDbType, int>("Seminar_Workshop_Number", textBox68.Text.ToString(), SqlDbType.VarChar, -1));
                sParameters.Add(new Tuple<string, string, SqlDbType, int>("Seminar_Workshop_Weight", textBox55.Text.ToString(), SqlDbType.VarChar, -1));

                sParameters.Add(new Tuple<string, string, SqlDbType, int>("OralExams_Number", textBox71.Text.ToString(), SqlDbType.VarChar, -1));
                sParameters.Add(new Tuple<string, string, SqlDbType, int>("OralExams_Weight", textBox54.Text.ToString(), SqlDbType.VarChar, -1));

                sParameters.Add(new Tuple<string, string, SqlDbType, int>("Midterm_Number", textBox75.Text.ToString(), SqlDbType.VarChar, -1));
                sParameters.Add(new Tuple<string, string, SqlDbType, int>("Midterm_Weight", textBox53.Text.ToString(), SqlDbType.VarChar, -1));

                sParameters.Add(new Tuple<string, string, SqlDbType, int>("FinalExam_Number", textBox70.Text.ToString(), SqlDbType.VarChar, -1));
                sParameters.Add(new Tuple<string, string, SqlDbType, int>("FinalExam_Weight", textBox52.Text.ToString(), SqlDbType.VarChar, -1));


                sParameters.Add(new Tuple<string, string, SqlDbType, int>("TheoreticalCourseHours_Num", textBox90.Text.ToString(), SqlDbType.VarChar, -1));
                sParameters.Add(new Tuple<string, string, SqlDbType, int>("TheoreticalCourseHours_Duration", textBox79.Text.ToString(), SqlDbType.VarChar, -1));
                sParameters.Add(new Tuple<string, string, SqlDbType, int>("TheoreticalCourseHours_Workload", textBox93.Text.ToString(), SqlDbType.VarChar, -1));

                sParameters.Add(new Tuple<string, string, SqlDbType, int>("Laboratory_Application_Hours_Number", textBox86.Text.ToString(), SqlDbType.VarChar, -1));
                sParameters.Add(new Tuple<string, string, SqlDbType, int>("Laboratory_Application_Hour_Duration", textBox67.Text.ToString(), SqlDbType.VarChar, -1));
                sParameters.Add(new Tuple<string, string, SqlDbType, int>("Laboratory_Application_Hours_Workload", textBox94.Text.ToString(), SqlDbType.VarChar, -1));

                sParameters.Add(new Tuple<string, string, SqlDbType, int>("Study_Hours_Out_of_Class_Number", textBox88.Text.ToString(), SqlDbType.VarChar, -1));
                sParameters.Add(new Tuple<string, string, SqlDbType, int>("Study_Hours_Out_of_Class_Duration", textBox66.Text.ToString(), SqlDbType.VarChar, -1));
                sParameters.Add(new Tuple<string, string, SqlDbType, int>("Study_Hours_Out_of_Class_Workload", textBox95.Text.ToString(), SqlDbType.VarChar, -1));

                sParameters.Add(new Tuple<string, string, SqlDbType, int>("Field_Work_Number", textBox89.Text.ToString(), SqlDbType.VarChar, -1));
                sParameters.Add(new Tuple<string, string, SqlDbType, int>("Field_Work_Duration", textBox65.Text.ToString(), SqlDbType.VarChar, -1));
                sParameters.Add(new Tuple<string, string, SqlDbType, int>("Field_Work_Workload", textBox96.Text.ToString(), SqlDbType.VarChar, -1));

                sParameters.Add(new Tuple<string, string, SqlDbType, int>("Quizzes_Studio_Critiques_Number", textBox85.Text.ToString(), SqlDbType.VarChar, -1));
                sParameters.Add(new Tuple<string, string, SqlDbType, int>("Quizzes_Studio_Critiques_Duration", textBox64.Text.ToString(), SqlDbType.VarChar, -1));
                sParameters.Add(new Tuple<string, string, SqlDbType, int>("Quizzes_Studio_Critiques_Workload", textBox97.Text.ToString(), SqlDbType.VarChar, -1));

                sParameters.Add(new Tuple<string, string, SqlDbType, int>("Homework_Assignmentss_Number", textBox84.Text.ToString(), SqlDbType.VarChar, -1));
                sParameters.Add(new Tuple<string, string, SqlDbType, int>("Homework_Assignmentss_Duration", textBox63.Text.ToString(), SqlDbType.VarChar, -1));
                sParameters.Add(new Tuple<string, string, SqlDbType, int>("Homework_Assignmentss_Workload", textBox98.Text.ToString(), SqlDbType.VarChar, -1));

                sParameters.Add(new Tuple<string, string, SqlDbType, int>("Presentation_Juryy_Number", textBox81.Text.ToString(), SqlDbType.VarChar, -1));
                sParameters.Add(new Tuple<string, string, SqlDbType, int>("Presentation_Juryy_Duration", textBox51.Text.ToString(), SqlDbType.VarChar, -1));
                sParameters.Add(new Tuple<string, string, SqlDbType, int>("Presentation_Juryy_Workload", textBox99.Text.ToString(), SqlDbType.VarChar, -1));

                sParameters.Add(new Tuple<string, string, SqlDbType, int>("Projectt_Number", textBox80.Text.ToString(), SqlDbType.VarChar, -1));
                sParameters.Add(new Tuple<string, string, SqlDbType, int>("Projectt_Duration", textBox50.Text.ToString(), SqlDbType.VarChar, -1));
                sParameters.Add(new Tuple<string, string, SqlDbType, int>("Projectt_Workload", textBox100.Text.ToString(), SqlDbType.VarChar, -1));

                sParameters.Add(new Tuple<string, string, SqlDbType, int>("Seminar_Workshopp_Number", textBox83.Text.ToString(), SqlDbType.VarChar, -1));
                sParameters.Add(new Tuple<string, string, SqlDbType, int>("Seminar_Workshopp_Duration", textBox49.Text.ToString(), SqlDbType.VarChar, -1));
                sParameters.Add(new Tuple<string, string, SqlDbType, int>("Seminar_Workshopp_Workload", textBox101.Text.ToString(), SqlDbType.VarChar, -1));

                sParameters.Add(new Tuple<string, string, SqlDbType, int>("Oral_Exam_Number", textBox87.Text.ToString(), SqlDbType.VarChar, -1));
                sParameters.Add(new Tuple<string, string, SqlDbType, int>("Oral_Exam_Duration", textBox48.Text.ToString(), SqlDbType.VarChar, -1));
                sParameters.Add(new Tuple<string, string, SqlDbType, int>("Oral_Exam_Workload", textBox102.Text.ToString(), SqlDbType.VarChar, -1));

                sParameters.Add(new Tuple<string, string, SqlDbType, int>("Midtermss_Number", textBox82.Text.ToString(), SqlDbType.VarChar, -1));
                sParameters.Add(new Tuple<string, string, SqlDbType, int>("Midtermss_Duration", textBox47.Text.ToString(), SqlDbType.VarChar, -1));
                sParameters.Add(new Tuple<string, string, SqlDbType, int>("Midtermss_Workload", textBox103.Text.ToString(), SqlDbType.VarChar, -1));

                sParameters.Add(new Tuple<string, string, SqlDbType, int>("Final_Exam_Number", textBox91.Text.ToString(), SqlDbType.VarChar, -1));
                sParameters.Add(new Tuple<string, string, SqlDbType, int>("Final_Exam_Duration", textBox92.Text.ToString(), SqlDbType.VarChar, -1));
                sParameters.Add(new Tuple<string, string, SqlDbType, int>("Final_Exam_Workload", textBox104.Text.ToString(), SqlDbType.VarChar, -1));


                sParameters.Add(new Tuple<string, string, SqlDbType, int>("Outcomes_1_Text", textBox105.Text.ToString(), SqlDbType.VarChar, -1));
                sParameters.Add(new Tuple<string, string, SqlDbType, int>("Outcomes_1_Value", numericUpDown11.Value.ToString(), SqlDbType.VarChar, -1));

                sParameters.Add(new Tuple<string, string, SqlDbType, int>("Outcomes_2_Text", textBox106.Text.ToString(), SqlDbType.VarChar, -1));
                sParameters.Add(new Tuple<string, string, SqlDbType, int>("Outcomes_2_Value", numericUpDown2.Value.ToString(), SqlDbType.VarChar, -1));

                sParameters.Add(new Tuple<string, string, SqlDbType, int>("Outcomes_3_Text", textBox107.Text.ToString(), SqlDbType.VarChar, -1));
                sParameters.Add(new Tuple<string, string, SqlDbType, int>("Outcomes_3_Value", numericUpDown3.Value.ToString(), SqlDbType.VarChar, -1));

                sParameters.Add(new Tuple<string, string, SqlDbType, int>("Outcomes_4_Text", textBox108.Text.ToString(), SqlDbType.VarChar, -1));
                sParameters.Add(new Tuple<string, string, SqlDbType, int>("Outcomes_4_Value", numericUpDown4.Value.ToString(), SqlDbType.VarChar, -1));

                sParameters.Add(new Tuple<string, string, SqlDbType, int>("Outcomes_5_Text", textBox109.Text.ToString(), SqlDbType.VarChar, -1));
                sParameters.Add(new Tuple<string, string, SqlDbType, int>("Outcomes_5_Value", numericUpDown5.Value.ToString(), SqlDbType.VarChar, -1));

                sParameters.Add(new Tuple<string, string, SqlDbType, int>("Outcomes_6_Text", textBox110.Text.ToString(), SqlDbType.VarChar, -1));
                sParameters.Add(new Tuple<string, string, SqlDbType, int>("Outcomes_6_Value", numericUpDown6.Value.ToString(), SqlDbType.VarChar, -1));

                sParameters.Add(new Tuple<string, string, SqlDbType, int>("Outcomes_7_Text", textBox111.Text.ToString(), SqlDbType.VarChar, -1));
                sParameters.Add(new Tuple<string, string, SqlDbType, int>("Outcomes_7_Value", numericUpDown7.Value.ToString(), SqlDbType.VarChar, -1));

                sParameters.Add(new Tuple<string, string, SqlDbType, int>("Outcomes_8_Text", textBox112.Text.ToString(), SqlDbType.VarChar, -1));
                sParameters.Add(new Tuple<string, string, SqlDbType, int>("Outcomes_8_Value", numericUpDown8.Value.ToString(), SqlDbType.VarChar, -1));

                sParameters.Add(new Tuple<string, string, SqlDbType, int>("Outcomes_9_Text", textBox113.Text.ToString(), SqlDbType.VarChar, -1));
                sParameters.Add(new Tuple<string, string, SqlDbType, int>("Outcomes_9_Value", numericUpDown9.Value.ToString(), SqlDbType.VarChar, -1));

                sParameters.Add(new Tuple<string, string, SqlDbType, int>("Outcomes_10_Text", textBox114.Text.ToString(), SqlDbType.VarChar, -1));
                sParameters.Add(new Tuple<string, string, SqlDbType, int>("Outcomes_10_Value", numericUpDown10.Value.ToString(), SqlDbType.VarChar, -1));

                sParameters.Add(new Tuple<string, string, SqlDbType, int>("Outcomes_11_Text", textBox115.Text.ToString(), SqlDbType.VarChar, -1));
                sParameters.Add(new Tuple<string, string, SqlDbType, int>("Outcomes_11_Value", numericUpDown11.Value.ToString(), SqlDbType.VarChar, -1));

                sParameters.Add(new Tuple<string, string, SqlDbType, int>("Outcomes_12_Text", textBox116.Text.ToString(), SqlDbType.VarChar, -1));
                sParameters.Add(new Tuple<string, string, SqlDbType, int>("Outcomes_12_Value", numericUpDown12.Value.ToString(), SqlDbType.VarChar, -1));

                sParameters.Add(new Tuple<string, string, SqlDbType, int>("Outcomes_13_Text", textBox117.Text.ToString(), SqlDbType.VarChar, -1));
                sParameters.Add(new Tuple<string, string, SqlDbType, int>("Outcomes_13_Value", numericUpDown13.Value.ToString(), SqlDbType.VarChar, -1));


                if (this.isEnglish)
                {
                    DialogResult dialog = new DialogResult();
                    dialog = MessageBox.Show("Do you approve course enrollment?", "CONFIRMATION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialog == DialogResult.Yes)
                    {
                        if (this.isUpdate)
                        {
                            sParameters.Add(new Tuple<string, string, SqlDbType, int>("iID", this.iID.ToString(), SqlDbType.Int, -1));
                            if (cS.CallProcedure("UPDATE LESSON", sParameters, true) == 1)
                            {
                                MessageBox.Show("Course registration successfully updated", "SUCCES", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Error encountered while updating lecture record", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else
                        {
                            if (cS.CallProcedure("ADD_LESSON", sParameters, true) == 1)
                            {
                                MessageBox.Show("Course registration successfully created", "SUCCES", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Error encountered while creating lecture record", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }

                else
                {
                    DialogResult dialog = new DialogResult();
                    dialog = MessageBox.Show("Ders kaydını onaylıyor musunuz ?", "ONAY", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialog == DialogResult.Yes)
                    {
                        if (this.isUpdate)
                        {
                            sParameters.Add(new Tuple<string, string, SqlDbType, int>("iID", this.iID.ToString(), SqlDbType.Int, -1));
                            if (cS.CallProcedure("UPDATE_LESSON", sParameters, true) == 1)
                            {
                                MessageBox.Show("Ders kaydı başarıyla güncellendi", "BAŞARILI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Ders kaydı güncellenirken hata ile karşılaşıldı", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else
                        {
                            if (cS.CallProcedure("ADD_LESSON", sParameters, true) == 1)
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

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            textBox2.Text = (Convert.ToInt32(textBox6.Text) + (Convert.ToInt16(textBox4.Text) * 0.5)).ToString();
        }

        private void textBox79_TextChanged(object sender, EventArgs e)
        {
            textBox93.Text = (Convert.ToInt16(textBox90.Text) * Convert.ToInt32(textBox79.Text)).ToString();
        }

        private void textBox67_TextChanged(object sender, EventArgs e)
        {
            textBox94.Text = (Convert.ToInt16(textBox86.Text) * Convert.ToInt32(textBox67.Text)).ToString();
        }

        private void textBox66_TextChanged(object sender, EventArgs e)
        {
            textBox95.Text = (Convert.ToInt16(textBox88.Text) * Convert.ToInt32(textBox66.Text)).ToString();
        }
    }
}
