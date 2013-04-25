using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Services;

namespace Domain
{
    class TimeTable
    {
        /// <summary>
        /// List of available time slots in format max 45 slots
        /// 00:01:02:03..........43:44
        /// </summary>
        private string timeSlots;
       


        /// <summary>
        /// Constructer 
        /// </summary>
        public TimeTable()
        {
            initializeTimeSlots();
        }


        /// <summary>
        /// Initializes the time slots string to all slots available
        /// </summary>
        private void initializeTimeSlots()
        {
        
            for (int i = 0; i < 45; i++)
            {
                if (i < 10)
                {
                   this.timeSlots = "0" + i;
                }
                else
                {
                    this.timeSlots = i.ToString();
                }
            }
        }
    }
}
