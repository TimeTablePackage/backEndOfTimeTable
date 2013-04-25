using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Domain
{
    public sealed class DomainControler
    {
        private static DomainControler instance = new DomainControler();
        /// <summary>
        /// Class to load/save objects from/to the database
        /// </summary>
        private DataBase dataBaseHelper;
        /// <summary>
        /// The institute the timetable is for
        /// </summary>
        private Institute institute;
        /// <summary>
        /// Private constructer called on start-up, loads the data from the database
        /// </summary>
        private DomainControler()
        {
            dataBaseHelper = new DataBase();
            institute = new Institute("it carlow");
            institute.setBuildingList(dataBaseHelper.loadBuildingList(institute));
            institute.setDeptList(dataBaseHelper.loadDepartmentList(institute));
        }
        /// <summary>
        /// Get an instance of the controller
        /// </summary>
        /// <returns></returns>
        public static DomainControler getInstance()
        {
                return instance;
        }
        /// <summary>
        /// Get a list of all the lecturers in the institute
        /// </summary>
        /// <returns>linkedList of all lecturers in the institute</returns>
        public LinkedList getallLecturers()
        {
            LinkedList allLec = new LinkedList();
            LinkedList deptList = institute.getDeptList();
            Node nodeDept = deptList.head;

            while (nodeDept.next != null)
            {
                Department tempDept = (Department)nodeDept.data;
                allLec = allLec + tempDept.getLecturerList();
            }
            return allLec;
        }
        /// <summary>
        ///Get a list of all teh room in the institute
        /// </summary>
        /// <returns>LinkedList of all Room objects</returns>
        public LinkedList getAllRooms()
        {
            LinkedList allRooms = new LinkedList();
            LinkedList buildList = institute.getBuildingList();
            Node buildNode = buildList.head;

            //for all the departmnets in the list add each room list together
            while (buildNode.next != null)
            {
                Building tempBuild = (Building)buildNode.data;
                allRooms = allRooms + tempBuild.getRoomList();
            }
            return allRooms;
        }
        /// <summary>
        /// List all the Modules in the Institute
        /// </summary>
        /// <returns>LinkedList of all Module objects</returns>
        public LinkedList getAllModules()
        {
            LinkedList allModules = new LinkedList();
            LinkedList deptList = institute.getDeptList();
            LinkedList courseList;
            Node nodeDept = deptList.head;

            while (nodeDept.next != null)
            {
                Department tempDept = (Department)nodeDept.data;
                courseList = tempDept.getCourseList();
                Node nodeCourse = courseList.head;
                while (nodeCourse.next != null)
                {
                    Course tempCourse = (Course)nodeCourse.data;
                    allModules = allModules + tempCourse.getModuleList();
                }
            }
            return allModules;
        }
        /// <summary>
        /// Add a new lecturer to the system
        /// </summary>
        /// <param name="name">Name of the Lecturer</param>
        /// <param name="initials">Initials of the Lecturer</param>
        /// <param name="email">Email address of the Lecturer</param>
        /// <param name="maxHours">Maximum hours lecturer can work</param>
        /// <param name="maxConsecHours">Maximum Consecutive hours Lecturer can work</param>
        /// <param name="minSlotsPerDay">Minimum Lessons a day a teaches wants to teach</param>
        /// <param name="slotsOff">Times Lecturer Wants Off</param>
        /// <param name="deptId">The Id of the Dept the Lecturer is in</param>
        public void addLecturer(string name, string initials, string email, int maxHours, 
                                    int maxConsecHours, int minSlotsPerDay, string slotsOff , string deptId)
        {
            Lecturer lecturer = new Lecturer(name, initials, email, maxHours, maxConsecHours, minSlotsPerDay, slotsOff);
            Node deptNode = institute.getDeptList().head;
            Department dept = institute.getDeptById(deptId);
            dept.addLecturer(lecturer);
           
        }

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
        public void updateLecturer(string lecId, string name, string initials, string email, int maxHours,
                                    int maxConsecHours, int minSlotsPerDay, string slotsOff, string deptId)
        {
            Department department = institute.getDeptById(deptId);
            Lecturer lecturer = department.getLecById(lecId);
            lecturer.update(name, initials, email, maxHours, maxConsecHours, minSlotsPerDay, slotsOff);
        }


        public void deleteLecturer(string id)
        {
            //to be constructed!
        }



    }//class
}
