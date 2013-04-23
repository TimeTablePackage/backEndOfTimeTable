using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    class Generate
    {

        LinkedList population; //linked list of chromosome
        
        Room[] roomArray ;
        Lesson[] lessonList;
        int[] chromosome;

        public Generate(Institute institute)
        {
            //load all the room from the instuite into a single room
            LinkedList Buildings = institute.getBuildingList();
            Node buildNode = Buildings.head ;
            while (buildNode.next != null)
            {
                Building tempBuild = (Building)buildNode.data;
                LinkedList roomList = tempBuild.getRoomList();
                Node roomNode = roomList.head;

                while ()
                {
                    
                }
            }

        }

        public void generateRandom()
        {
            
        }



    }
}
