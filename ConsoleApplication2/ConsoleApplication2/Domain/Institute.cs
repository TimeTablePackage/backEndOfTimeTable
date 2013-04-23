using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    class Institute
    {
        private string name;
        private LinkedList deptList;
        private LinkedList buildingList;

        public Institute(string name)
        {
        }

        /// <summary>
        ///     add a building to the instutite
        /// </summary>
        /// <param name="building"></param>
        public void addBuilding(Building building)
        {
            if (buildingList == null)
            {
                buildingList = new LinkedList();
            }
            buildingList.addAtTail(building);
        }
        /// <summary>
        ///     add a department to the instutite
        /// </summary>
        /// <param name="dept"></param>
        public void addDepartment(Department dept)
        {
            if (deptList == null)
            {
                deptList = new LinkedList();
            }
            deptList.addAtTail(dept);
        }
        //Get and Set methods
        /// <summary>
        ///     set the institute name
        /// </summary>
        /// <param name="name"></param>
        public void setName(string name)
        {
            this.name = name;
        }
        /// <summary>
        ///     get the institute name
        /// </summary>
        /// <returns></returns>
        public string getName()
        {
            return this.name;
        }
        /// <summary>
        ///     set the building list
        /// </summary>
        /// <param name="buildingList"></param>
        public void setBuildingList(LinkedList buildingList)
        {
            this.buildingList = buildingList;
        }
        /// <summary>
        ///     get the building list
        /// </summary>
        /// <returns></returns>
        public LinkedList getBuildingList()
        {
            return this.buildingList;
        }
        /// <summary>
        ///     set the department list
        /// </summary>
        /// <param name="deptList"></param>
        public void setDeptList(LinkedList deptList)
        {
            this.deptList = deptList;
        }
        /// <summary>
        ///     get the department list
        /// </summary>
        /// <returns></returns>
        public LinkedList getDeptList()
        {
            return this.deptList;
        }
    }
}
