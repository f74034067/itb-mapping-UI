namespace itb_mapping_UI
{
    partial class Form_MappingInterface
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_MappingInterface));
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.button_play = new System.Windows.Forms.Button();
            this.button_pause = new System.Windows.Forms.Button();
            this.dataGridView_avicsv = new System.Windows.Forms.DataGridView();
            this.dataGridView_itbcsv = new System.Windows.Forms.DataGridView();
            this.CurrentPosition = new System.Windows.Forms.TextBox();
            this.label_starttime = new System.Windows.Forms.Label();
            this.label_is_readfile = new System.Windows.Forms.Label();
            this.dataGridView_combine = new System.Windows.Forms.DataGridView();
            this.button_add = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.textBox_savefile_path = new System.Windows.Forms.TextBox();
            this.button_filepath = new System.Windows.Forms.Button();
            this.button_save = new System.Windows.Forms.Button();
            this.label_savepath = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_avicsv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_itbcsv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_combine)).BeginInit();
            this.SuspendLayout();
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(19, 22);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(472, 299);
            this.axWindowsMediaPlayer1.TabIndex = 0;
            this.axWindowsMediaPlayer1.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.axWindowsMediaPlayer1_PlayStateChange);
            this.axWindowsMediaPlayer1.PositionChange += new AxWMPLib._WMPOCXEvents_PositionChangeEventHandler(this.axWindowsMediaPlayer1_PositionChange);
            // 
            // button_play
            // 
            this.button_play.Location = new System.Drawing.Point(17, 327);
            this.button_play.Name = "button_play";
            this.button_play.Size = new System.Drawing.Size(60, 21);
            this.button_play.TabIndex = 3;
            this.button_play.Text = "Play";
            this.button_play.UseVisualStyleBackColor = true;
            this.button_play.Click += new System.EventHandler(this.button_Play);
            // 
            // button_pause
            // 
            this.button_pause.Location = new System.Drawing.Point(83, 325);
            this.button_pause.Name = "button_pause";
            this.button_pause.Size = new System.Drawing.Size(60, 21);
            this.button_pause.TabIndex = 4;
            this.button_pause.Text = "Pause";
            this.button_pause.UseVisualStyleBackColor = true;
            this.button_pause.Click += new System.EventHandler(this.button_Stop);
            // 
            // dataGridView_avicsv
            // 
            this.dataGridView_avicsv.AllowUserToAddRows = false;
            this.dataGridView_avicsv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_avicsv.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dataGridView_avicsv.Location = new System.Drawing.Point(532, 22);
            this.dataGridView_avicsv.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView_avicsv.MultiSelect = false;
            this.dataGridView_avicsv.Name = "dataGridView_avicsv";
            this.dataGridView_avicsv.ReadOnly = true;
            this.dataGridView_avicsv.RowTemplate.Height = 27;
            this.dataGridView_avicsv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_avicsv.Size = new System.Drawing.Size(484, 299);
            this.dataGridView_avicsv.TabIndex = 5;
            // 
            // dataGridView_itbcsv
            // 
            this.dataGridView_itbcsv.AllowUserToAddRows = false;
            this.dataGridView_itbcsv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_itbcsv.Location = new System.Drawing.Point(19, 353);
            this.dataGridView_itbcsv.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView_itbcsv.MultiSelect = false;
            this.dataGridView_itbcsv.Name = "dataGridView_itbcsv";
            this.dataGridView_itbcsv.ReadOnly = true;
            this.dataGridView_itbcsv.RowTemplate.Height = 27;
            this.dataGridView_itbcsv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_itbcsv.Size = new System.Drawing.Size(997, 204);
            this.dataGridView_itbcsv.TabIndex = 6;
            // 
            // CurrentPosition
            // 
            this.CurrentPosition.Enabled = false;
            this.CurrentPosition.Location = new System.Drawing.Point(17, 761);
            this.CurrentPosition.Name = "CurrentPosition";
            this.CurrentPosition.Size = new System.Drawing.Size(60, 22);
            this.CurrentPosition.TabIndex = 7;
            // 
            // label_starttime
            // 
            this.label_starttime.AutoSize = true;
            this.label_starttime.Location = new System.Drawing.Point(81, 773);
            this.label_starttime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_starttime.Name = "label_starttime";
            this.label_starttime.Size = new System.Drawing.Size(53, 12);
            this.label_starttime.TabIndex = 8;
            this.label_starttime.Text = "start time :";
            // 
            // label_is_readfile
            // 
            this.label_is_readfile.AutoSize = true;
            this.label_is_readfile.Location = new System.Drawing.Point(81, 754);
            this.label_is_readfile.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_is_readfile.Name = "label_is_readfile";
            this.label_is_readfile.Size = new System.Drawing.Size(114, 12);
            this.label_is_readfile.TabIndex = 9;
            this.label_is_readfile.Text = "read file : not done yet!";
            // 
            // dataGridView_combine
            // 
            this.dataGridView_combine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_combine.Location = new System.Drawing.Point(20, 562);
            this.dataGridView_combine.Name = "dataGridView_combine";
            this.dataGridView_combine.RowTemplate.Height = 24;
            this.dataGridView_combine.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_combine.Size = new System.Drawing.Size(997, 189);
            this.dataGridView_combine.TabIndex = 10;
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(315, 327);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(60, 21);
            this.button_add.TabIndex = 11;
            this.button_add.Text = "Add";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // button_delete
            // 
            this.button_delete.Location = new System.Drawing.Point(381, 327);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(60, 21);
            this.button_delete.TabIndex = 12;
            this.button_delete.Text = "Delete";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // textBox_savefile_path
            // 
            this.textBox_savefile_path.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBox_savefile_path.Location = new System.Drawing.Point(560, 758);
            this.textBox_savefile_path.Name = "textBox_savefile_path";
            this.textBox_savefile_path.Size = new System.Drawing.Size(315, 22);
            this.textBox_savefile_path.TabIndex = 16;
            // 
            // button_filepath
            // 
            this.button_filepath.Location = new System.Drawing.Point(881, 758);
            this.button_filepath.Name = "button_filepath";
            this.button_filepath.Size = new System.Drawing.Size(60, 21);
            this.button_filepath.TabIndex = 17;
            this.button_filepath.Text = "Path";
            this.button_filepath.UseVisualStyleBackColor = true;
            this.button_filepath.Click += new System.EventHandler(this.button_filepath_Click);
            // 
            // button_save
            // 
            this.button_save.Location = new System.Drawing.Point(956, 758);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(60, 21);
            this.button_save.TabIndex = 18;
            this.button_save.Text = "Save";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // label_savepath
            // 
            this.label_savepath.AutoSize = true;
            this.label_savepath.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_savepath.Location = new System.Drawing.Point(422, 758);
            this.label_savepath.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_savepath.Name = "label_savepath";
            this.label_savepath.Size = new System.Drawing.Size(133, 21);
            this.label_savepath.TabIndex = 19;
            this.label_savepath.Text = "Your Save Path :";
            // 
            // Form_MappingInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 800);
            this.Controls.Add(this.label_savepath);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.button_filepath);
            this.Controls.Add(this.textBox_savefile_path);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.dataGridView_combine);
            this.Controls.Add(this.label_is_readfile);
            this.Controls.Add(this.label_starttime);
            this.Controls.Add(this.CurrentPosition);
            this.Controls.Add(this.dataGridView_itbcsv);
            this.Controls.Add(this.dataGridView_avicsv);
            this.Controls.Add(this.button_pause);
            this.Controls.Add(this.button_play);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Name = "Form_MappingInterface";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mapping interface";
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_avicsv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_itbcsv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_combine)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Button button_play;
        private System.Windows.Forms.Button button_pause;
        private System.Windows.Forms.DataGridView dataGridView_avicsv;
        private System.Windows.Forms.DataGridView dataGridView_itbcsv;
        private System.Windows.Forms.TextBox CurrentPosition;
        private System.Windows.Forms.Label label_starttime;
        private System.Windows.Forms.Label label_is_readfile;
        private System.Windows.Forms.DataGridView dataGridView_combine;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.TextBox textBox_savefile_path;
        private System.Windows.Forms.Button button_filepath;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Label label_savepath;
    }
}

