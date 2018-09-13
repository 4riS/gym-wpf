using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymAAY
{
    class var
    {

        public static Boolean morning;
        public static Boolean midday;
        public static Boolean afternoon;
        public static Boolean night;
        private static TimeSpan  open = new TimeSpan(09, 0, 0);
        private static TimeSpan mid = new TimeSpan(12, 0, 0);
        private static TimeSpan aft = new TimeSpan(18, 0, 0);
        private static TimeSpan close = new TimeSpan(22, 0, 0);
        private static TimeSpan now = DateTime.Now.TimeOfDay;

        /* General */
        public static bool gymLights = true;
        public static bool air_condition = true;
        public static bool tv_on = true;
        public static bool radio_on = true;



        /* For the pool */
        public static Random rnd = new Random();
        public static int peopleInPool = rnd.Next(0, 5);
        public static string pool_water = "Medium";
        public static int temperature = 25;
        public static bool alarm_pool = false;
        public static bool isVisitedPool = false;

        public static void get_hour()
        {
            if (now > open && now < mid)
            {
                morning = true;
            }
            else
            {
                morning = false;
            }
            if (now>mid && now<aft)
            {
                midday = true;
            }
            else
            {
                midday = false;
            }
            if(now>aft && now<close)
            {
                afternoon = true;
            }
            else
            {
                afternoon = false;
            }
            if (now<open && now>close)
            {
                night = true;
            }
            else
            {
                night = false;
            }
        }
    }
}
