using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    class Building
    {
        /// <summary>
        /// A string containing the Id of the building.
        /// mainly used in the database
        /// </summary>
        private string ID;
        /// <summary>
        /// A string containing the name of the college
        /// </summary>
        private string name;
        /// <summary>
        /// A linked List of all the room in this building
        /// </summary>
        private LinkedList roomList;
        /// <summary>
        ///     Defuault Constructer
        ///     Sets Id to defualt 000 so as to know to use INSERT SQl command
        ///     Creates a new linkedlist and assigns it to roomlist to prevent addRoom() 
        ///     trying to add to a non-existent list
        /// </summary>
        public Building()
        {
            setId("000");
            roomList = new LinkedList();
        }

        /// <summary>
        ///     Constructer that takes name and roomList
        ///     Sets Id to defualt 000 so as to know to use INSERT SQl command
        /// </summary>
        /// <param name="name">string containing the name of the building</param>
        /// <param name="roomList">linked list of room in the building</param>
        public Building(string name, LinkedList roomList)
        {
            setId("000");
            setName(name);
            setRoomList(roomList);
        }
        /// <summary>
        ///     Adds a room to the roomList
        /// </summary>
        /// <param name="room">Room object to be added to the list</param>
        public void addRoom(Room room)
        {
            roomList.addAtTail(room);
        }
        /// <summary>
        ///     Check is a room part on the roomList for this Building
        /// </summary>
        /// <param name="room">Room object to search for in the list</param>
        /// <returns>Wether or not the room is on the lisr</returns>
        public bool isPartOf(Room room)
        {
            return roomList.searchList(room);
        }
        /// <summary>
        ///     sets the Id to the string parameter taken
        /// </summary>
        /// <param name="id">String containing the new id</param>
        public void setId(string id)
        {
            this.ID = id;
        }
        /// <summary>
        ///     return the ID of Building
        /// </summary>
        /// <returns>Id of the building</returns>
        public string getID()
        {
            return this.ID;
        }
        /// <summary>
        ///     Set name of building
        /// </summary>
        /// <param name="name">new name for the Building</param>
        public void setName(string name)
        {
            this.name = name;
        }
        /// <summary>
        ///     returns the building name
        /// </summary>
        /// <returns>Name of the building</returns>
        public string getName()
        {
            return this.name;
        }
        /// <summary>
        ///     set the list of rooms for this building
        /// </summary>
        /// <param name="roomList">new linked list of room for the building</param>
        public void setRoomList(LinkedList roomList)
        {
            this.roomList = roomList;
        }
        /// <summary>
        ///     get the list of room for this building
        /// </summary>
        /// <returns>linked lidt of rooms</returns>
        public LinkedList getRoomList()
        {
            return this.roomList;
        }
    }
}
