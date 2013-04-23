using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    class Course
    {
        private string ID;
        private string courseCode;
        private string name;
        private int numOfStudents;
        private LinkedList moduleList;

        /// <summary>
        ///     Constructer for course
        /// </summary>
        public Course()
        {
            setID("000");
            moduleList = new LinkedList(); 
        }
        /// <summary>
        ///     Constructer for course setting properties
        /// </summary>
        /// <param name="courseCode"></param>
        /// <param name="name"></param>
        /// <param name="numOfStudents"></param>
        public Course(string courseCode, string name, int numOfStudents)
        {
            setID("000"); 
            setCourseCode(courseCode);
            setName(name);
            setNumOfStudents(numOfStudents);
            moduleList = new LinkedList();
        }
        /// <summary>
        ///     Constructer for course setting properties
        /// </summary>
        /// <param name="courseCode"></param>
        /// <param name="name"></param>
        /// <param name="numOfStudents"></param>
        /// <param name="moduleList"></param>
        public Course(string courseCode, string name, int numOfStudents, LinkedList moduleList)
        {
            setID("000"); 
            setCourseCode(courseCode);
            setName(name);
            setNumOfStudents(numOfStudents);
            setModuleList(moduleList);
        } 

        //other methods
        /// <summary>
        ///     add a module to the course
        /// </summary>
        /// <param name="module"></param>
        public void addModule(Module module)
        {
            this.moduleList.addAtTail(module);
        }
        /// <summary>
        ///     Check is a module is part of the course
        /// </summary>
        /// <param name="module"></param>
        /// <returns></returns>
        public bool isOnCourse(Module module)
        {
           return moduleList.searchList(module);
        }

        //Get & Set Methods
        /// <summary>
        ///     Set the ID of the course
        /// </summary>
        /// <param name="ID"></param>
        public void setID(string ID)
        {
            this.ID = ID;
        }
        /// <summary>
        ///     Get the ID of the course
        /// </summary>
        /// <returns></returns>
        public string getID()
        {
            return this.ID;
        }
        /// <summary>
        ///     set the course code
        /// </summary>
        /// <param name="courseCode"></param>
        public void setCourseCode(string courseCode)
        {
            this.courseCode = courseCode;
        }
        /// <summary>
        ///     get the course code
        /// </summary>
        /// <returns></returns>
        public string getCourseCode()
        {
            return this.courseCode;
        }
        /// <summary>
        ///     Set course name
        /// </summary>
        /// <param name="name"></param>
        public void setName(string name)
        {
            this.name = name;
        }
        /// <summary>
        ///     Get the course name
        /// </summary>
        /// <returns></returns>
        public string getName()
        {
            return this.name;
        }
        /// <summary>
        ///     set the number of students in the course
        /// </summary>
        /// <param name="NumOfStudents"></param>
        public void setNumOfStudents(int numOfStudents)
        {
            this.numOfStudents = numOfStudents;
        }
        /// <summary>
        ///     get the number of students in the course 
        /// </summary>
        /// <returns></returns>
        public int getNumOfStudents()
        {
            return this.numOfStudents;
        }
        /// <summary>
        ///     Set the modules for this course
        /// </summary>
        /// <param name="moduleList"></param>
        public void setModuleList(LinkedList moduleList)
        {
            this.moduleList = moduleList;
        }
        /// <summary>
        ///     Get the modules for this course
        /// </summary>
        /// <returns></returns>
        public LinkedList getModuleList()
        {
            return this.moduleList;
        }
    }
}
