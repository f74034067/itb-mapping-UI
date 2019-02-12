namespace itb_mapping_UI
{
    partial class Readfile
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
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_avifile = new System.Windows.Forms.TextBox();
            this.textBox_itbfile = new System.Windows.Forms.TextBox();
            this.button_read_avifile = new System.Windows.Forms.Button();
            this.button_read_itbfile = new System.Windows.Forms.Button();
            this.button_confirm = new System.Windows.Forms.Button();
            this.button_exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(42, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "AVI File";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(46, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 36);
            this.label2.TabIndex = 1;
            this.label2.Text = "ITB File";
            // 
            // textBox_avifile
            // 
            this.textBox_avifile.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBox_avifile.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox_avifile.Location = new System.Drawing.Point(183, 72);
            this.textBox_avifile.Name = "textBox_avifile";
            this.textBox_avifile.ReadOnly = true;
            this.textBox_avifile.Size = new System.Drawing.Size(405, 27);
            this.textBox_avifile.TabIndex = 2;
            // 
            // textBox_itbfile
            // 
            this.textBox_itbfile.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBox_itbfile.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox_itbfile.Location = new System.Drawing.Point(183, 137);
            this.textBox_itbfile.Name = "textBox_itbfile";
            this.textBox_itbfile.ReadOnly = true;
            this.textBox_itbfile.Size = new System.Drawing.Size(405, 27);
            this.textBox_itbfile.TabIndex = 3;
            // 
            // button_read_avifile
            // 
            this.button_read_avifile.Location = new System.Drawing.Point(637, 72);
            this.button_read_avifile.Name = "button_read_avifile";
            this.button_read_avifile.Size = new System.Drawing.Size(105, 27);
            this.button_read_avifile.TabIndex = 4;
            this.button_read_avifile.Text = "Open AVI File";
            this.button_read_avifile.UseVisualStyleBackColor = true;
            this.button_read_avifile.Click += new System.EventHandler(this.button_read_avifile_Click);
            // 
            // button_read_itbfile
            // 
            this.button_read_itbfile.Location = new System.Drawing.Point(637, 135);
            this.button_read_itbfile.Name = "button_read_itbfile";
            this.button_read_itbfile.Size = new System.Drawing.Size(105, 27);
            this.button_read_itbfile.TabIndex = 5;
            this.button_read_itbfile.Text = "Open ITB File";
            this.button_read_itbfile.UseVisualStyleBackColor = true;
            this.button_read_itbfile.Click += new System.EventHandler(this.button_read_itbfile_Click);
            // 
            // button_confirm
            // 
            this.button_confirm.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_confirm.Location = new System.Drawing.Point(48, 291);
            this.button_confirm.Name = "button_confirm";
            this.button_confirm.Size = new System.Drawing.Size(183, 53);
            this.button_confirm.TabIndex = 6;
            this.button_confirm.Text = "confirm";
            this.button_confirm.UseVisualStyleBackColor = true;
            this.button_confirm.Click += new System.EventHandler(this.button_confirm_Click);
            // 
            // button_exit
            // 
            this.button_exit.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_exit.Location = new System.Drawing.Point(272, 291);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(183, 53);
            this.button_exit.TabIndex = 7;
            this.button_exit.Text = "cancel";
            this.button_exit.UseVisualStyleBackColor = true;
            // 
            // Readfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.button_confirm);
            this.Controls.Add(this.button_read_itbfile);
            this.Controls.Add(this.button_read_avifile);
            this.Controls.Add(this.textBox_itbfile);
            this.Controls.Add(this.textBox_avifile);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Readfile";
            this.Text = "Readfile";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_avifile;
        private System.Windows.Forms.TextBox textBox_itbfile;
        private System.Windows.Forms.Button button_read_avifile;
        private System.Windows.Forms.Button button_read_itbfile;
        private System.Windows.Forms.Button button_confirm;
        private System.Windows.Forms.Button button_exit;
    }
}