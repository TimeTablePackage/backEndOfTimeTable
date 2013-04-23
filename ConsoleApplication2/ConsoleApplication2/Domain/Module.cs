using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    class Module
    {
        private string ID;
        private string name;
        private bool practical;
        private int hoursPerWeek;
        private string RoomType;
        private bool doubleSlots;
        private int maxConsecHours;
        private string slotsOff;
        private LinkedList lecturerList;

        /// <summary>
        ///     Construct new object without setting properties
        /// </summary>
        public Module()
        {
            setId("000");
            lecturerList = new LinkedList();
        }

        /// <summary>
        ///     Construct new object and set properties
        /// </summary>
        /// <param name="name">jyfjh</param>
        /// <param name="pratical"></param>
        /// <param name="hoursPerWeek"></param>
        /// <param name="roomType"></param>
        /// <param name="doubleSlots"></param>
        /// <param name="maxConsecHours"></param>
        /// <param name="slotsOff"></param>
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
        ///     Construct new object and set properties
        /// </summary>
        /// <param name="name"></param>
        /// <param name="pratical"></param>
        /// <param name="hoursPerWeek"></param>
        /// <param name="roomType"></param>
        /// <param name="doubleSlots"></param>
        /// <param name="maxConsecHours"></param>
        /// <param name="slotsOff"></param>
        /// <param name="lecturerList"></param>
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
