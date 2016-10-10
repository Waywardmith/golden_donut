using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace golden_donut
{
    class Rooms
    {
        public List<Room> rooms;


        public Rooms()
        {
            rooms = new List<Room>();
            Room r1 = new Room("Montpellier");
            Room r2 = new Room("Bordeaux");
            Room r3 = new Room("Lille");
            Room r4 = new Room("Strasbourg");
            Room r5 = new Room("Toulouse");
            Room r6 = new Room("Nice");
            Room r7 = new Room("Marseille");
            Room r8 = new Room("Paris");

            rooms.Add(r1);
            rooms.Add(r2);
            rooms.Add(r3);
            rooms.Add(r4);
            rooms.Add(r5);
            rooms.Add(r6);
            rooms.Add(r7);
            rooms.Add(r8);
        }
    }
}
