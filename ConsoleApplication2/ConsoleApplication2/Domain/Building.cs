using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    class Building
    {
        private string ID;
        private string name;
        private LinkedList roomList;

        /// <summary>
        ///     Defuault Constructer
        /// </summary>
        public Building()
        {
            setId("000");
            roomList = new LinkedList();
        }

        /// <summary>
        ///     Constructer and set properties
        /// </summary>
        /// <param name="name"></param>
        /// <param name="roomList"></param>
        public Building(string name, LinkedList roomList)
        {
            setId("000");
            setName(name);
            setRoomList(roomList);
        }

      //other methods
        /// <summary>
        ///     Add a room to this building
        /// </summary>
        /// <param name="room"></param>
        public void addRoom(Room room)
        {
            roomList.addAtTail(room);
        }
        /// <summary>
        ///     Check is a room part of this building
        /// </summary>
        /// <param name="room"></param>
        /// <returns></returns>
        public bool isPartOf(Room room)
        {
            return roomList.searchList(room);
        }

     //Get & Set Methods
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        public void setId(string id)
        {
            this.ID = id;
        }
        /// <summary>
        ///     return the ID the Building
        /// </summary>
        /// <returns></returns>
        public string getID()
        {
            return this.ID;
        }
        /// <summary>
        ///     Set name of building
        /// </summary>
        /// <param name="name"></param>
        public void setName(string name)
        {
            this.name = name;
        }
        /// <summary>
        ///     Get the building name
        /// </summary>
        /// <returns></returns>
        public string getName()
        {
            return this.name;
        }
        /// <summary>
        ///     set the list of rooms for this building
        /// </summary>
        /// <param name="roomList"></param>
        public void setRoomList(LinkedList roomList)
        {
            this.roomList = roomList;
        }
        /// <summary>
        ///     get the list of room for this building
        /// </summary>
        /// <returns></returns>
        public LinkedList getRoomList()
        {
            return this.roomList;
        }
       


    }
}
