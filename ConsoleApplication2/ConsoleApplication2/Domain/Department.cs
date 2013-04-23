using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    class Department
    {
        private string ID;  // used for database
        private string name;
        private LinkedList lecturerList;
        private LinkedList courseList;
        
        /// <summary>
        ///     Default Constructer
        /// </summary>
        public Department()
        {
            setId("000");
            lecturerList = new LinkedList();
        }

        /// <summary>
        ///     Constructer and set name
        /// </summary>
        /// <param name="name"></param>
        public Department(String name)
        {
            setId("000");
            setName(name);
            lecturerList = new LinkedList();
            courseList = new LinkedList();
        }

        /// <summary>
        ///     Constructer and set name, lecturer list & courseList
        /// </summary>
        /// <param name="name"></param>
        /// <param name="lectureList"></param>
        public Department(String name, LinkedList lectureList, LinkedList courseList)
        {
            setId("000");
            setName(name);
            setLecturerList(lectureList);
            setCourseList(courseList);
        }

        //Other Methods
        /// <summary>
        ///     Add a lecturer to this department
        /// </summary>
        /// <param name="lecturer"></param>
        public void addLecturer(Lecturer lecturer)
        {
            lecturerList.addAtTail(lecturer);
        }
        /// <summary>
        ///     Add a course to this department
        /// </summary>
        /// <param name="course"></param>
        public void addCourse(Course course)
        {
            courseList.addAtTail(course);
        }
        /// <summary>
        /// Check if a Lecturer is in this department
        /// </summary>
        /// <param name="lecturer"></param>
        /// <returns></returns>
        public bool isInDept(Lecturer lecturer)
        {
            return lecturerList.searchList(lecturer);
        }
        /// <summary>
        ///     Check if a course is in this deptartment
        /// </summary>
        /// <param name="course"></param>
        /// <returns></returns>
        public bool isInDept(Course course)
        {
            return courseList.searchList(course);
        }




        //Get & Set Methods
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
        ///     return the the id of the department
        /// </summary>
        /// <returns></returns>
        public string getID()
        {
            return this.ID;
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
        /// <summary>
        ///     Set the courses in this department
        /// </summary>
        /// <param name="courseList"></param>
        public void setCourseList(LinkedList courseList)
        {
            this.courseList = courseList;
        }
        /// <summary>
        ///     Get the list of courses in this department
        /// </summary>
        /// <returns></returns>
        public LinkedList getCourseList()
        {
            return this.courseList;
        }

    }
}
