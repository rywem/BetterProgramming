using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MontyHall
{
    public class DoorContainer
    {
        public List<Door> Doors { get; set; } 
        private List<Door> StartDoors { get; set; }

        public DoorContainer()
        {
            this.Doors = new List<Door>();


            this.StartDoors = new List<Door>
            {
                new Door() { HasGoat = false },
                new Door() { HasGoat = false },
                new Door() { HasGoat  = true }
            };          
        }

        public void Randomize()
        {
            List<int> spots = new List<int>{ 0, 1, 2 };

            Random rand = new Random();

            int firstPosition = rand.Next() % 3; // 8 / 2 = 4 r0, 8/3 = 2, 8 % 2  = 2 
            this.Doors.Add(StartDoors[firstPosition]);
            StartDoors.RemoveAt(firstPosition);

            int secondPosition = rand.Next() % 2;
            this.Doors.Add(StartDoors[secondPosition]);
            StartDoors.RemoveAt(secondPosition);

            this.Doors.Add(StartDoors[0]);

            StartDoors[0].DoorNumber = 1;
            StartDoors[1].DoorNumber = 2;
            StartDoors[2].DoorNumber = 3;
        }
        

        public void SelectDoorNumber(int selectedDoor)
        {
            //selectedDoor = selectedDoor - 1;
            Door door = this.Doors.FirstOrDefault(x => x.DoorNumber == selectedDoor);
            door.IsSelected = true;
            //this.Doors[selectedDoor].IsSelected = true;
        }

        public void ShowAndRemoveUnselectedGoat()
        {
            Door unselectedDoorWithGoat = this.Doors.FirstOrDefault(x => x.HasGoat == true && x.IsSelected == false);
            Console.WriteLine(unselectedDoorWithGoat.DoorNumber);
        }
           

    }

    public class Door
    {
        public bool HasGoat { get; set;  }
        public bool IsSelected { get; set; }
        public int DoorNumber { get; set; }

        public Door()
        {
            this.IsSelected = false;
        }

    }
}
