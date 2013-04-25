using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    class Department
    {
        /// <summary>
        /// The Id of the Department mainly used in the database
        /// </summary>
        private String ID;  
        /// <summary>
        /// The name of the Department
        /// </summary>
        private string name;
        /// <summary>
        /// A LinkedList of Lecturers in this Department
        /// </summary>
        private LinkedList lecturerList;
        /// <summary>
        /// A LinkedList of Courses in this Department
        /// </summary>
        private LinkedList courseList;
        /// <summary>
        ///     Defuault Constructer
        ///     Sets Id to defualt 000 so as to know to use INSERT SQl command
        ///     Creates a new linkedlists and assigns it to lecturerList & courseList to prevent
        ///     trying to add to a non-existent list
        /// </summary>
        public Department()
        {
            setId("000");
            lecturerList = new LinkedList();
            courseList = new LinkedList();
        }

        /// <summary>
        ///     Constructer that sets name
        ///     Sets Id to defualt 000 so as to know to use INSERT SQl command
        ///     Creates a new linkedlists and assigns it to lecturerList & courseList to prevent
        ///     trying to add to a non-existent list
        /// </summary>
        /// <param name="name">The name of the Department</param>
        public Department(String name)
        {
            setId("000");
            setName(name);
            lecturerList = new LinkedList();
            courseList = new LinkedList();
        }

        /// <summary>
        ///     Constructer that sets name, lecturer list & courseList
        /// </summary>
        /// <param name="name">The name of the Department</param>
        /// <param name="lectureList">LinkedList Of Lecturer in for this Department</param>
        /// <param name="courseList">LinkedList Of Course in for this Department</param>
        public Department(String name, LinkedList lectureList, LinkedList courseList)
        {
            setId("000");
            setName(name);
            setLecturerList(lectureList);
            setCourseList(courseList);
        }
        /// <summary>
        ///     Add a Lecturer to this department
        /// </summary>
        /// <param name="lecturer">The Lecturer to be added</param>
        public void addLecturer(Lecturer lecturer)
        {
            lecturerList.addAtTail(lecturer);
        }
        /// <summary>
        ///     Add a Course to this department
        /// </summary>
        /// <param name="course">The Course to be added</param>
        public void addCourse(Course course)
        {
            courseList.addAtTail(course);
        }
        /// <summary>
        /// Check if a Lecturer is in the lecturerist
        /// </summary>
        /// <param name="lecturer">The Lecturer to search for</param>
        /// <returns>True or False</returns>
        public bool isInDept(Lecturer lecturer)
        {
            return lecturerList.searchList(lecturer);
        }
        /// <summary>
        ///     Check if a Course is in this Deptartment
        /// </summary>
        /// <param name="course">The Course to search for</param>
        /// <returns>True or False</returns>
        public bool isInDept(Course course)
        {
            return courseList.searchList(course);
        }
        /// <summary>
        ///     set the id of the Departmet
        /// </summary>
        /// <param name="Id">The new Id</param>
        public void setId(string Id)
        {
            this.ID = Id;
        }
        /// <summary>
        ///     returns the id of Department
        /// </summary>
        /// <returns>The Id of the Department</returns>
        public string getID()
        {
            return this.ID;
        }
        /// <summary>
        ///     Set Department name
        /// </summary>
        /// <param name="name">The new name</param>
        public void setName(string name)
        {
            this.name = name;
        }
        /// <summary>
        ///     Get the Department name
        /// </summary>
        /// <returns>The Department name</returns>
        public string getName()
        {
            return this.name;
        }
        /// <summary>
        ///     Set the Lecturer for this Department
        /// </summary>
        /// <param name="lecturerList">The LinkedList Of Lecturer</param>
        public void setLecturerList(LinkedList lecturerList)
        {
            this.lecturerList = lecturerList;
        }
        /// <summary>
        ///     Get the Lecturer for this Department
        /// </summary>
        /// <returns>The LinkedList Of Lecturer</returns>
        public LinkedList getLecturerList()
        {
            return this.lecturerList;
        }
        /// <summary>
        ///     Set the Courses in this department
        /// </summary>
        /// <param name="courseList">The LinkedList of Course</param>
        public void setCourseList(LinkedList courseList)
        {
            this.courseList = courseList;
        }
        /// <summary>
        ///     Get the list of courses in this department
        /// </summary>
        /// <returns>The LinkedList of Course</returns>
        public LinkedList getCourseList()
        {
            return this.courseList;
        }
        /// <summary>
        /// Return a lecturer from the department based on Id
        /// </summary>
        /// <param name="Id">Id of the desired Lecturer</param>
        /// <returns>The Lecturer with given Id</returns>
        public Lecturer getLecById(string Id)
        {
            Lecturer lecturer = null;
            Node deptNode = this.lecturerList.head;
            while (deptNode != null)
            {
                lecturer = (Lecturer)deptNode.data;
                if (lecturer.getId() == Id)
                {
                    deptNode = null;
                }
                else
                {
                    deptNode = deptNode.next;
                }
            }
            return lecturer;
        }

    }
}
