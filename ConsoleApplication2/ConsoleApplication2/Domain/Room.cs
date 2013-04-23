using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    class Room
    {
        private string ID;
        private string roomNumber;
        private int capacity;
        private string roomType;
        private string slotsOff;

        /// <summary>
        ///     Defualt Constructer
        /// </summary>
        public Room()
        {
            setID("000");
        }
        /// <summary>
        ///     Constructer that set properties
        /// </summary>
        /// <param name="roomNum"></param>
        /// <param name="capacity"></param>
        public Room(string roomNum, int capacity)
        {
            setID("000");
            setRoomNumber(roomNum);
            setCapacity(capacity);
        }

        //Get and Set Methods
        /// <summary>
        ///     Set the ID of the room
        /// </summary>
        /// <param name="ID"></param>
        public void setID(string ID)
        {
            this.ID = ID;
        }
        /// <summary>
        ///     Get the ID of the room
        /// </summary>
        /// <returns></returns>
        public string getID()
        {
            return this.ID;
        }
        /// <summary>
        ///     set number of the room
        /// </summary>
        /// <param name="roomNumber"></param>
        public void setRoomNumber(String roomNumber)
        {
            this.roomNumber = roomNumber;
        }
        /// <summary>
        ///     get number of the room
        /// </summary>
        /// <returns></returns>
        public string getRoomNumber()
        {
            return this.roomNumber;
        }
        /// <summary>
        ///     set capacity of the room
        /// </summary>
        /// <param name="capacity"></param>
        public void setCapacity(int capacity)
        {
            this.capacity = capacity;
        }
        /// <summary>
        ///     get the capacity of the room
        /// </summary>
        /// <returns></returns>
        public int getCapacity()
        {
            return this.capacity;
        }
        /// <summary>
        ///     set the type of the room
        /// </summary>
        /// <param name="roomType"></param>
        public void setRoomType(string roomType)
        {
            this.roomType = roomType;
        }
        /// <summary>
        ///     get the type of the room
        /// </summary>
        /// <returns></returns>
        public string getRoomType()
        {
            return this.roomType;
        }
        /// <summary>
        ///     set Time Slots Off
        /// </summary>
        /// <param name="s"></param>
        public void setSlotsOff(string s)
        {
            this.slotsOff = s;
        }
        /// <summary>
        ///     get Time Slots Off
        /// </summary>
        /// <returns></returns>
        public string getSlotsOff()
        {
            return this.slotsOff;
        }
    }

}
