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
            Room r1 = new Room("Montpellier"," ", false);
            Room r2 = new Room("Bordeaux"," ", false);
            Room r3 = new Room("Lille","A carrot-guard seems to be lurking a few metres up the street! Better turn around …", false);
            Room r4 = new Room("Strasbourg","A carrot-guard seems to be lurking a few metres up the street! Better turn around …", false);
            Room r5 = new Room("Toulouse","A donut! One step closer to saving the nation.", false);
            Room r6 = new Room("Nice", " ", false);
            Room r7 = new Room("Marseille","A carrot-guard seems to be lurking a few metres up the street! Better turn around …", false);
			Room r8 = new Room("Lyon", " ", false);
			Room r9 = new Room("Nates", " ", false);
			Room r10 = new Room("Rennes", " ", false);
			Room r11 = new Room("Le Havre", " ", false);
			Room r12 = new Room("Reims","A donut! One step closer to saving the nation.", false);
			Room r13 = new Room("Saint-Etienne", " ", false);
			Room r14 = new Room("Toulon","A carrot-guard seems to be lurking a few metres up the street! Better turn around …", false);
			Room r15 = new Room("Paris","A donut! That was the last. Now I only need the Golden Donut to free our country!", false);
            Room r16 = new Room("Grenoble", "A carrot-guard seems to be lurking a few metres up the street! Better turn around …", false);

			Room r17 = new Room("The Louvre","To the south is the Crème Brûlée Crater! Going further could lead to serious consequences…", false);
			Room r18 = new Room("The Créme Bûléé Crater", " ", true);
			Room r19 = new Room("The Musée d'Orsay", " ", false);
			Room r20 = new Room("The Moulin Rouge", " ", false);
			Room r21 = new Room("The Champs-Élysées","A carrot-guard seems to be lurking a few metres up the street! Better turn around …", false);
			Room r22 = new Room("The Notre Dame de Paris", " ", false);
			Room r23 = new Room("The Basilica of Sacre Coeur", " ", false);
			Room r24 = new Room("Arc de Triomphe", " ", false);
			Room r25 = new Room("Montmartre","An armed broccoli soldier sees me and draws a battered rifle! - my rapier won't do, better run for my life!", true);
			Room r26 = new Room("Sainte-Chapelle", " ", false);
			Room r27 = new Room("Latin Quarter", " ", false);
			Room r28 = new Room("Pére Lachaise Cemetery", " ", false);
			Room r29 = new Room("Panthéon","The golden donut! It shines like a thousand stars … Now I can finally go to the Eiffel Tower and end this regime once and for all.", false);

			Room r30 = new Room("The Eiffel Tower", " ", false);

            rooms.Add(r1);
            rooms.Add(r2);
            rooms.Add(r3);
            rooms.Add(r4);
            rooms.Add(r5);
            rooms.Add(r6);
            rooms.Add(r7);
            rooms.Add(r8);

            //W1

            Room.AddConnection(r1, r2, Direction.North, true);
            Room.AddConnection(r2, r3, Direction.East, false);
            Room.AddConnection(r2, r4, Direction.North, false);
            Room.AddConnection(r2, r5, Direction.West, true);
            Room.AddConnection(r5, r6, Direction.West, true);
            Room.AddConnection(r6, r7, Direction.South, false);
            Room.AddConnection(r6, r8, Direction.West, true);
            Room.AddConnection(r6, r10, Direction.North, true);
            Room.AddConnection(r8, r9, Direction.North, true);
            Room.AddConnection(r9, r10, Direction.East, false);
            Room.AddConnection(r9, r11, Direction.North, true);
            Room.AddConnection(r10, r16, Direction.East, false);
            Room.AddConnection(r11, r12, Direction.East, true);
            Room.AddConnection(r12, r13, Direction.East, true);
            Room.AddConnection(r13, r14, Direction.North, false);
            Room.AddConnection(r13, r15, Direction.East, true);

            //W2

            //Room.AddConnection(r17, r18)
            Room.AddConnection(r17, r19, Direction.East, true);
            Room.AddConnection(r19, r20, Direction.South, true);
            Room.AddConnection(r20, r21, Direction.East, false);
            Room.AddConnection(r20, r22, Direction.South, true);
            Room.AddConnection(r22, r23, Direction.South, false);
            Room.AddConnection(r22, r24, Direction.West, false);
            Room.AddConnection(r23, r25, Direction.West, true);
            Room.AddConnection(r24, r25, Direction.South, true);
        }
    }
}
