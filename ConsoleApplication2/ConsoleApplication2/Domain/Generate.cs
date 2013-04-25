using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    class Generate
    {
        DomainControler controler = DomainControler.getInstance();  
        LinkedList population; //linked list of chromosome

        private LinkedList roomList;
        private LinkedList moduleList;

        int[] chromosome;
        
        /// <summary>
        /// Constructer
        /// </summary>
        public Generate()
        {
            roomList = controler.getAllRooms() ;
        }
        /// <summary>
        /// generate a random timeslot for a lesson
        /// </summary>
        /// <returns></returns>
        public string generateRandomTimeSlot()
        {
            Random random = new Random();
            string timeslot;
            int temp = random.Next(0,45);
            
            if (temp < 10)
            {
                timeslot = "0" + temp;
            }
            else
            {
                timeslot = temp.ToString();
            }
            return timeslot;
        }



    }
}
