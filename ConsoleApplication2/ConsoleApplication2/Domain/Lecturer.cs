using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    class Lecturer
    {
        private string ID; // for database base use
        private string name;
        private string initials;
        private string email;
        private int maxHours;
        private int maxConsecHours;
        private int minSlotsPerDay;
        private string slotsOff; 
        /// <summary>
        ///     Construct new object without setting properties
        /// </summary>
        public Lecturer()
        {
            setId("000");
        }
       /// <summary>
       ///      Construct new object and set properties
       ///      For creating new lecturer in application
       /// </summary>
       /// <param name="name"></param>
       /// <param name="initials"></param>
       /// <param name="email"></param>
       /// <param name="maxHours"></param>
       /// <param name="maxConsecHours"></param>
       /// <param name="minSlotsPerDay"></param>
       /// <param name="slotsOff"></param>
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
        ///     Constructer used when loading from database
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="initials"></param>
        /// <param name="email"></param>
        /// <param name="maxHours"></param>
        /// <param name="maxConsecHours"></param>
        /// <param name="minSlotsPerDay"></param>
        /// <param name="slotsOff"></param>
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

        //Get & set methods
        /// <summary>
        ///     set the id of the lecturer
        /// </summary>
        /// <param name="Id"></param>
        public void setId(string Id)
        {
            this.ID = Id;
        }
        /// <summary>
        ///     returns the id of lecturer
        /// </summary>
        /// <returns></returns>
        public string getId()
        {
            return this.ID;
        }

        /// <summary>
        ///     set Name
        /// </summary>
        /// <param name="s"></param>
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
        /// set Initials
        /// </summary>
        /// <param name="s"></param>
        public void setInitials(string s)
        {
            this.initials = s;
        }
        /// <summary>
        ///     get Initials
        /// </summary>
        /// <returns></returns>
        public string getInitials()
        {
            return this.initials;
        }
        /// <summary>
        ///     set Email
        /// </summary>
        /// <param name="s"></param>
        public void setEmail(string s)
        {
            this.email = s ;
        }
        /// <summary>
        ///     get Email
        /// </summary>
        /// <returns></returns>
        public string getEmail()
        {
            return this.email;
        }
        /// <summary>
        ///     set Max Hours
        /// </summary>
        /// <param name="i"></param>
        public void setMaxHours(int i)
        {
            this.maxHours = i;
        }
        /// <summary>
        ///     get Max Hours
        /// </summary>
        /// <returns></returns>
        public int getMaxHours()
        {
            return this.maxHours;
        }
        /// <summary>
        ///     set Max Consectuive Hours
        /// </summary>
        /// <param name="i"></param>
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
        public void setMinSlotsPerDay(int i)
        {
            this.minSlotsPerDay = i;
        }
        /// <summary>
        ///     get Minimum Slots per Day
        /// </summary>
        /// <returns></returns>
        public int getMinSlotsPerDay()
        {
            return this.minSlotsPerDay;
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
