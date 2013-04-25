using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Services;

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
        ///   The string value received by the method is assigned as the Module ID.
        /// </summary>
        /// <param name="id">String value which contains Module ID</param>
        public void setId(string id)
        {
            this.ID = id;
        }
        /// <summary>
        ///   The method returns the ID of the Module
        /// </summary>
        /// <returns>String</returns>
        public string getID()
        {
            return this.ID;
        }
        /// <summary>
        ///    The parameter received by the method is assigned as the name of the Module
        /// </summary>
        /// <param name="name">Module Name</param>
        public void setName(string s)
        {
            this.name = s;
        }
        /// <summary>
        ///     The method retreived the name of the Module object and returns it.
        /// </summary>
        /// <returns>String</returns>
        public string getName()
        {
            return this.name;
        }
        /// <summary>
        ///    The parameter received by the method is used to define whether module has a practical.
        /// </summary>
        /// <param name="practical">Boolean value to define whether Module is practical or not.</param>
        public void setPractical(bool b)
        {
            this.practical = b;
        }
        /// <summary>
        ///    The method retrieves the Module object and return user whether Module is practical or not.
        /// </summary>
        /// <returns>Boolean</returns>
        public bool getPractical()
        {
            return this.practical;
        }
        /// <summary>
        ///     The parameter received by the method is set as the number of hours that Module will be taught.
        /// </summary>
        /// <param name="HoursPerWeek">Integer value for number of hours</param>
        public void setHoursPerWeek(int i)
        {
            this.hoursPerWeek = i;
        }
        /// <summary>
        ///     The method retrieves the Module object and return user the number of hours Module is taught each week.
        /// </summary>
        /// <returns>Integer</returns>
        public int getHoursPerWeek()
        {
            return this.hoursPerWeek;
        }
        /// <summary>
        ///     The parameter received by this method sets the Room type needed by the Module.
        /// </summary>
        /// <param name="s">String value with relevant information</param>
        public void setRoomtype(string s)
        {
            this.RoomType = s;
        }
        /// <summary>
        ///     The method retrieves the Module object and return user the room type needed by the Module.
        /// </summary>
        /// <returns>String</returns>
        public string getRommType()
        {
            return this.RoomType;
        }
        /// <summary>
        ///     The parameters received by the method defines whether double slots are needed for the Module.
        /// </summary>
        /// <param name="doubleSlots">Boolean Value</param>
        public void setDoubleSlots(bool b)
        {
            this.doubleSlots = b;
        }
        /// <summary>
        ///      The method retrieves the Module object and returns whether double slots are needed for the Module.
        /// </summary>
        /// <returns>Boolean</returns>
        public bool getDoubleSlots()
        {
            return this.doubleSlots;
        }
        /// <summary>
        ///     The parameters received by the method will be used for setting the maximum number of consecutive hours for Module in a day.
        /// </summary>
        /// <param name="maxConsecHours">Integer value for the maximum number of consecutive hours for the Module</param>
        public void setMaxConsecHours(int i)
        {
            this.maxConsecHours = i;
        }
        /// <summary>
        ///     The method retrieves the Module object and returns user the maximum number of consecutive hours allowed for the Module.
        /// </summary>
        /// <returns>Integer</returns>
        public int getMaxConsecHours()
        {
            return this.maxConsecHours;
        }
        ///    The parameters received by the method defines the timeslots that the Module can not be taught.
        /// </summary>
        /// <param name="slotsOff">String value for Module slots off</param>
        public void setSlotsOff(string s)
        {
            this.slotsOff = s;
        }
        /// <summary>
        ///    The method returns the time slots that a Module can not be taught.
        /// </summary>
        /// <returns>String</returns>
        public string getSlotsOff()
        {
            return this.slotsOff;
        }
        /// <summary>
        ///    The parameter received by the method specifies the lecturer that can teach this Module.
        /// </summary>
        /// <param name="lecturerList">A lecturer from a list of Lecturers in LinkedList</param>
        public void setLecturerList(LinkedList lecturerList)
        {
            this.lecturerList = lecturerList;
        }
        /// <summary>
        ///   The method returns the Lecturer(s) assigned to teach this Module.
        /// </summary>
        /// <returns>LinkedList</returns>
        public LinkedList getLecturerList()
        {
            return this.lecturerList;
        }
    }
}
