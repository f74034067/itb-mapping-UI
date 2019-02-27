﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;                //讀檔
using System.Collections.Specialized; //NameValueCollection
using System.Timers;
//using System.Globalization;


namespace itb_mapping_UI
{
    public partial class Form_MappingInterface : Form
    {
        NameValueCollection NVC_avicsv = new NameValueCollection();
        NameValueCollection NVC_itbcsv = new NameValueCollection();
        DateTime InitTime = new DateTime();
        private System.Timers.Timer _TimersTimer;
        int i = 0;
        public Form_MappingInterface(string filepath_avi, string filepath_avicsv, string filepath_itbcsv,DateTime StartTime)
        {
            // show file path
            /*
            MessageBox.Show("1."+ filepath_avi);
            MessageBox.Show("2."+ filepath_avicsv);
            MessageBox.Show("3."+ filepath_itbcsv);
            */
            //StartTime = "2018/10/4 下午 03:00:07"
            InitTime = StartTime;
            InitializeComponent();
            label_starttime.Text = "start time:" + InitTime.ToString();
            Initialize_timer();
            Initialize_axWindowsMediaPlayer(filepath_avi);
            //Initial AVI_CSV setting & ITB_CSV setting
            Initialize_file_avicsv(filepath_avicsv);
            Initialize_file_itbcsv(filepath_itbcsv);
            //datagredview_avicsv Initial setting & datagredview_itbcsv Initial setting
            Initialize_datagridview_avicsv(InitTime);
            Initialize_datagridview_itbcsv(InitTime);
        }
        /* ================================================
         * ============    add new things    ==============
         * ================================================*/

        /* ================================================
         * ==============    Initialize    ================
         * ================================================*/
        private void Initialize_timer() {
            this._TimersTimer = new System.Timers.Timer();
            this._TimersTimer.Interval = 1000;
            this._TimersTimer.SynchronizingObject = this;
            this._TimersTimer.Elapsed += new System.Timers.ElapsedEventHandler(_TimersTimer_Elapsed);
        }
        private void Initialize_axWindowsMediaPlayer(string filepath) {
            axWindowsMediaPlayer1.settings.autoStart = false;
            axWindowsMediaPlayer1.URL = filepath;
            //axWindowsMediaPlayer1.Ctlcontrols.stop();
            //axWindowsMediaPlayer1.uiMode = "none";
        }
        private void Initialize_file_avicsv(string filepath) {
            try
            {
                //NameValueCollection NVC_avicsv = new NameValueCollection();
                ReadLine_And_AddIntoNVC(filepath, NVC_avicsv, AddIntoNVC_avicsv);
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("NullReferenceException: Initialize_avicsv");
            }
            catch (FormatException)
            {
                MessageBox.Show("FormatException:  Initialize_avicsv");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ": Initialize_avicsv");
            }
        }
        private void Initialize_file_itbcsv(string filepath)
        {
            try
            {
                //NameValueCollection NVC_itbcsv = new NameValueCollection();
                ReadLine_And_AddIntoNVC(filepath, NVC_itbcsv, AddIntoNVC_itbcsv);

            }
            catch (NullReferenceException)
            {
                MessageBox.Show("NullReferenceException: Initialize_itbcsv");
            }
            catch (FormatException)
            {
                MessageBox.Show("FormatException:  Initialize_itbcsv");
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message + ": Initialize_itbcsv");
            }

        }
        private void Initialize_datagridview_avicsv(DateTime StartTime)
        {
            setup_datagridview_avicsv();
            //initial time = StartTime
            //print data form initial_time
            print_DataGridViews_avicsv(StartTime);
        }
        private void Initialize_datagridview_itbcsv(DateTime StartTime)
        {
            setup_datagridview_itbcsv();
            //initial time = StartTime
            //print data form initial_time
            print_DataGridViews_itbcsv(StartTime);
        }

        /* ================================================
         * =============    File Handle    ================
         * ================================================*/
        private void ReadLine_And_AddIntoNVC(string filepath, NameValueCollection NVC, Action<string, NameValueCollection> AddIntoNVC) {
            try
            {
                using (StreamReader SR = new StreamReader(filepath, System.Text.Encoding.GetEncoding(950)) )
                {

                    string Line;
                    while ((Line = SR.ReadLine())!=null && Line != "")
                    {
                        //dothings
                        AddIntoNVC(Line, NVC);
                    }
                }
            }
            catch (IOException)
            {
                MessageBox.Show("IOException:readline_and_AddIntoNVC");
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("NullReferenceException:readline_and_AddIntoNVC");
            }
            catch (FormatException)
            {
                MessageBox.Show("FormatException:readline_and_AddIntoNVC");
            }
        }
        private void AddIntoNVC_avicsv(string line, NameValueCollection NVC)
        {

            int timeIdx = 0;
            string time = splitline(line, timeIdx,',').Split('.')[0];
            //00:00:07
            string[] time_array = time.Split(':');
            DateTime time_avicsv = new DateTime();
            time_avicsv = InitTime;
            time_avicsv = time_avicsv.AddHours(Convert.ToDouble(time_array[0]));
            time_avicsv=time_avicsv.AddMinutes(Convert.ToDouble(time_array[1]));
            time_avicsv=time_avicsv.AddSeconds(Convert.ToDouble(time_array[2]));
            // add(key,vaule) into NVC
            // key = time , value = line
            NVC.Add(time_avicsv.ToString(), line);
        }

        private void AddIntoNVC_itbcsv(string line, NameValueCollection NVC)
        {
            int startTimeIdx = 3;
            int endTimeIdx = 4;
            char SplitChar = '/';
            string starttime = splitline(line, startTimeIdx, SplitChar);
            string endtime = splitline(line, endTimeIdx, SplitChar);
            //string starttime_UnMSec = init_datetime(String.Copy(starttime.Split('.')[0]));
            //string endtime_UnMSec = init_datetime(String.Copy(endtime.Split('.')[0]));
            string starttime_UnMSec = init_datetime(starttime);
            string endtime_UnMSec = init_datetime(endtime);

            //for loop form starttime to endtime
            if (is_time_LessThanOrEqual(starttime_UnMSec, endtime_UnMSec))
            {
                do
                {
                    // add(key,vaule) into NVC
                    // key = starttime , value = line
                    NVC.Add(starttime_UnMSec, line);
                    //whileloop control
                    starttime_UnMSec = addSecond(starttime_UnMSec, 1);
                } while (is_time_LessThanOrEqual(starttime_UnMSec, endtime_UnMSec));
            }
            else
            {
                MessageBox.Show("Exception: Exist starttime bigeer than endtime in Itbcsv file," + line);
            }
        }

        private string splitline(string line, int index,char SplitChar)
        {
            string[] ReadLine_Array = line.Split(SplitChar);
            return ReadLine_Array[index];
        }
        private bool is_time_LessThanOrEqual(string start, string end)
        {
            try
            {
                DateTime date_start = DateTime.Parse(start);
                try
                {
                    DateTime date_end = DateTime.Parse(end);
                    if (date_start <= date_end)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show("FormatException:is_time_LessThanOrEqual," + end);
                }
            }
            catch (FormatException) {
                MessageBox.Show("FormatException:is_time_LessThanOrEqual,"+ start);
                
            }
            return false;
        }
        private string addSecond(string time,double addValue)
        {
            DateTime date_time = DateTime.Parse(time);
            date_time =date_time.AddSeconds(addValue);
            return date_time.ToString();
        }
        private string init_datetime(string time) {
            DateTime date_time = DateTime.Parse(time);
            return date_time.ToString();
        }

        /* ================================================
        * =============    DataGridView    ===============
        * ================================================*/
        private void setup_datagridview_avicsv()
        {
            dataGridView_avicsv.ColumnCount = 6;
            dataGridView_avicsv.ColumnHeadersDefaultCellStyle.Font = new Font(dataGridView_avicsv.Font, FontStyle.Bold);
            dataGridView_avicsv.Columns[0].Name = "Vedio Time";
            dataGridView_avicsv.Columns[1].Name = "Object ID";
            dataGridView_avicsv.Columns[2].Name = "Time enter";
            dataGridView_avicsv.Columns[3].Name = "Time leave";
            dataGridView_avicsv.Columns[4].Name = "Lane(in/out)";
            dataGridView_avicsv.Columns[5].Name = "Vehicle Type";
        }
        private void setup_datagridview_itbcsv()
        {
            dataGridView_itbcsv.ColumnCount = 7;
            dataGridView_itbcsv.Columns[0].Name = "ID";
            dataGridView_itbcsv.Columns[1].Name = "ITB ID";
            dataGridView_itbcsv.Columns[2].Name = "MAC Address";
            dataGridView_itbcsv.Columns[3].Name = "Start Time";
            dataGridView_itbcsv.Columns[4].Name = "MaxRSSI Time";
            dataGridView_itbcsv.Columns[5].Name = "Max RSSI";
            dataGridView_itbcsv.Columns[6].Name = "Avg RSSI";
        }
        private void clear_DaraGridViews_all()
        {
            dataGridView_avicsv.Rows.Clear();
            dataGridView_itbcsv.Rows.Clear();
        }
        private void print_DaraGridViews_all(DateTime time)
        {
            print_DataGridViews_avicsv(time);
            print_DataGridViews_itbcsv(time);
        }

        private void print_DataGridViews_avicsv(DateTime time)
        {
            dataGridView_avicsv.Rows.Clear();
            String lines = NVC_avicsv.Get(time.ToString());
            //split lines to line by ","
            if (lines != null)
            {
                string[] lines_Array = lines.Split(',');
                foreach (var line in lines_Array)
                {
                    string[] line_Array = line.Split('/');
                    dataGridView_avicsv.Rows.Add(line_Array);
                }
            }
        }
        private void print_DataGridViews_itbcsv(DateTime time)
        {
            dataGridView_itbcsv.Rows.Clear();

            String lines = NVC_itbcsv.Get(time.ToString());
            //split lines to line by ","
            if (lines != null)
            {
                string[] lines_Array = lines.Split(',');
                foreach (var line in lines_Array)
                {
                    string[] line_Array = line.Split('/');
                    dataGridView_itbcsv.Rows.Add(line_Array);
                }
            }
        }

        /* ================================================
         * ================    button    ==================
         * ================================================*/
        private void button_Play(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }
        private void button_Stop(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.pause();
        }

        /* ================================================
         * ============    axwindowplayer    ==============
         * ================================================*/
        private void axWindowsMediaPlayer1_PositionChange(object sender, AxWMPLib._WMPOCXEvents_PositionChangeEvent e)
        {
            //MessageBox.Show("axWindowsMediaPlayer1_PositionChange");
            //this._TimersTimer.Start();
            //更新datagredview
            shownow_DataGridViews();
        }
        private void axWindowsMediaPlayer1_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            try
            {
                switch (axWindowsMediaPlayer1.playState)
                {
                    case WMPLib.WMPPlayState.wmppsPlaying:
                        this._TimersTimer.Start();
                        shownow_DataGridViews();
                        break;
                    case WMPLib.WMPPlayState.wmppsPaused:
                        this._TimersTimer.Stop();
                        break;
                    case WMPLib.WMPPlayState.wmppsStopped:
                        this._TimersTimer.Stop();
                        clear_DaraGridViews_all();
                        print_DaraGridViews_all(InitTime);
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("axWindowsMediaPlayer1_PlayStateChange:" + ex.Message);
            }
        }
        private void _TimersTimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            //		axWindowsMediaPlayer1.Ctlcontrols.currentPosition	1.6371222	double
            CurrentPosition.Text = axWindowsMediaPlayer1.Ctlcontrols.currentPosition.ToString();
            /*
            i++;
            CurrentPosition.Text = i.ToString();
            */
            shownow_DataGridViews();
        }
        private void shownow_DataGridViews() {
            DateTime nowtime = InitTime;
            nowtime = nowtime.AddSeconds(axWindowsMediaPlayer1.Ctlcontrols.currentPosition);
            clear_DaraGridViews_all();
            print_DaraGridViews_all(nowtime);
        }
    }
}