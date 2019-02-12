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
        public Form_MappingInterface()
        {
            InitializeComponent();
        }
        private void button_Play(object sender, EventArgs e)
        {
            //axWindowsMediaPlayer1.URL = textBox1.Text;
            //axWindowsMediaPlayer1.Ctlcontrols.play();
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
