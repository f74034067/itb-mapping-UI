using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;                //讀檔

namespace itb_mapping_UI
{
    public partial class Form_MappingInterface : Form
    {
        public Form_MappingInterface(string filepath_avi, string filepath_avicsv, string filepath_itbcsv)
        {
            InitializeComponent();
            // show file path
            /*
            MessageBox.Show("1."+ filepath_avi);
            MessageBox.Show("2."+ filepath_avicsv);
            MessageBox.Show("3."+ filepath_itbcsv);
            */
            axWindowsMediaPlayer1.URL = filepath_avi;
            //this.axWindowsMediaPlayer1.uiMode = "none";
            axWindowsMediaPlayer1.Ctlcontrols.stop();
        }
        private void button_Play(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void button_Stop(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.pause();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            /*
            //選擇 ITB.csv
            OpenFileDialog openFileDialog2 = new OpenFileDialog();
            if (openFileDialog2.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.textBox2.Text = openFileDialog2.FileName;
            }

            StreamReader sr = new StreamReader(path: textBox2.Text);
            while(!sr.EndOfStream)
            {
                string line = sr.ReadLine();
                string[] item = line.Split(',');
            }
            sr.Close();
            */
        }

    }
}
