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
			Room r8 = new Room("Lyon");
			Room r9 = new Room("Nates");
			Room r10 = new Room("Rennes");
			Room r11 = new Room("Le Havre");
			Room r12 = new Room("Reims");
			Room r13 = new Room("Saint-Etienne");
			Room r14 = new Room("Toulon");
			Room r15 = new Room("Grenoble");
            Room r16 = new Room("Paris");

			Room r17 = new Room("The Louvre");
			Room r18 = new Room("The Créme Bûléé Crater");
			Room r19 = new Room("The Musée d'Orsay");
			Room r20 = new Room("The Moulin Rouge");
			Room r21 = new Room("The Champs-Élysées");
			Room r22 = new Room("The Notre Dame de Paris");
			Room r23 = new Room("The Basilica of Sacre Coeur");
			Room r24 = new Room("Arc de Triomphe");
			Room r25 = new Room("Montmartre");
			Room r26 = new Room("Sainte-Chapelle");
			Room r27 = new Room("Latin Quarter");
			Room r28 = new Room("Pére Lachaise Cemetery");
			Room r29 = new Room("Panthéon");

			Room r30 = new Room("The Eiffel Tower");

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
