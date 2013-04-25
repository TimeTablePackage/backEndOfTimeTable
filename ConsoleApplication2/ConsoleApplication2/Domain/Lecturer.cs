using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    class Lecturer
    {
        /// <summary>
        /// ID  will be used for identifying the Lecturer in the database
        /// </summary>
        private string ID;
        /// <summary>
        /// This will be the name of the Lecturer
        /// </summary>
        private string name;
        /// <summary>
        /// The initials of the lecturer will be used for the final timetable.
        /// </summary>
        private string initials;
        /// <summary>
        /// This is the email address of the Lecturer.
        /// </summary>
        private string email;
        /// <summary>
        /// Maximum number of hours that Lecturer is available to work.
        /// </summary>
        private int maxHours;
        /// <summary>
        /// Maximum number of consecutive hours that a Lecturer can teach during the day.
        /// </summary>
        private int maxConsecHours;
        /// <summary>
        /// The minimum number of hours that a Lecturer can teach.
        /// </summary>
 
        private int minSlotsPerDay;
        /// <summary>
        /// Different slots of time that a lecturer is not available.
        /// </summary>
        private string slotsOff; 
        /// <summary>
        ///     The method constructs new object without setting properties
        /// </summary>
        public Lecturer()
        {
            setId("000");
        }
       /// <summary>
       ///     The method Constructs new object and with a set of properties
       /// 
       /// </summary>
       /// <param name="name">String value for the name of lecturer</param>
       /// <param name="initials">String value for the initials of lecturer</param>
       /// <param name="email">String value for email details</param>
       /// <param name="maxHours">Integer value for Maximum number of hours during the week</param>
       /// <param name="maxConsecHours">Integer value for maximum consecutive hours a lecturer can teach</param>
       /// <param name="minSlotsPerDay">Integer value for the minimum amount of hours that a Lecturer can teach.</param>
       /// <param name="slotsOff">String value for the time slots that a lecturer is not available.</param>
        public Lecturer(string name, string initials, string email, int maxHours, int maxConsecHours, int minSlotsPerDay, string slotsOff)
        {
            setId("000");
            setName(name);
            setInitials(initials);
            setEmail(email);
            setMaxHours(maxHours);
            setMaxConsecHours(maxConsecHours);
            setMinSlotsPerDay(minSlotsPerDay);
            setSlotsOff(slotsOff);
        }
        /// <summary>
        ///    This method is used when loading from database
        /// </summary>
        /// <param name="name">String value for the name of lecturer</param>
        /// <param name="initials">String value for the initials of lecturer</param>
        /// <param name="email">String value for email details</param>
        /// <param name="maxHours">Integer value for Maximum number of hours during the week</param>
        /// <param name="maxConsecHours">Integer value for maximum consecutive hours a lecturer can teach</param>
        /// <param name="minSlotsPerDay">Integer value for the minimum amount of hours that a Lecturer can teach.</param>
        /// <param name="slotsOff">String value for the time slots that a lecturer is not available.</param>
        public Lecturer(string id ,string name, string initials, string email, int maxHours, int maxConsecHours, int minSlotsPerDay, string slotsOff)
        {
            setId(id);
            setName(name);
            setInitials(initials);
            setEmail(email);
            setMaxHours(maxHours);
            setMaxConsecHours(maxConsecHours);
            setMinSlotsPerDay(minSlotsPerDay);
            setSlotsOff(slotsOff);
        }

        //other methods
        /// <summary>
        ///    Update the values in the Lecturer
        /// </summary>
        /// <param name="name">String value for the name of lecturer</param>
        /// <param name="initials">String value for the initials of lecturer</param>
        /// <param name="email">String value for email details</param>
        /// <param name="maxHours">Integer value for Maximum number of hours during the week</param>
        /// <param name="maxConsecHours">Integer value for maximum consecutive hours a lecturer can teach</param>
        /// <param name="minSlotsPerDay">Integer value for the minimum amount of hours that a Lecturer can teach.</param>
        /// <param name="slotsOff">String value for the time slots that a lecturer is not available.</param>
        public void update(string name, string initials, string email, int maxHours, int maxConsecHours, int minSlotsPerDay, string slotsOff)
        {
            setName(name);
            setInitials(initials);
            setEmail(email);
            setMaxHours(maxHours);
            setMaxConsecHours(maxConsecHours);
            setMinSlotsPerDay(minSlotsPerDay);
            setSlotsOff(slotsOff);
        }

        //Get & set methods
        /// <summary>
        ///    The parameter received by the method is set as the ID of the Lecturer.
        /// </summary>
        /// <param name="Id">String Value for Lecture ID</param>
        public void setId(string Id)
        {
            this.ID = Id;
        }
        /// <summary>
        ///     The method retrieves Lecture object and returns the ID of lecturer
        /// </summary>
        /// <returns>String</returns>
        public string getId()
        {
            return this.ID;
        }

        /// <summary>
        ///     The parameter received by the method is set as  the name of the Lecturer
        /// </summary>
        /// <param name="s">String value for Name</param>
        public void setName(string s)
        {
            this.name = s;
        }
        /// <summary>
        ///     The method retrieves Lecture object and returns the  Name of the Lecturer.
        /// </summary>
        /// <returns>String</returns>
        public string getName()
        {
            return this.name;
        }
        /// <summary>
        /// The parameter received by the method is set as  the initials.
        /// </summary>
        /// <param name="s">String value for Initials</param>
        public void setInitials(string s)
        {
            this.initials = s;
        }
        /// <summary>
        ///   The method retrieves Lecture object and returns the initials of the Lecturer
        /// </summary>
        /// <returns>String</returns>
        public string getInitials()
        {
            return this.initials;
        }
        /// <summary>
        ///    The parameter received by the method is set as the Email
        /// </summary>
        /// <param name="s">The Emaill address</param>
        public void setEmail(string s)
        {
            this.email = s ;
        }
        /// <summary>
        ///  The method retrieves Lecture object and returns the Email of Lecturer
        /// </summary>
        /// <returns>String</returns>
        public string getEmail()
        {
            return this.email;
        }
        /// <summary>
        ///   The parameter received by the method is set as  the initials maximum number of hours a lecturer is available.
        /// </summary>
        /// <param name="i">Maximum number of Hours</param>
        public void setMaxHours(int i)
        {
            this.maxHours = i;
        }
        /// <summary>
        ///  The method retrieves Lecture object and returns the Maximum Hours that a Lecturer can teach.
        /// </summary>
        /// <returns>Integer</returns>
        public int getMaxHours()
        {
            return this.maxHours;
        }
        /// <summary>
        ///     set Max Consectuive Hours
        /// </summary>
        /// <param name="i">Maximum number of Consecutive Hours</param>
        public void setMaxConsecHours(int i)
        {
            this.maxConsecHours = i;
        }
        /// <summary>
        /// The method retrieves Lecture object and returns the Maximum Consectuive Hours that a Lecturer can teach.
        /// </summary>
        /// <returns>Integer</returns>
        public int getMaxConsecHours()
        {
            return this.maxConsecHours;
        }
        /// <summary>
        ///     The parameter received by the method is set as  the minimum number of hours a Lecturer can teach.
        /// </summary>
        /// <param name="i">Minimum number of Hours Each Day</param>
        public void setMinSlotsPerDay(int i)
        {
            this.minSlotsPerDay = i;
        }
        /// <summary>
        ///   The method retrieves Lecture object and returns the Minimum Slots per Day
        /// </summary>
        /// <returns>Integer</returns>
        public int getMinSlotsPerDay()
        {
            return this.minSlotsPerDay;
        }
        /// <summary>
        ///    The parameter received by the method is set as the Timeslots that a Lecturers is not available. 
        /// </summary>
        /// <param name="s">String value for Time Slots </param>
        public void setSlotsOff(string s)
        {
            this.slotsOff = s;
        }
        /// <summary>
        ///  The method retrieves Lecture object and returns the Time Slots that a Lecturer is not available
        /// </summary>
        /// <returns>String</returns>
        public string getSlotsOff()
        {
            return this.slotsOff;
        }
    }
}
