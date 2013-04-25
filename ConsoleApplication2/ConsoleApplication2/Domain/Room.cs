using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
		class Room: System.Object {
			/// <summary>
			/// Default constructor of the Room class.
			/// </summary>
			public Room() {
				setID("000");
			}

			/// <summary>
			/// The class constructor sets the properties for the room object.
			/// </summary>
			/// <param name="roomNum">String value for the name/number of the room in the building.</param>
			/// <param name="capacity">Integer value for the setting the maximum capacity.</param>
			public Room(string roomNum, int capacity) {
				setID("000");
				setRoomNumber(roomNum);
				setCapacity(capacity);
			}

			/// <summary>
			/// ID will be used for identifying the Room in the database.
			/// </summary>
			private string ID;

			/// <summary>
			/// The maximum number of students that a room can host.
			/// </summary>
			private int capacity;

			/// <summary>
			/// The room number is the number/name of the room in the building.
			/// </summary>
			private string roomNumber;

			/// <summary>
			/// The room type specifies the purpose of the room used for.
			/// </summary>
			private string roomType;

			/// <summary>
			/// The time slots that a room is not available for hosting a class
			/// </summary>
			private string slotsOff;

			/// <summary>
			/// This methods retrieves the room capacity of the room object and returns it to user.
			/// </summary>
			/// <returns>Integer</returns>
			public int getCapacity() {
				return this.capacity;
			}

			/// <summary>
			/// This method retreives the ID of the room in the database and return it to user.
			/// </summary>
			/// <returns>String</returns>
			public string getID() {
				return this.ID;
			}

			/// <summary>
			/// This method retrieves the room number of the room object and returns it to user.
			/// </summary>
			/// <returns>String</returns>
			public string getRoomNumber() {
				return this.roomNumber;
			}

			/// <summary>
			/// This method retrieves the room type of the room object and returns it to user.
			/// </summary>
			/// <returns>String</returns>
			public string getRoomType() {
				return this.roomType;
			}

			/// <summary>
			/// This method retreives the room object and returns the user timeslots that a room is not available.
			/// </summary>
			/// <returns>String</returns>
			public string getSlotsOff() {
				return this.slotsOff;
			}

			/// <summary>
			/// The integer parameter received by this method is set as the maximum capacity of the room.
			/// </summary>
			/// <param name="capacity">Maximum number of people that a room host.</param>
			public void setCapacity(int capacity) {
				this.capacity = capacity;
			}

			/// <summary>
			/// The string parameter received by this method is assigned as the ID of the room in the database.
			/// </summary>
			/// <param name="ID"></param>
			public void setID(string ID) {
				this.ID = ID;
			}

			/// <summary>
			/// The parameter reveived by this method is assigned as the Room Number in the Room object.
			/// </summary>
			/// <param name="roomNumber">String value for the name/number of the room in the building.</param>
			public void setRoomNumber(String roomNumber) {
				this.roomNumber = roomNumber;
			}

			/// <summary>
			/// The string parameter received by this method is set as the room type.
			/// </summary>
			/// <param name="roomType">Room Type i.e. "Lab","Lecture Hall"</param>
			public void setRoomType(string roomType) {
				this.roomType = roomType;
			}

			/// <summary>
			/// The string parameter received by this method specifies the different time slots that the room is not available.
			/// </summary>
			/// <param name="s">String that holds the information for timeslots that are room is not available.</param>
			public void setSlotsOff(string s) {
				this.slotsOff = s;
			}
		}

}
