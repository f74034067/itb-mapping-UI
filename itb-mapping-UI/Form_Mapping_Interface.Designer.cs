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
            this.button_stop = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dataGridView_avicsv = new System.Windows.Forms.DataGridView();
            this.dataGridView__itbcsv = new System.Windows.Forms.DataGridView();
            this.CurrentPosition = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_avicsv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView__itbcsv)).BeginInit();
            this.SuspendLayout();
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(12, 36);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(473, 299);
            this.axWindowsMediaPlayer1.TabIndex = 0;
            this.axWindowsMediaPlayer1.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.axWindowsMediaPlayer1_PlayStateChange);
            this.axWindowsMediaPlayer1.PositionChange += new AxWMPLib._WMPOCXEvents_PositionChangeEventHandler(this.axWindowsMediaPlayer1_PositionChange);
            // 
            // button_play
            // 
            this.button_play.Location = new System.Drawing.Point(9, 274);
            this.button_play.Name = "button_play";
            this.button_play.Size = new System.Drawing.Size(60, 21);
            this.button_play.TabIndex = 3;
            this.button_play.Text = "Play";
            this.button_play.UseVisualStyleBackColor = true;
            this.button_play.Click += new System.EventHandler(this.button_Play);
            // 
            // button_stop
            // 
            this.button_stop.Location = new System.Drawing.Point(75, 274);
            this.button_stop.Name = "button_stop";
            this.button_stop.Size = new System.Drawing.Size(60, 21);
            this.button_stop.TabIndex = 4;
            this.button_stop.Text = "Stop";
            this.button_stop.UseVisualStyleBackColor = true;
            this.button_stop.Click += new System.EventHandler(this.button_Stop);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(0, 0);
            this.button4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(56, 18);
            this.button4.TabIndex = 0;
            // 
            // dataGridView_avicsv
            // 
            this.dataGridView_avicsv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_avicsv.Location = new System.Drawing.Point(382, 37);
            this.dataGridView_avicsv.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView_avicsv.Name = "dataGridView_avicsv";
            this.dataGridView_avicsv.RowTemplate.Height = 27;
            this.dataGridView_avicsv.Size = new System.Drawing.Size(367, 212);
            this.dataGridView_avicsv.TabIndex = 5;
            // 
            // dataGridView__itbcsv
            // 
            this.dataGridView__itbcsv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView__itbcsv.Location = new System.Drawing.Point(9, 319);
            this.dataGridView__itbcsv.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView__itbcsv.Name = "dataGridView__itbcsv";
            this.dataGridView__itbcsv.RowTemplate.Height = 27;
            this.dataGridView__itbcsv.Size = new System.Drawing.Size(740, 206);
            this.dataGridView__itbcsv.TabIndex = 6;
            // 
            // CurrentPosition
            // 
            this.CurrentPosition.Location = new System.Drawing.Point(75, 0);
            this.CurrentPosition.Name = "CurrentPosition";
            this.CurrentPosition.Size = new System.Drawing.Size(60, 22);
            this.CurrentPosition.TabIndex = 7;
            // 
            // Form_MappingInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 598);
            this.Controls.Add(this.CurrentPosition);
            this.Controls.Add(this.dataGridView__itbcsv);
            this.Controls.Add(this.dataGridView_avicsv);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button_stop);
            this.Controls.Add(this.button_play);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Name = "Form_MappingInterface";
            this.Text = "Mapping interface";
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_avicsv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView__itbcsv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Button button_play;
        private System.Windows.Forms.Button button_stop;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dataGridView_avicsv;
        private System.Windows.Forms.DataGridView dataGridView__itbcsv;
        private System.Windows.Forms.TextBox CurrentPosition;
    }
}

