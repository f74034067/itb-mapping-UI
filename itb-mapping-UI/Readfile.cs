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
    public partial class Readfile : Form
    {
        public Readfile()
        {
            InitializeComponent();
        }

        private void button_read_avifile_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.RestoreDirectory = true;
            file.InitialDirectory = "c:\\";
            file.Title = "Open AVI File";
            file.Filter = "avi影像檔|*.avi|所有檔|*.*";
            file.FilterIndex = 1;

            if (file.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //this.textBox_avifile.Text = file.SafeFileName;
                this.textBox_avifile.Text = file.FileName;
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

        }
    }
}
