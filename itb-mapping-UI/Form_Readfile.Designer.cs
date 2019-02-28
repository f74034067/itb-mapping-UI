namespace itb_mapping_UI
{
    partial class Form_Readfile
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
            this.label_itbfile = new System.Windows.Forms.Label();
            this.textBox_itbfile = new System.Windows.Forms.TextBox();
            this.button_read_avifile = new System.Windows.Forms.Button();
            this.button_read_itbfile = new System.Windows.Forms.Button();
            this.button_confirm = new System.Windows.Forms.Button();
            this.button_exit = new System.Windows.Forms.Button();
            this.button_read_avi_csvfile = new System.Windows.Forms.Button();
            this.textBox_avi_csv = new System.Windows.Forms.TextBox();
            this.label_avi_csv = new System.Windows.Forms.Label();
            this.label_starttime = new System.Windows.Forms.Label();
            this.dropdownlist_year = new System.Windows.Forms.ComboBox();
            this.dropdownlist_month = new System.Windows.Forms.ComboBox();
            this.dropdownlist_days = new System.Windows.Forms.ComboBox();
            this.dropdownlist_hours = new System.Windows.Forms.ComboBox();
            this.dropdownlist_min = new System.Windows.Forms.ComboBox();
            this.dropdownlist_sec = new System.Windows.Forms.ComboBox();
            this.textBox_avifile = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(34, 51);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "AVI File";
            // 
            // label_itbfile
            // 
            this.label_itbfile.AutoSize = true;
            this.label_itbfile.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_itbfile.Location = new System.Drawing.Point(34, 135);
            this.label_itbfile.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_itbfile.Name = "label_itbfile";
            this.label_itbfile.Size = new System.Drawing.Size(89, 28);
            this.label_itbfile.TabIndex = 1;
            this.label_itbfile.Text = "ITB File";
            // 
            // textBox_itbfile
            // 
            this.textBox_itbfile.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBox_itbfile.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox_itbfile.ImeMode = System.Windows.Forms.ImeMode.OnHalf;
            this.textBox_itbfile.Location = new System.Drawing.Point(152, 142);
            this.textBox_itbfile.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_itbfile.Name = "textBox_itbfile";
            this.textBox_itbfile.ReadOnly = false;
            this.textBox_itbfile.Size = new System.Drawing.Size(390, 23);
            this.textBox_itbfile.TabIndex = 3;
            // 
            // button_read_avifile
            // 
            this.button_read_avifile.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_read_avifile.Location = new System.Drawing.Point(571, 58);
            this.button_read_avifile.Margin = new System.Windows.Forms.Padding(2);
            this.button_read_avifile.Name = "button_read_avifile";
            this.button_read_avifile.Size = new System.Drawing.Size(131, 22);
            this.button_read_avifile.TabIndex = 4;
            this.button_read_avifile.Text = "Open AVI File";
            this.button_read_avifile.UseVisualStyleBackColor = true;
            this.button_read_avifile.Click += new System.EventHandler(this.button_read_avifile_Click);
            // 
            // button_read_itbfile
            // 
            this.button_read_itbfile.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_read_itbfile.Location = new System.Drawing.Point(571, 142);
            this.button_read_itbfile.Margin = new System.Windows.Forms.Padding(2);
            this.button_read_itbfile.Name = "button_read_itbfile";
            this.button_read_itbfile.Size = new System.Drawing.Size(131, 22);
            this.button_read_itbfile.TabIndex = 5;
            this.button_read_itbfile.Text = "Open ITB File";
            this.button_read_itbfile.UseVisualStyleBackColor = true;
            this.button_read_itbfile.Click += new System.EventHandler(this.button_read_itbfile_Click);
            // 
            // button_confirm
            // 
            this.button_confirm.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_confirm.Location = new System.Drawing.Point(152, 262);
            this.button_confirm.Margin = new System.Windows.Forms.Padding(2);
            this.button_confirm.Name = "button_confirm";
            this.button_confirm.Size = new System.Drawing.Size(137, 42);
            this.button_confirm.TabIndex = 6;
            this.button_confirm.Text = "confirm";
            this.button_confirm.UseVisualStyleBackColor = true;
            this.button_confirm.Click += new System.EventHandler(this.button_confirm_Click);
            // 
            // button_exit
            // 
            this.button_exit.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_exit.Location = new System.Drawing.Point(403, 262);
            this.button_exit.Margin = new System.Windows.Forms.Padding(2);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(137, 42);
            this.button_exit.TabIndex = 7;
            this.button_exit.Text = "cancel";
            this.button_exit.UseVisualStyleBackColor = true;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // button_read_avi_csvfile
            // 
            this.button_read_avi_csvfile.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_read_avi_csvfile.Location = new System.Drawing.Point(571, 102);
            this.button_read_avi_csvfile.Margin = new System.Windows.Forms.Padding(2);
            this.button_read_avi_csvfile.Name = "button_read_avi_csvfile";
            this.button_read_avi_csvfile.Size = new System.Drawing.Size(131, 22);
            this.button_read_avi_csvfile.TabIndex = 10;
            this.button_read_avi_csvfile.Text = "Open AVI_CSV File";
            this.button_read_avi_csvfile.UseVisualStyleBackColor = true;
            this.button_read_avi_csvfile.Click += new System.EventHandler(this.button_read_avi_csvfile_Click);
            // 
            // textBox_avi_csv
            // 
            this.textBox_avi_csv.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBox_avi_csv.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox_avi_csv.ImeMode = System.Windows.Forms.ImeMode.OnHalf;
            this.textBox_avi_csv.Location = new System.Drawing.Point(152, 102);
            this.textBox_avi_csv.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_avi_csv.Name = "textBox_avi_csv";
            this.textBox_avi_csv.ReadOnly =true;
            this.textBox_avi_csv.Size = new System.Drawing.Size(390, 23);
            this.textBox_avi_csv.TabIndex = 9;
            // 
            // label_avi_csv
            // 
            this.label_avi_csv.AutoSize = true;
            this.label_avi_csv.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_avi_csv.Location = new System.Drawing.Point(9, 96);
            this.label_avi_csv.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_avi_csv.Name = "label_avi_csv";
            this.label_avi_csv.Size = new System.Drawing.Size(146, 28);
            this.label_avi_csv.TabIndex = 8;
            this.label_avi_csv.Text = "AVI_CSV File";
            // 
            // label_starttime
            // 
            this.label_starttime.AutoSize = true;
            this.label_starttime.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_starttime.Location = new System.Drawing.Point(9, 185);
            this.label_starttime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_starttime.Name = "label_starttime";
            this.label_starttime.Size = new System.Drawing.Size(133, 28);
            this.label_starttime.TabIndex = 11;
            this.label_starttime.Text = "Start Time :";
            // 
            // dropdownlist_year
            // 
            this.dropdownlist_year.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropdownlist_year.FormattingEnabled = true;
            this.dropdownlist_year.ImeMode = System.Windows.Forms.ImeMode.OnHalf;
            this.dropdownlist_year.Location = new System.Drawing.Point(152, 194);
            this.dropdownlist_year.Margin = new System.Windows.Forms.Padding(2);
            this.dropdownlist_year.Name = "dropdownlist_year";
            this.dropdownlist_year.Size = new System.Drawing.Size(92, 20);
            this.dropdownlist_year.TabIndex = 12;
            // 
            // dropdownlist_month
            // 
            this.dropdownlist_month.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropdownlist_month.FormattingEnabled = true;
            this.dropdownlist_month.ImeMode = System.Windows.Forms.ImeMode.OnHalf;
            this.dropdownlist_month.Location = new System.Drawing.Point(247, 194);
            this.dropdownlist_month.Margin = new System.Windows.Forms.Padding(2);
            this.dropdownlist_month.Name = "dropdownlist_month";
            this.dropdownlist_month.Size = new System.Drawing.Size(92, 20);
            this.dropdownlist_month.TabIndex = 13;
            // 
            // dropdownlist_days
            // 
            this.dropdownlist_days.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropdownlist_days.FormattingEnabled = true;
            this.dropdownlist_days.ImeMode = System.Windows.Forms.ImeMode.OnHalf;
            this.dropdownlist_days.Location = new System.Drawing.Point(342, 194);
            this.dropdownlist_days.Margin = new System.Windows.Forms.Padding(2);
            this.dropdownlist_days.Name = "dropdownlist_days";
            this.dropdownlist_days.Size = new System.Drawing.Size(92, 20);
            this.dropdownlist_days.TabIndex = 14;
            // 
            // dropdownlist_hours
            // 
            this.dropdownlist_hours.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropdownlist_hours.FormattingEnabled = true;
            this.dropdownlist_hours.ImeMode = System.Windows.Forms.ImeMode.OnHalf;
            this.dropdownlist_hours.Location = new System.Drawing.Point(446, 194);
            this.dropdownlist_hours.Margin = new System.Windows.Forms.Padding(2);
            this.dropdownlist_hours.Name = "dropdownlist_hours";
            this.dropdownlist_hours.Size = new System.Drawing.Size(74, 20);
            this.dropdownlist_hours.TabIndex = 15;
            // 
            // dropdownlist_min
            // 
            this.dropdownlist_min.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropdownlist_min.FormattingEnabled = true;
            this.dropdownlist_min.ImeMode = System.Windows.Forms.ImeMode.OnHalf;
            this.dropdownlist_min.Location = new System.Drawing.Point(524, 194);
            this.dropdownlist_min.Margin = new System.Windows.Forms.Padding(2);
            this.dropdownlist_min.Name = "dropdownlist_min";
            this.dropdownlist_min.Size = new System.Drawing.Size(74, 20);
            this.dropdownlist_min.TabIndex = 16;
            // 
            // dropdownlist_sec
            // 
            this.dropdownlist_sec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropdownlist_sec.FormattingEnabled = true;
            this.dropdownlist_sec.ImeMode = System.Windows.Forms.ImeMode.OnHalf;
            this.dropdownlist_sec.Location = new System.Drawing.Point(601, 194);
            this.dropdownlist_sec.Margin = new System.Windows.Forms.Padding(2);
            this.dropdownlist_sec.Name = "dropdownlist_sec";
            this.dropdownlist_sec.Size = new System.Drawing.Size(74, 20);
            this.dropdownlist_sec.TabIndex = 17;
            // 
            // textBox_avifile
            // 
            this.textBox_avifile.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBox_avifile.ImeMode = System.Windows.Forms.ImeMode.OnHalf;
            this.textBox_avifile.Location = new System.Drawing.Point(152, 58);
            this.textBox_avifile.Name = "textBox_avifile";
            this.textBox_avifile.ReadOnly = true;
            this.textBox_avifile.Size = new System.Drawing.Size(390, 22);
            this.textBox_avifile.TabIndex = 18;
            // 
            // Form_Readfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 360);
            this.Controls.Add(this.textBox_avifile);
            this.Controls.Add(this.dropdownlist_sec);
            this.Controls.Add(this.dropdownlist_min);
            this.Controls.Add(this.dropdownlist_hours);
            this.Controls.Add(this.dropdownlist_days);
            this.Controls.Add(this.dropdownlist_month);
            this.Controls.Add(this.dropdownlist_year);
            this.Controls.Add(this.label_starttime);
            this.Controls.Add(this.button_read_avi_csvfile);
            this.Controls.Add(this.textBox_avi_csv);
            this.Controls.Add(this.label_avi_csv);
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.button_confirm);
            this.Controls.Add(this.button_read_itbfile);
            this.Controls.Add(this.button_read_avifile);
            this.Controls.Add(this.textBox_itbfile);
            this.Controls.Add(this.label_itbfile);
            this.Controls.Add(this.label1);
            this.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form_Readfile";
            this.Text = "Readfile";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_itbfile;
        private System.Windows.Forms.TextBox textBox_itbfile;
        private System.Windows.Forms.Button button_read_avifile;
        private System.Windows.Forms.Button button_read_itbfile;
        private System.Windows.Forms.Button button_confirm;
        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.Button button_read_avi_csvfile;
        private System.Windows.Forms.TextBox textBox_avi_csv;
        private System.Windows.Forms.Label label_avi_csv;
        private System.Windows.Forms.Label label_starttime;
        private System.Windows.Forms.ComboBox dropdownlist_year;
        private System.Windows.Forms.ComboBox dropdownlist_month;
        private System.Windows.Forms.ComboBox dropdownlist_days;
        private System.Windows.Forms.ComboBox dropdownlist_hours;
        private System.Windows.Forms.ComboBox dropdownlist_min;
        private System.Windows.Forms.ComboBox dropdownlist_sec;
        private System.Windows.Forms.TextBox textBox_avifile;
    }
}