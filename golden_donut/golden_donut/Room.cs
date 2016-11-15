using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace golden_donut
{
    public class Room
    {
        public string citynames;
        public string description;
        public bool instantDeath;
        private Room OnPlayerDeathSpawn;
        public Room North;
        public Room South;
        public Room West;
        public Room East;

        public Room(string cty, string description, bool instantDeath)
        {
        citynames=cty;
            this.description = description;
            this.instantDeath = instantDeath;


        }

        public void OnPlayerEnter()
        {
            if(instantDeath)
            {

            }
        }
        public static void AddConnection(Room r1, Room r2, Direction direction, bool oneway)
        {
            if(oneway)
            {
                switch (direction)
                {
                    case Direction.North:
                        r1.North = r2;
                        break;
                    case Direction.South:
                        r1.South = r2;
                        break;
                    case Direction.East:
                        r1.East = r2;
                        break;
                    case Direction.West:
                        r1.West = r2;
                        break;
                    default:
                        break;
                }
            }
            else
            {
                switch (direction)
                {
                    case Direction.North:
                        r1.North = r2;
                        r2.South = r1;
                        break;
                    case Direction.South:
                        r1.South = r2;
                        r2.North = r1;
                        break;
                    case Direction.East:
                        r1.East = r2;
                        r2.West = r1;
                        break;
                    case Direction.West:
                        r1.West = r2;
                        r2.East = r1;
                        break;
                    default:
                        break;
                }
            }
        }
    }

    public enum Direction
    {
        North,
        South,
        East,
        West
    }
}
