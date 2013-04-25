using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    class Course
    {
        /// <summary>
        /// The Id of the course, mainly used for databse
        /// </summary>
        private string ID;
        /// <summary>
        /// The code of the course
        /// </summary>
        private string courseCode;
        /// <summary>
        /// Name of the course
        /// </summary>
        private string name;
        /// <summary>
        /// Number of students in the course
        /// </summary>
        private int numOfStudents;
        /// <summary>
        /// linked list of modules on the course
        /// </summary>
        private LinkedList moduleList;
        /// <summary>
        ///     Defuault Constructer
        ///     Sets Id to defualt 000 so as to know to use INSERT SQl command
        ///     Creates a new linkedlist and assigns it to moduleList to prevent addModule() 
        ///     trying to add to a non-existent list
        /// </summary>
        public Course()
        {
            setID("000");
            moduleList = new LinkedList(); 
        }
        /// <summary>
        ///     Constructer that takes courseCode, name & bumber of students
        ///     Sets Id to defualt 000 so as to know to use INSERT SQl command
        ///     Creates a new linkedlist and assigns it to moduleList to prevent addModule() 
        ///     trying to add to a non-existent list
        /// </summary>
        /// <param name="courseCode">code of the course</param>
        /// <param name="name">name of the course</param>
        /// <param name="numOfStudents">number of students in the course</param>
        public Course(string courseCode, string name, int numOfStudents)
        {
            setID("000"); 
            setCourseCode(courseCode);
            setName(name);
            setNumOfStudents(numOfStudents);
            moduleList = new LinkedList();
        }
        /// <summary>
        ///     Constructer that takes courseCode, name & bumber of students
        ///     Sets Id to defualt 000 so as to know to use INSERT SQl command
        /// </summary>
        /// <param name="courseCode">code of the course</param>
        /// <param name="name">name of the course</param>
        /// <param name="numOfStudents">number of students in the course</param>
        /// <param name="moduleList">linked list of module on the course</param>
        public Course(string courseCode, string name, int numOfStudents, LinkedList moduleList)
        {
            setID("000"); 
            setCourseCode(courseCode);
            setName(name);
            setNumOfStudents(numOfStudents);
            setModuleList(moduleList);
        } 
        /// <summary>
        ///     add a module to the course
        /// </summary>
        /// <param name="module">the module to be added</param>
        public void addModule(Module module)
        {
            this.moduleList.addAtTail(module);
        }
        /// <summary>
        ///     Check is a module on the moduleList
        /// </summary>
        /// <param name="module">the module to search for</param>
        /// <returns>wether or not the module is on the list</returns>
        public bool isOnCourse(Module module)
        {
           return moduleList.searchList(module);
        }
        /// <summary>
        ///     Set the ID of the course
        /// </summary>
        /// <param name="ID">new Id of the course</param>
        public void setID(string ID)
        {
            this.ID = ID;
        }
        /// <summary>
        ///     Get the ID of the course
        /// </summary>
        /// <returns>The Id of the course</returns>
        public string getID()
        {
            return this.ID;
        }
        /// <summary>
        ///     set the course code
        /// </summary>
        /// <param name="courseCode">the new code for the course</param>
        public void setCourseCode(string courseCode)
        {
            this.courseCode = courseCode;
        }
        /// <summary>
        ///     get the course code
        /// </summary>
        /// <returns>the course code</returns>
        public string getCourseCode()
        {
            return this.courseCode;
        }
        /// <summary>
        ///     Set course name
        /// </summary>
        /// <param name="name">The new name for the course</param>
        public void setName(string name)
        {
            this.name = name;
        }
        /// <summary>
        ///     Get the course name
        /// </summary>
        /// <returns>The name of the Course</returns>
        public string getName()
        {
            return this.name;
        }
        /// <summary>
        ///     set the number of students in the course
        /// </summary>
        /// <param name="NumOfStudents">The number of students in the course</param>
        public void setNumOfStudents(int numOfStudents)
        {
            this.numOfStudents = numOfStudents;
        }
        /// <summary>
        ///     return the number of students in the course 
        /// </summary>
        /// <returns></returns>
        public int getNumOfStudents()
        {
            return this.numOfStudents;
        }
        /// <summary>
        ///     Set the modules for this course
        /// </summary>
        /// <param name="moduleList">the number if students in the course</param>
        public void setModuleList(LinkedList moduleList)
        {
            this.moduleList = moduleList;
        }
        /// <summary>
        ///     Get the modules for this course
        /// </summary>
        /// <returns>A linked list of modules on the course</returns>
        public LinkedList getModuleList()
        {
            return this.moduleList;
        }
    }
}
