﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTS_TASK_TWO_REDO
{
    class Map
    {
        public const int SIZE = 20;

        Unit[] units;
        Building[] buildings;

        string[,] map;
        string[] teams = { "A-Team", "B-Team" };

        int numUnits;
        int numBuildings;

        Random r = new Random();

        public Map(int numUnits, int numBuildings)
        {
            this.numUnits = numUnits;
            this.numBuildings = numBuildings;

            Reset();
        }
        public Unit[] Units
        {
            get { return units; }
        }
        public Building[] Buildings
        {
            get { return buildings; }
        }
        public int Size
        {
            get { return SIZE; }
        }

        public void InitialiseUnits() //Determines which units are placed where at the start of a game
        {
            units = new Unit[numUnits];

            for (int i = 0; i < units.Length; i++)
            {
                int x = r.Next(0, SIZE);
                int y = r.Next(0, SIZE);
                int teamIndex = r.Next(0, 2);
                int unitType = r.Next(0, 2);

                while (map[x, y] != null)
                {
                    x = r.Next(0, SIZE);
                    y = r.Next(0, SIZE);
                }

                if (unitType == 0)
                {
                    units[i] = new MeleeUnit(x, y, teams[teamIndex]); //Melee Unit
                }
                else
                {
                    units[i] = new RangedUnit(x, y, teams[teamIndex]); //Ranged Unit
                }

                map[x, y] = units[i].Team[0] + "|" + units[i].Symbol;
            }
        }
        public void InitialiseBuildings() //Creates the buildings
        {
            buildings = new Building[numBuildings];

            for (int i = 0; i < buildings.Length; i++)
            {
                int x = r.Next(0,SIZE);
                int y = r.Next(0, SIZE);
                int buildingIndex = r.Next(0, 2);
                int buildingType = r.Next(0, 2);

                while (map[x, y] != null)
                {
                    x = r.Next(0, SIZE);
                    y = r.Next(0, SIZE);
                }

                if (buildingType == 0)
                {
                    buildings[i] = new ResourceBuilding(x, y, teams[buildingIndex]);
                }
                else
                {
                    buildings[i] = new FactoryBuilding(x, y, teams[buildingIndex]);
                }

                map[x, y] = buildings[i].Team[0] + "|" + buildings[i].Symbol;
            }
        }

        public void AddInUnits(Unit unit) //Spawns in the units and factories
        {
            Unit[] resizeUnits = new Unit[units.Length + 1];

            for (int i = 0; i < units.Length; i++)
            {
                resizeUnits[i] = units[i];
            }

            resizeUnits[resizeUnits.Length - 1] = unit;
            units = resizeUnits;
        }

        public void AddInBuilding (Building building) //Spawns in the units and factories
        {
            Building[] resizeBuildings = new Building[buildings.Length + 1];

            for (int i = 0; i < buildings.Length; i++)
            {
                resizeBuildings[i] = buildings[i];
            }

            resizeBuildings[resizeBuildings.Length - 1] = building;
            buildings = resizeBuildings;
        }

        public void UpdateMap()
        {
            for (int y = 0; y < SIZE; y++)
            {
                for (int x = 0; x < SIZE; x++)
                {
                    map[x, y] = "  .  ";                    
                }
            }

            foreach (Unit unit in units)
            {
                map[unit.X, unit.Y] = unit.Symbol + "|" + unit.Team[0];
            }
            foreach (Building building in buildings)
            {
                map[building.X, building.Y] = building.Symbol + "|" + building.Team[0];
            }
        }

        public string MapDisplay()
        {
            string mapString = "";
            for (int y = 0; y < SIZE; y++)
            {
                for (int x = 0; x < SIZE; x++)
                {
                    mapString += map[x, y];
                }
                mapString += "\n";
            }
            return mapString;
        }
        public void Clear() //Clears the map when loading
        {
            units = new Unit[0];
            buildings = new Building[0];
        }

        public void Reset()
        {
            map = new string[SIZE, SIZE];
            InitialiseUnits();
            InitialiseBuildings();
            UpdateMap();
        }
    }
}
