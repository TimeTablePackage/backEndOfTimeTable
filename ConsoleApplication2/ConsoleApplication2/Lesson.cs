using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    class Lesson
    {
        /// <summary>
        /// The lecturer details that teaches the Lesson.
        /// </summary>
        private Lecturer lecturer;
        /// <summary>
        /// The Module details that the Lesson will take place for.
        /// </summary>
        private Module module;
        // The room details about where the Lesson will take place.
        private Room room;

        /// <summary>
        ///     The default constructor of the Lesson object.
        /// </summary>
        public Lesson()
        {
        }
        
        /// <summary>
        ///     The constructor of Lesson object with a set of properties.
        /// </summary>
        /// <param name="lecturer">The name of the Lecturer</param>
        /// <param name="module">The name of the Module</param>
        /// <param name="room">The name/number of the Room</param>
        public Lesson(Lecturer lecturer, Module module, Room room)
        {
            setLecturer(lecturer);
            setModule(module);
            setRoom(room);
        }

        //Get and Set methods
        /// <summary>
        ///     The parameter received by the method is used for setting the Lecturer for this Lesson
        /// </summary>
        /// <param name="lecturer"></param>
        public void setLecturer(Lecturer lecturer)
        {
            this.lecturer = lecturer;
        }
        /// <summary>
        ///     The method retreives data from Lecturer object and gives detail of the lecturer giving the Lesson. 
        /// </summary>
        /// <returns>Lecturer Object</returns>
        public Lecturer getLecturer()
        {
            return this.lecturer;
        }
        /// <summary>
        ///     The parameters received will be used for assigning the Module for this Lesson.
        /// </summary>
        /// <param name="module">Module details</param>
        public void setModule(Module module)
        {
            this.module = module;
        }
        /// <summary>
        ///     The method returns the details of the Module for this Lesson.
        /// </summary>
        /// <returns>Module object</returns>
        public Module getModule()
        {
            return this.module;
        }
        /// <summary>
        ///     The parameter received will used for setting the room for the Lesson.
        /// </summary>
        /// <param name="room">Room details</param>
        public void setRoom(Room room)
        {
            this.room = room;
        }
        /// <summary>
        ///     The method retrieves Room object and returns the room assigned for the Lesson.
        /// </summary>
        /// <returns>Room Object</returns>
        public Room getRoom()
        {
            return this.room;
        }
    }
}
