using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace itb_mapping_UI
{
    public partial class Form_Readfile : Form
    {
        public Form_Readfile()
        {
            InitializeComponent();
        }

        private void button_read_avifile_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.RestoreDirectory = true;
            file.InitialDirectory = "c:\\";
            file.Title = "Open AVI File";
            file.Filter = "所有影像檔|*.mp4;*.avi|所有檔|*.*";
            file.FilterIndex = 1;

            if (file.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //this.textBox_avifile.Text = file.SafeFileName;
                this.textBox_avifile.Text = file.FileName;
            }


        }
        private void button_read_avi_csvfile_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.RestoreDirectory = true;
            file.InitialDirectory = "c:\\";
            file.Title = "Open AVI_CSV File";
            file.Filter = "csv檔|*.csv|文字檔|*.txt|所有檔|*.*";
            file.FilterIndex = 1;

            if (file.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //this.textBox_itbfile.Text = file.SafeFileName;
                this.textBox_avi_csv.Text = file.FileName;
            }

        }

        private void button_read_itbfile_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.RestoreDirectory = true;
            file.InitialDirectory = "c:\\";
            file.Title = "Open ITB File";
            file.Filter = "csv檔|*.csv|文字檔|*.txt|所有檔|*.*";
            file.FilterIndex = 1;

            if (file.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //this.textBox_itbfile.Text = file.SafeFileName;
                this.textBox_itbfile.Text = file.FileName;
            }
        }

        private void button_confirm_Click(object sender, EventArgs e)
        {
            /*testbox information*/
            this.textBox_avifile.Text = "C:\\Users\\black\\Desktop\\MAH00761.MP4";
            this.textBox_avi_csv.Text = "C:\\Users\\black\\Desktop\\MAH00761.MP4";
            this.textBox_itbfile.Text = "C:\\Users\\black\\Desktop\\MAH00761.MP4";
            
            if (this.textBox_avifile.Text.Equals("")|| this.textBox_avi_csv.Text.Equals("")|| this.textBox_itbfile.Text.Equals(""))
            {   //retry
                DialogResult result = MessageBox.Show("Please choose the file path and try again");  
            }
            else
            {
                Form_MappingInterface form_mapping_interface = new Form_MappingInterface(this.textBox_avifile.Text, this.textBox_avi_csv.Text, this.textBox_itbfile.Text);
                this.Visible = false;
                form_mapping_interface.ShowDialog();
            }
            //this.Close();
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            this.Close();
            Environment.Exit(Environment.ExitCode);
        }


    }
}
