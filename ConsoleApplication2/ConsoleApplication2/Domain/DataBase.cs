using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{   
    class DataBase
    {

        private string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=ttp.accdb";
        private OleDbConnection conn ;
        private OleDbCommand cmd;
        private OleDbDataReader reader;
        
        /// <summary>
        ///     Connect to access database
        /// </summary>
        private void OpenConection()
        {
            conn = new OleDbConnection();
            conn.ConnectionString = connectionString ;
            try
             {
                conn.Open();
             }
            catch 
             {
                 Console.Write("no connection");
                //MessageBox.Show("Failed to connect to data source");
             }
        }
        /// <summary>
        ///     Disconnect from database
        /// </summary>
        private void CloseConnection()
        {
            try
            {
                conn.Close();
            }
            catch
            {
                Console.Write("No connection");
                //MessageBox.Show("Failed to close connection to data source");
            }
        }
        /// <summary>
        ///    insert data to a database
        /// </summary>
        /// <param name="sqlStatment"></param>
        private void excuteNonQuery(String sqlString)
        {
            try
            {
                OpenConection();
                cmd = new OleDbCommand(sqlString, conn);
                cmd.ExecuteNonQuery();
                CloseConnection();
            }
            catch
            {
                // MessageBox.Show("Failed insert data");
                Console.Write("cant excute insert command!");
            }
        }
        /// <summary>
        ///     update a lecturer in the database
        /// </summary>
        /// <param name="lecturers"></param>
        private void updateLecturer(Lecturer lecturer)
        {
            string sql;
            sql = "UPDATE Lecturer";
            sql += "Lec_Name='" + lecturer.getName() + "', ";
            sql += "Initials='" + lecturer.getInitials() + "', ";
            sql += "Email='" + lecturer.getEmail() + "', ";
            sql += "MaxHours=" + lecturer.getMaxHours() + ", ";
            sql += "MaxConsecHours=" + lecturer.getMaxConsecHours() + ", ";
            sql += "MinSlotsPerDay=" + lecturer.getMinSlotsPerDay() + ", ";
            sql += "SlotsOff='" + lecturer.getSlotsOff() + "' ";
            sql += "WHERE ID LIKE '" + lecturer.getId() + "'";
            excuteNonQuery(sql);
        }
        /// <summary>
        ///     Add a new lecturer to the database
        /// </summary>
        /// <param name="lecturer"></param>
        private void insertLecturer(Lecturer lecturer)
        {
            string sql;
            sql = "INSERT INTO Lecturer (Lec_Name, Initials, Email, MaxHours, MaxConsecHours, MinSlotsPerDay, SlotsOff, Deleted) VALUES(";
            sql += "'" + lecturer.getName() + "', ";
            sql += "'" + lecturer.getInitials() + "', ";
            sql += "'" + lecturer.getEmail() + "', ";
            sql += lecturer.getMaxHours() + ", ";
            sql += lecturer.getMaxConsecHours() + ", ";
            sql += lecturer.getMinSlotsPerDay() + ", ";
            sql += "'" + lecturer.getSlotsOff() + "', false)";
            excuteNonQuery(sql);
        }
        /// <summary>
        ///     update a module in the database
        /// </summary>
        /// <param name="module"></param>
        private void updateModule(Module module)
        {
            string sql;
            sql = "UPDATE Module";
            sql += "Module_Name='" + module.getName() + "', ";
            sql += "Practical=" + module.getPractical() + ",";
            sql += "HoursPerWeek=" + module.getHoursPerWeek() + ", ";
            sql += "RoomType='" + module.getRommType() + "', ";
            sql += "MaxConsecHours=" + module.getMaxConsecHours() + ", ";
            sql += "DoubleSlots=" + module.getDoubleSlots() + ", ";
            sql += "WHERE ID LIKE " + module.getID();
            excuteNonQuery(sql);
        }
        /// <summary>
        ///     insert a new module into the database
        /// </summary>
        /// <param name="module"></param>
        private void insertModule(Module module)
        {
            string sql;
            sql = "INSERT INTO Module (Module_Name, Practical, HoursPerWeek, RoomType, MaxConsecHours, DoubleSlots, Deleted) VALUES(";
            sql = "'" + module.getName() + "', ";
            sql = module.getPractical() + ",";
            sql = module.getHoursPerWeek() + ", ";
            sql = "'" + module.getRommType() + "',";
            sql = module.getMaxConsecHours() + ", ";
            sql = module.getDoubleSlots() + ", false)";
            excuteNonQuery(sql);
        }
        /// <summary>
        ///     update a room in the database
        /// </summary>
        /// <param name="room"></param>
        private void updateRoom(Room room)
        {
            string sql;
            sql = "UPDATE Room";
            sql += "Number='" + room.getRoomNumber() + "', ";
            sql += "Capacity=" + room.getCapacity() + ", ";
            sql += "RoomType='" + room.getRoomType() + "', ";
            sql += "SlotsOff='" + room.getSlotsOff() + "', ";
            sql += "WHERE ID LIKE " + room.getID();
            excuteNonQuery(sql);
        }
        /// <summary>
        ///  insert room to the database
        /// </summary>
        /// <param name="room"></param>
        private void insertRoom(Room room)
        {
            string sql;
            sql = "INSERT INTO Room (Number, Capacity, RoomType, SlotsOff, Deleted) VALUES(";
            sql += "'"+room.getRoomNumber()+"', ";
            sql += room.getCapacity() + ", ";
            sql += "'" + room.getRoomType() + "', ";
            sql += "'" + room.getSlotsOff() + "', false ";
            excuteNonQuery(sql);
        }
        /// <summary>
        ///     update a department
        /// </summary>
        /// <param name="dept"></param>
        private void updateDept(Department dept)
        {
            string sql;
            sql = "Update Department Dept_Name=";
            sql += "'" + dept.getName() + "'";
            excuteNonQuery(sql);
        }
        /// <summary>
        ///     Insert a department into the database
        /// </summary>
        /// <param name="dept"></param>
        private void insertDept(Department dept)
        {
            string sql = "INSERT INTO Department VALUES('"+ dept.getName() + "')";
            excuteNonQuery(sql);
        }

        /// <summary>
        ///     returns a lecturer object corresponding to the ID given
        /// </summary>
        /// <param name="lecturerId"></param>
        /// <returns></returns> 
        public Lecturer loadLecturer(string lecturerId)
        {
            Lecturer newLec = new Lecturer();
            string sqlStatment = "SELECT * FROM Lecturer WHERE ID LIKE " + lecturerId;
            try
            {
                OpenConection();
                cmd = new OleDbCommand(sqlStatment, conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    if (reader["Deleted"].ToString().Equals("False"))
                    {
                        newLec.setName(reader["Lec_Name"].ToString());
                        newLec.setInitials(reader["Initials"].ToString());
                        newLec.setEmail(reader["Email"].ToString());
                        newLec.setMaxHours(Convert.ToInt32(reader["MaxHours"]));
                        newLec.setMaxConsecHours(Convert.ToInt32(reader["MaxConsecHours"]));
                        newLec.setMinSlotsPerDay(Convert.ToInt32(reader["MinSlotsPerDays"]));
                        newLec.setSlotsOff(reader["SlotsOff"].ToString());
                    }
                }
                CloseConnection();
            }
            catch
            {
                // MessageBox.Show("Failed to get data from source");
            }

            return newLec;
        }
        /// <summary>
        ///    Get data back in a data table
        /// </summary>
        /// <param name="sqlStatment"></param>
        public DataTable GetTableData(String sqlStatment)
        {
            DataTable dt = new DataTable();
            OpenConection();
            OleDbCommand cmd = new OleDbCommand(sqlStatment, conn);
            OleDbDataReader reader = cmd.ExecuteReader();
            dt.Load(reader);
            CloseConnection();
            return dt ;
        }
        /// <summary>
        ///    Get data back in string form
        /// </summary>
        /// <param name="sqlStatment"></param>
        public String GetData(String sqlStatment)
        {
            string outputString = "null";
            try
            {
                OpenConection();
                cmd = new OleDbCommand(sqlStatment, conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    if (reader["Deleted"].ToString().Equals("False"))
                    {
                        outputString = reader["Lec_Name"].ToString();
                        outputString += "$" + reader["Initials"].ToString();
                        outputString += "$" + reader["Email"].ToString();
                        outputString += "$" + reader["MaxHours"].ToString();
                        outputString += "$" + reader["MaxConsecHours"].ToString();
                        outputString += "$" + reader["MinSlotsPerDay"].ToString();
                        outputString += "$";
                    }
                    else
                    {
                        outputString = "N/A";
                    }
                }
                CloseConnection();
            }
            catch
            {
               // MessageBox.Show("Failed to get data from source");
            }
            return outputString;
        }
        /// <summary>
        ///  Load all the lecturers for a given department
        /// </summary>
        /// <param name="dept"></param>
        /// <returns></returns>
        public LinkedList loadLectuerList(Department dept)
        {
            LinkedList lectureList = new LinkedList();
            Lecturer newLec;
            string sqlStatment = "SELECT Lec_Name, Initials, Email, MaxHours, MaxConsecHours, MinSlotsPerDays, SlotsOff, Deleted";
            sqlStatment += "FROM Lecturer WHERE Lecturer.Dept_ID LIKE" + dept.getID();
                try
                {
                    OpenConection();
                    cmd = new OleDbCommand(sqlStatment, conn);
                    reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        if (reader["Deleted"].ToString().Equals("False"))
                        {
                            newLec = new Lecturer();
                            newLec.setId(reader["ID"].ToString());
                            newLec.setName(reader["Lec_Name"].ToString());
                            newLec.setInitials(reader["Initials"].ToString());
                            newLec.setEmail(reader["Email"].ToString());
                            newLec.setMaxHours(Convert.ToInt32(reader["MaxHours"]));
                            newLec.setMaxConsecHours(Convert.ToInt32(reader["MaxConsecHours"]));
                            newLec.setMinSlotsPerDay(Convert.ToInt32(reader["MinSlotsPerDays"]));
                            newLec.setSlotsOff(reader["SlotsOff"].ToString());
                            lectureList.addAtTail(newLec);

                        }
                    }
                    CloseConnection();
                }
                catch 
                {
                    // MessageBox.Show("Failed to get data from source");
                } 
            return lectureList;
        }
        /// <summary>
        ///     returns the lectures that teach a module
        /// </summary>
        /// <param name="module"></param>
        /// <returns></returns>
        public LinkedList loadLectuerList(Module module)
        {
            LinkedList lectureList = new LinkedList();
            Lecturer newLec;
            string sqlStatment = "SELECT ID, Lec_Name, Initials, Email, MaxHours, MaxConsecHours, MinSlotsPerDays, SlotsOff, Deleted";
            sqlStatment += "FROM Lecturer, Lecturer/Module WHERE Lecturer/Module.Module_ID LIKE " + module.getID();
            try
            {
                OpenConection();
                cmd = new OleDbCommand(sqlStatment, conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    if (reader["Deleted"].ToString().Equals("False"))
                    {
                        newLec = new Lecturer();
                        newLec.setId(reader["ID"].ToString());
                        newLec.setName(reader["Lec_Name"].ToString());
                        newLec.setInitials(reader["Initials"].ToString());
                        newLec.setEmail(reader["Email"].ToString());
                        newLec.setMaxHours(Convert.ToInt32(reader["MaxHours"]));
                        newLec.setMaxConsecHours(Convert.ToInt32(reader["MaxConsecHours"]));
                        newLec.setMinSlotsPerDay(Convert.ToInt32(reader["MinSlotsPerDays"]));
                        newLec.setSlotsOff(reader["SlotsOff"].ToString());
                        lectureList.addAtTail(newLec);
                    }
                    
                }
                CloseConnection();
            }
            catch 
            {
                // MessageBox.Show("Failed to get data from source");
            }
            return lectureList;
        }
        /// <summary>
        ///     Load course list for a department
        /// </summary>
        /// <param name="dept"></param>
        /// <returns></returns>
        public LinkedList loadCourseList(Department dept)
        {
            LinkedList courses = new LinkedList();
            Course tempCourse ;

            string sqlStatment = "SELECT ID, Code, CourseName, NumOfStudents FROM Course WHERE DeptId Like  " +  dept.getID(); 
            try
            {
                OpenConection();
                cmd = new OleDbCommand(sqlStatment, conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    if (reader["Deleted"].ToString().Equals("False"))
                    {
                        tempCourse = new Course();
                        tempCourse.setID(reader["ID"].ToString());
                        tempCourse.setCourseCode(reader["Code"].ToString());
                        tempCourse.setName(reader["CourseName"].ToString());
                        tempCourse.setNumOfStudents(Convert.ToInt32(reader["NumOfStudents"]));
                        tempCourse.setModuleList(LoadModuleList(tempCourse));
                        courses.addAtTail(tempCourse);
                    }
                    
                }
                CloseConnection();
            }
            catch 
            {
                // MessageBox.Show("Failed to get data from source");
            }

            return courses ;
        }
        /// <summary>
        ///     Load the list of room for a building
        /// </summary>
        /// <param name="building"></param>
        /// <returns></returns>
        public LinkedList loadRoomList(Building building)
        {
            LinkedList roomList = new LinkedList();
            Room tempRoom;
            string sqlStatment = "SELECT * FROM Room WHERE BuildingID LIKE  " + building.getID();
            try
            {
                OpenConection();
                cmd = new OleDbCommand(sqlStatment, conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    if (reader["Deleted"].ToString().Equals("False"))
                    {
                        tempRoom = new Room();
                        tempRoom.setID(reader["ID"].ToString());
                        tempRoom.setRoomNumber(reader["Number"].ToString());
                        tempRoom.setCapacity(Convert.ToInt32(reader["Capacity"]));
                        tempRoom.setRoomType(reader["RoomType"].ToString());
                        tempRoom.setSlotsOff(reader["SlotsOff"].ToString());
                        roomList.addAtTail(tempRoom);
                    }
                }
                CloseConnection();
            }
            catch
            {
                // MessageBox.Show("Failed to get data from source");
            }
            return roomList;
        }
        /// <summary>
        ///     returns a list of departments
        /// </summary>
        /// <param name="institute"></param>
        /// <returns></returns>
        public LinkedList loadDepartmentList(Institute institute)
        {
            LinkedList deptList = new LinkedList();
            Department tempDept ;
            string sqlStatment = "SELECT * FROM Department";
            try 
	        {	        
		        OpenConection();
                cmd = new OleDbCommand(sqlStatment, conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    if (reader["Deleted"].ToString().Equals("False"))
                    {
                        tempDept = new Department();
                        tempDept.setId(reader["ID"].ToString());
                        tempDept.setName(reader["Dept_Name"].ToString());
                        tempDept.setLecturerList(loadLectuerList(tempDept));
                        tempDept.setCourseList(loadCourseList(tempDept));
                        deptList.addAtTail("tempDept");
                    }
                    
                }
                CloseConnection();
	        }
	        catch 
	        {
	
	        }
            return deptList;
        }
        /// <summary>
        ///     returns a list of buildings
        /// </summary>
        /// <param name="institute"></param>
        /// <returns></returns>
        public LinkedList loadBuildingList(Institute institute)
        {
            LinkedList buildingList = new LinkedList();
            Building tempBuild;
            string sqlStatment = "SELECT * FROM Building";
            try
            {
                OpenConection();
                cmd = new OleDbCommand(sqlStatment, conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    if (reader["Deleted"].ToString().Equals("False"))
                    {
                        tempBuild = new Building();
                        tempBuild.setId(reader["ID"].ToString());
                        tempBuild.setName("Building_Name");
                        tempBuild.setRoomList(loadRoomList(tempBuild));
                        buildingList.addAtTail(tempBuild);
                    }
                }
                CloseConnection();
            }
            catch 
            {

            }
            return buildingList;
        }
        /// <summary>
        ///     load all the modules of a course
        /// </summary>
        /// <param name="course"></param>
        /// <returns></returns>
        public LinkedList LoadModuleList(Course course)
        {
            LinkedList moduleList = new LinkedList();
            Module tempModule;
            string sqlStatment = "SELECT * FROM Course WHERE CourseCode LIKE "+ course.getCourseCode();
            try
            {
                OpenConection();
                cmd = new OleDbCommand(sqlStatment, conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    
                    if (reader["Deleted"].ToString().Equals("False"))
                    {
                        tempModule = new Module();
                        tempModule.setId(reader["ID"].ToString());
                        tempModule.setName(reader["Module_Name"].ToString());
                        tempModule.setPractical(Convert.ToBoolean(reader["Pratcial"]));
                        tempModule.setHoursPerWeek(Convert.ToInt32(reader["HoursPerWeek"]));
                        tempModule.setRoomtype(reader["RoomType"].ToString());
                        tempModule.setMaxConsecHours(Convert.ToInt32(reader["MaxConsecHours"]));
                        tempModule.setDoubleSlots(Convert.ToBoolean(reader["DoubleSlots"]));
                        moduleList.addAtTail(tempModule);
                    }
                }
                CloseConnection();
            }
            catch
            {

            }
            return moduleList;

        }
        /// <summary>
        ///     save list of lecturers to the database
        /// </summary>
        /// <param name="lecturers"></param>
        public void saveLecturers(LinkedList lecturers)
        {
            Node temp = lecturers.head;
            Lecturer tempLec ;

            while (temp.next != null)
            {
                tempLec = (Lecturer)temp.data;
                //if the lecturer is new i.e id=000 use Insert command
                if (tempLec.getId().Equals("000"))
                {
                    insertLecturer(tempLec);
                }
                else // update the lecturer entry
                {
                    updateLecturer(tempLec);
                }
                temp = temp.next;
            }
        }
        /// <summary>
        ///     save's the list of modules to the module
        /// </summary>
        /// <param name="modules"></param>
        public void saveModules(LinkedList modules)
        {
            Node temp = modules.head;
            Module tempModule;

            while (temp.next != null)
            {
                tempModule = (Module)temp.data;
                //if the modue isnt already in the database create a new entry
                if (tempModule.getID().Equals("000"))
                {
                    insertModule(tempModule);
                }
                else
                {
                    updateModule(tempModule);
                }
                temp = temp.next;
            }
        }
        /// <summary>
        ///     saves a list of rooms to the database
        /// </summary>
        /// <param name="rooms"></param>
        public void saveRoom(LinkedList rooms)
        {
            Node temp = rooms.head;
            Room tempRoom;
            while (temp.next != null)
            {
                tempRoom = (Room)temp.data;
                //if the room isnt in the database insert it else update it
                if (tempRoom.getID().Equals("000"))
                {
                    insertRoom(tempRoom);
                }
                else
                {
                    updateRoom(tempRoom);
                }
                temp = temp.next;
            }
        }
        /// <summary>
        ///     save a list of departments to the database
        /// </summary>
        /// <param name="depts"></param>
        public void saveDepartments(LinkedList depts)
        {
            Node temp = depts.head;
            Department tempDept;
            while (temp.next != null)
            {
                tempDept = (Department)temp.data;
                //if the dept is'nt in the database insert a new one else
                if (tempDept.getID().Equals("000"))
                {
                    insertDept(tempDept);
                }
                else
                {
                    updateDept(tempDept);
                }
            }

        }
    }
}

