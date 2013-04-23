using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    class Lesson
    {
        private Lecturer lecturer;
        private Module module;
        private Room room;

        /// <summary>
        ///     Defualt constructer
        /// </summary>
        public Lesson()
        {
        }
        
        /// <summary>
        ///     Constructer & set properties
        /// </summary>
        /// <param name="lecturer"></param>
        /// <param name="module"></param>
        /// <param name="room"></param>
        public Lesson(Lecturer lecturer, Module module, Room room)
        {
            setLecturer(lecturer);
            setModule(module);
            setRoom(room);
        }

        //Get and Set methods
        /// <summary>
        ///     Set the lecturer for this lesson
        /// </summary>
        /// <param name="lecturer"></param>
        public void setLecturer(Lecturer lecturer)
        {
            this.lecturer = lecturer;
        }
        /// <summary>
        ///     Get the lecturer for this lesson
        /// </summary>
        /// <returns></returns>
        public Lecturer getLecturer()
        {
            return this.lecturer;
        }
        /// <summary>
        ///     set the module for this lesson
        /// </summary>
        /// <param name="module"></param>
        public void setModule(Module module)
        {
            this.module = module;
        }
        /// <summary>
        ///     get the module of the lesson
        /// </summary>
        /// <returns></returns>
        public Module getModule()
        {
            return this.module;
        }
        /// <summary>
        ///     set the room for this lesson
        /// </summary>
        /// <param name="room"></param>
        public void setRoom(Room room)
        {
            this.room = room;
        }
        /// <summary>
        ///     get the room for this lesson
        /// </summary>
        /// <returns></returns>
        public Room getRoom()
        {
            return this.room;
        }
    }
}
