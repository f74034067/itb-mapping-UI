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
using System.Collections.Specialized; //NameValueCollection
using System.Timers;
//using System.Globalization;


namespace itb_mapping_UI
{
    public partial class Form_MappingInterface : Form
    {
        private System.Timers.Timer _TimersTimer;
        public Form_MappingInterface(string filepath_avi, string filepath_avicsv, string filepath_itbcsv,DateTime StartTime)
        {
            //starttime = "2018/10/4 下午 03:00:07"
            InitializeComponent();
            this._TimersTimer = new System.Timers.Timer();
            this._TimersTimer.Interval = 1000;
            this._TimersTimer.SynchronizingObject = this;
            this._TimersTimer.Elapsed += new System.Timers.ElapsedEventHandler(_TimersTimer_Elapsed);
            // show file path
            /*
            MessageBox.Show("1."+ filepath_avi);
            MessageBox.Show("2."+ filepath_avicsv);
            MessageBox.Show("3."+ filepath_itbcsv);
            */

            //AVI Initial setting
            axWindowsMediaPlayer1.settings.autoStart = false;
            axWindowsMediaPlayer1.URL = filepath_avi;
            //axWindowsMediaPlayer1.Ctlcontrols.stop();
            //axWindowsMediaPlayer1.uiMode = "none";

            //AVI_CSV Initial setting
            Initialize_file_avicsv(filepath_avicsv);
            //ITB_CSV Initial setting
            Initialize_file_itbcsv(filepath_itbcsv);
            //datagredview_avicsv Initial setting
            //Initialize_datagredview_avicsv();
            //datagredview_itbcsv Initial setting
            //Initialize_datagredview_itbcsv();
        }

        private void _TimersTimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            CurrentPosition.Text = axWindowsMediaPlayer1.Ctlcontrols.currentPosition.ToString();
            //throw new NotImplementedException();
        }

        private void button_Play(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void button_Stop(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.pause();
        }

        private void Initialize_file_avicsv(string filepath) {
            try
            {
                NameValueCollection NVC_avicsv = new NameValueCollection();
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
                NameValueCollection NVC_itbcsv = new NameValueCollection();
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
        private void ReadLine_And_AddIntoNVC(string filepath, NameValueCollection NVC, Action<string, NameValueCollection> AddIntoNVC) {
            try
            {
                using (StreamReader SR = new StreamReader(filepath))
                {

                    string Line;
                    while ((Line = SR.ReadLine()) != null)
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
            string time = splitline(line, timeIdx).Split('.')[0];
            //string time = init_datetime(splitline(line, timeIdx));
            // add(key,vaule) into NVC
            // key = time , value = line
            NVC.Add(time, line);
        }

        private void AddIntoNVC_itbcsv(string line, NameValueCollection NVC)
        {
            int startTimeIdx = 3;
            int endTimeIdx = 4;
            string starttime = splitline(line, startTimeIdx);
            string endtime = splitline(line, endTimeIdx);
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

        private string splitline(string line, int index)
        {
            string[] ReadLine_Array = line.Split(',');
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

        private void axWindowsMediaPlayer1_PositionChange(object sender, AxWMPLib._WMPOCXEvents_PositionChangeEvent e)
        {
            this._TimersTimer.Start();
        }

        private void axWindowsMediaPlayer1_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            this._TimersTimer.Start();
        }
    }
}