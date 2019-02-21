using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;


namespace itb_mapping_UI
{
    public partial class Form_Readfile : Form
    {
        public Form_Readfile()
        {
            InitializeComponent();
            InitializeStartTime();
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
            //get start_time information
            CultureInfo provider = CultureInfo.InvariantCulture;
            DateTime StartTime = new DateTime();
            StartTime = DateTime.ParseExact(dropdownlist_year.SelectedItem.ToString(),"yyyy年", provider);
            StartTime = DateTime.ParseExact(dropdownlist_month.SelectedItem.ToString(), "MM月", provider);
            StartTime = DateTime.ParseExact(dropdownlist_days.SelectedItem.ToString(), "dd日", provider);
            StartTime = DateTime.ParseExact(dropdownlist_hours.SelectedItem.ToString(), "HH時", provider);
            StartTime = DateTime.ParseExact(dropdownlist_min.SelectedItem.ToString(), "mm分", provider);
            StartTime = DateTime.ParseExact(dropdownlist_sec.SelectedItem.ToString(), "ss秒", provider);
            
            //test file exists
            /*testbox information*/
            this.textBox_avifile.Text = "C:\\Users\\Kevin\\Desktop\\MAH00761.MP4";
            this.textBox_avi_csv.Text = "C:\\Users\\black\\Desktop\\test_avi.csv";
            this.textBox_itbfile.Text = "C:\\Users\\black\\Desktop\\test_mapping_data.csv";

            if (this.textBox_avifile.Text.Equals("")|| this.textBox_avi_csv.Text.Equals("")|| this.textBox_itbfile.Text.Equals(""))
            {   //retry
                DialogResult result = MessageBox.Show("Please choose the file path and try again");  
            }
            else
            {
                //open form_mapping_interface
                Form_MappingInterface form_mapping_interface = new Form_MappingInterface(this.textBox_avifile.Text, this.textBox_avi_csv.Text, this.textBox_itbfile.Text,StartTime);
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


        private void InitializeStartTime() {
            for (int i = -1; i < 5; i++)
            {
                dropdownlist_year.Items.Add( (DateTime.Now.AddYears(i).ToString("yyyy年")) );
            }
            for (int i = 0; i < 12; i++)
            {
                dropdownlist_month.Items.Add((DateTime.Now.AddMonths(i).ToString("MM月")));
            }
            for (int i = 0; i < 62; i++)
            {
                dropdownlist_days.Items.Add((DateTime.Now.AddDays(i).ToString("dd日")));
            }
            for (int i = 0; i < 24; i++)
            {
                dropdownlist_hours.Items.Add((DateTime.Now.AddHours(i).ToString("HH時")));
            }
            for (int i = 0; i < 60; i++)
            {
                dropdownlist_min.Items.Add((DateTime.Now.AddMinutes(i).ToString("mm分")));
            }
            for (int i = 0; i < 60; i++)
            {
                dropdownlist_sec.Items.Add((DateTime.Now.AddSeconds(i).ToString("ss秒")));
            }
            dropdownlist_year.SelectedIndex = 1;
            dropdownlist_month.SelectedIndex = 0;
            dropdownlist_days.SelectedIndex = 0;
            dropdownlist_hours.SelectedIndex = 0;
            dropdownlist_min.SelectedIndex = 0;
            dropdownlist_sec.SelectedIndex = 0;
        }
    }
}
