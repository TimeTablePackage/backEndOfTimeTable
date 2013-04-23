using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    class Module
    {
        /// <summary>
        /// ID will be used for identifying the  Module in the database.
        /// </summary>
        private string ID;
        /// <summary>
        /// Name of the module.
        /// </summary>
        private string name;
        /// <summary>
        /// Boolean value specifies whether Module has a practical lecture or not.
        /// </summary>
        private bool practical;
        /// <summary>
        /// The number of hours per week that the Module will be taught.
        /// </summary>
        private int hoursPerWeek;
        /// <summary>
        /// The room type that is required by the Module for the classes.
        /// </summary>
        private string RoomType;
        /// <summary>
        /// Specifies whether the Module can have double lectures or not.
        /// </summary>
        private bool doubleSlots;
        /// <summary>
        /// Specifies the maximum consecutive hours that the Module can be taught during the day.
        /// </summary>
        private int maxConsecHours;
        // The periods of time that the Module can not be taught.
        private string slotsOff;
        /// <summary>
        /// The list of lecturers that is able to teach the Module.
        /// </summary>
        private LinkedList lecturerList;

        /// <summary>
        ///  This method constructs a new Module object without setting any properties.
        /// </summary>
        public Module()
        {
            setId("000");
            lecturerList = new LinkedList();
        }

        /// <summary>
        ///  This method constructs a new Module object with relevant properties.
        /// </summary>
        /// <param name="name">String value will be assigned as the name of the Module</param>
        /// <param name="pratical">Boolean value specifies whether Module have a practical or not</param>
        /// <param name="hoursPerWeek">Integer value will be assigned as the number of hours the Module will be taught.</param>
        /// <param name="roomType">String value contains information about the Room type required for the Module</param>
        /// <param name="doubleSlots">Boolean value specifies wheter double lectures are allowed for the Module</param>
        /// <param name="maxConsecHours">Integer value will define the maximum consecutive hours during the day.</param>
        /// <param name="slotsOff">String value contains information about timeslots that the Module can not be taught</param>
        public Module(String name, bool pratical, int hoursPerWeek, string roomType, bool doubleSlots, int maxConsecHours, string slotsOff)
        {
            setId("000");
            setName(name);
            setPractical(practical);
            setHoursPerWeek(hoursPerWeek);
            setRoomtype(roomType);
            setDoubleSlots(doubleSlots);
            setMaxConsecHours(maxConsecHours);
            setSlotsOff(slotsOff);

        }
        /// <summary>
        ///     This method constructs a Module object with a set of properties as well as a List of Lecturers.
        /// </summary>
        /// <param name="name">String value will be assigned as the name of the Module</param>
        /// <param name="pratical">Boolean value specifies whether Module have a practical or not</param>
        /// <param name="hoursPerWeek">Integer value will be assigned as the number of hours the Module will be taught.</param>
        /// <param name="roomType">String value contains information about the Room type required for the Module</param>
        /// <param name="doubleSlots">Boolean value specifies wheter double lectures are allowed for the Module</param>
        /// <param name="maxConsecHours">Integer value will define the maximum consecutive hours during the day.</param>
        /// <param name="slotsOff">String value contains information about timeslots that the Module can not be taught</param>
        /// <param name="lecturerList">LinkedList with a List of Lecturers</param>
        public Module(String name, bool pratical, int hoursPerWeek, string roomType, bool doubleSlots, int maxConsecHours, string slotsOff, LinkedList lecturerList)
        {
            setId("000");
            setName(name);
            setPractical(practical);
            setHoursPerWeek(hoursPerWeek);
            setRoomtype(roomType);
            setDoubleSlots(doubleSlots);
            setMaxConsecHours(maxConsecHours);
            setSlotsOff(slotsOff);
            setLecturerList(lecturerList);
        }

        //other methods


        //Get & Set Method
        /// <summary>
        ///     set the Id the
        /// </summary>
        /// <param name="id"></param>
        public void setId(string id)
        {
            this.ID = id;
        }
        /// <summary>
        ///     return the Id the Building
        /// </summary>
        /// <returns>gfg</returns>
        public string getID()
        {
            return this.ID;
        }
        /// <summary>
        ///     set Name
        /// </summary>
        /// <param name="name"></param>
        public void setName(string s)
        {
            this.name = s;
        }
        /// <summary>
        ///     get Name
        /// </summary>
        /// <returns></returns>
        public string getName()
        {
            return this.name;
        }
        /// <summary>
        ///     set if module is Practical
        /// </summary>
        /// <param name="practical"></param>
        public void setPractical(bool b)
        {
            this.practical = b;
        }
        /// <summary>
        ///     get if module is Practical
        /// </summary>
        /// <returns></returns>
        public bool getPractical()
        {
            return this.practical;
        }
        /// <summary>
        ///     set Hours Per Week
        /// </summary>
        /// <param name="HoursPerWeek"></param>
        public void setHoursPerWeek(int i)
        {
            this.hoursPerWeek = i;
        }
        /// <summary>
        ///     get Hours Per Week
        /// </summary>
        /// <returns></returns>
        public int getHoursPerWeek()
        {
            return this.hoursPerWeek;
        }
        /// <summary>
        ///     set Room Type needed
        /// </summary>
        /// <param name="s"></param>
        public void setRoomtype(string s)
        {
            this.RoomType = s;
        }
        /// <summary>
        ///     get Room Type needed
        /// </summary>
        /// <returns></returns>
        public string getRommType()
        {
            return this.RoomType;
        }
        /// <summary>
        ///     set if Double Slots needed
        /// </summary>
        /// <param name="doubleSlots"></param>
        public void setDoubleSlots(bool b)
        {
            this.doubleSlots = b;
        }
        /// <summary>
        ///     get if Double Slots needed
        /// </summary>
        /// <returns></returns>
        public bool getDoubleSlots()
        {
            return this.doubleSlots;
        }
        /// <summary>
        ///     set Max Consectuive Hours
        /// </summary>
        /// <param name="maxConsecHours"></param>
        public void setMaxConsecHours(int i)
        {
            this.maxConsecHours = i;
        }
        /// <summary>
        ///     get Max Consectuive Hours
        /// </summary>
        /// <returns></returns>
        public int getMaxConsecHours()
        {
            return this.maxConsecHours;
        }
        /// <summary>
        ///     set Minimum Slots per Day
        /// </summary>
        /// <param name="i"></param>
        /// <summary>
        ///     set Time Slots Off
        /// </summary>
        /// <param name="slotsOff"></param>
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
        /// <summary>
        ///     Set the Lecturer for this Department
        /// </summary>
        /// <param name="lecturerList"></param>
        public void setLecturerList(LinkedList lecturerList)
        {
            this.lecturerList = lecturerList;
        }
        /// <summary>
        ///     Get the Lecturer for this Department
        /// </summary>
        /// <returns></returns>
        public LinkedList getLecturerList()
        {
            return this.lecturerList;
        }
    }
}
