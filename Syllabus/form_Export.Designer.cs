namespace Syllabus
{
    partial class form_Export
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
            this.label_Lessonss = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button_export = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label_Lessonss
            // 
            this.label_Lessonss.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label_Lessonss.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label_Lessonss.Location = new System.Drawing.Point(29, 28);
            this.label_Lessonss.Name = "label_Lessonss";
            this.label_Lessonss.Size = new System.Drawing.Size(50, 16);
            this.label_Lessonss.TabIndex = 34;
            this.label_Lessonss.Text = "URL : ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.panel1.Location = new System.Drawing.Point(389, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 105);
            this.panel1.TabIndex = 33;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.panel3.Location = new System.Drawing.Point(14, 6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 105);
            this.panel3.TabIndex = 32;
            // 
            // button_export
            // 
            this.button_export.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(226)))), ((int)(((byte)(178)))));
            this.button_export.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_export.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_export.Location = new System.Drawing.Point(83, 61);
            this.button_export.Name = "button_export";
            this.button_export.Size = new System.Drawing.Size(288, 34);
            this.button_export.TabIndex = 31;
            this.button_export.Text = "button1";
            this.button_export.UseVisualStyleBackColor = false;
            this.button_export.Click += new System.EventHandler(this.button_export_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(83, 25);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(288, 21);
            this.comboBox1.TabIndex = 35;
            // 
            // form_Export
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(412, 116);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label_Lessonss);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.button_export);
            this.Name = "form_Export";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "form_Export";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label_Lessonss;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button_export;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}