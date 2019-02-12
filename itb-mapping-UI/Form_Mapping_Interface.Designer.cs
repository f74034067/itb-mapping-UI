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
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(12, 36);
            this.axWindowsMediaPlayer1.Margin = new System.Windows.Forms.Padding(4);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(473, 299);
            this.axWindowsMediaPlayer1.TabIndex = 0;
            // 
            // button_play
            // 
            this.button_play.Location = new System.Drawing.Point(15, 426);
            this.button_play.Margin = new System.Windows.Forms.Padding(4);
            this.button_play.Name = "button_play";
            this.button_play.Size = new System.Drawing.Size(80, 26);
            this.button_play.TabIndex = 3;
            this.button_play.Text = "Play";
            this.button_play.UseVisualStyleBackColor = true;
            this.button_play.Click += new System.EventHandler(this.button_Play);
            // 
            // button_stop
            // 
            this.button_stop.Location = new System.Drawing.Point(103, 426);
            this.button_stop.Margin = new System.Windows.Forms.Padding(4);
            this.button_stop.Name = "button_stop";
            this.button_stop.Size = new System.Drawing.Size(80, 26);
            this.button_stop.TabIndex = 4;
            this.button_stop.Text = "Stop";
            this.button_stop.UseVisualStyleBackColor = true;
            this.button_stop.Click += new System.EventHandler(this.button_Stop);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(260, 426);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(80, 26);
            this.button4.TabIndex = 5;
            this.button4.Text = "ITB File";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form_MappingInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1297, 562);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button_stop);
            this.Controls.Add(this.button_play);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form_MappingInterface";
            this.Text = "Mapping interface";
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Button button_play;
        private System.Windows.Forms.Button button_stop;
        private System.Windows.Forms.Button button4;
    }
}

