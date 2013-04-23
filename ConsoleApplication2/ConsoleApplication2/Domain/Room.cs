﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    class Room
    {
        /// <summary>
        /// ID will be used for identifying the Room in the database.
        /// </summary>
        private string ID; 
        /// <summary>
        /// The room number is the number/name of the room in the building.
        /// </summary>
        private string roomNumber;
        /// <summary>
        /// The maximum number of students that a room can host.
        /// </summary>
        private int capacity;
        /// <summary>
        /// The room type specifies the purpose of the room used for.
        /// </summary>
        private string roomType;
        /// <summary>
        /// The time slots that a room is not available for hosting a class
        /// </summary>
        private string slotsOff;

        /// <summary>
        /// Default constructor of the Room class.
        /// </summary>
        public Room()
        {
            setID("000");
        }
        /// <summary>
        /// The class constructor sets the properties for the room object.
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
        ///  The string parameter received by this method is assigned as the ID of the room in the database.
        /// </summary>
        /// <param name="ID"></param>
        public void setID(string ID)
        {
            this.ID = ID;
        }
        /// <summary>
        ///  This method retreives the ID of the room in the database and return it to user.
        /// </summary>
        /// <returns></returns>
        public string getID()
        {
            return this.ID;
        }
        /// <summary>
        ///  The parameter reveived by this method is assigned as the Room Number in the Room object.
        /// </summary>
        /// <param name="roomNumber"></param>
        public void setRoomNumber(String roomNumber)
        {
            this.roomNumber = roomNumber;
        }
        /// <summary>
        ///  This method retrieves the room number of the room object and returns it to user.
        /// </summary>
        /// <returns>String</returns>
        public string getRoomNumber()
        {
            return this.roomNumber;
        }
        /// <summary>
        ///  The integer parameter received by this method is set as the maximum capacity of the room.
        /// </summary>
        /// <param name="capacity"></param>
        public void setCapacity(int capacity)
        {
            this.capacity = capacity;
        }
        /// <summary>
        ///   This methods retrieves the room capacity of the room object and returns it to user.
        /// </summary>
        /// <returns></returns>
        public int getCapacity()
        {
            return this.capacity;
        }
        /// <summary>
        ///    The string parameter received by this method is set as the room type. i.e. "Lab","Lecture Hall".
        /// </summary>
        /// <param name="roomType"></param>
        public void setRoomType(string roomType)
        {
            this.roomType = roomType;
        }
        /// <summary>
        ///    This method retrieves the room type of the room object and returns it to user.
        /// </summary>
        /// <returns></returns>
        public string getRoomType()
        {
            return this.roomType;
        }
        /// <summary>
        ///    The string parameter received by this method specifies the different time slots that the room is not available.
        /// </summary>
        /// <param name="s"></param>
        public void setSlotsOff(string s)
        {
            this.slotsOff = s;
        }
        /// <summary>
        /// This method retreives the room object and returns the user timeslots that a room is not available.
        /// </summary>
        /// <returns></returns>
        public string getSlotsOff()
        {
            return this.slotsOff;
        }
    }

}