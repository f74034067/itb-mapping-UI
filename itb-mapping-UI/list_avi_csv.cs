using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace itb_mapping_UI
{
    public class list_avi_csv
    {
        //建立 time_vedio, objectID, time_enter, time_exit, car_lane, car_type 欄位
        private string time_vedio;
        private string objectID;
        private string time_enter;
        private string time_exit;
        private string car_lane;
        private string car_type;

        public string Time_vedio
        {
            get { return time_vedio; }
            set { time_vedio = value; }
        }
        public string ObjectID
        {
            get { return objectID; }
            set { objectID = value; }
        }
        public string Time_enter
        {
            get { return time_enter; }
            set { time_enter = value; }
        }
        public string Time_exit
        {
            get { return time_exit; }
            set { time_exit = value; }
        }
        public string Car_lane
        {
            get { return car_lane; }
            set { car_lane = value; }
        }
        public string Car_type
        {
            get { return car_type; }
            set { car_type = value; }
        }

    }
}
