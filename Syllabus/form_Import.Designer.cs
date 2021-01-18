namespace Syllabus
{
    partial class form_Import
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button_import = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label_Lesson = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label_Code = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(28, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "URL : ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(81, 68);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(288, 20);
            this.textBox1.TabIndex = 1;
            // 
            // button_import
            // 
            this.button_import.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(226)))), ((int)(((byte)(178)))));
            this.button_import.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_import.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_import.Location = new System.Drawing.Point(81, 94);
            this.button_import.Name = "button_import";
            this.button_import.Size = new System.Drawing.Size(288, 34);
            this.button_import.TabIndex = 3;
            this.button_import.Text = "button1";
            this.button_import.UseVisualStyleBackColor = false;
            this.button_import.Click += new System.EventHandler(this.button_import_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.panel3.Location = new System.Drawing.Point(12, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 130);
            this.panel3.TabIndex = 22;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.panel1.Location = new System.Drawing.Point(387, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 130);
            this.panel1.TabIndex = 23;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(81, 7);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(288, 20);
            this.textBox2.TabIndex = 26;
            // 
            // label_Lesson
            // 
            this.label_Lesson.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_Lesson.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label_Lesson.Location = new System.Drawing.Point(28, 9);
            this.label_Lesson.Name = "label_Lesson";
            this.label_Lesson.Size = new System.Drawing.Size(50, 16);
            this.label_Lesson.TabIndex = 25;
            this.label_Lesson.Text = "URL : ";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(81, 37);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(288, 20);
            this.textBox3.TabIndex = 28;
            // 
            // label_Code
            // 
            this.label_Code.AutoSize = true;
            this.label_Code.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_Code.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label_Code.Location = new System.Drawing.Point(28, 39);
            this.label_Code.Name = "label_Code";
            this.label_Code.Size = new System.Drawing.Size(50, 16);
            this.label_Code.TabIndex = 27;
            this.label_Code.Text = "URL : ";
            // 
            // form_Import
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(412, 142);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label_Code);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label_Lesson);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.button_import);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "form_Import";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Syllabus";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button_import;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label_Lesson;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label_Code;
    }
}