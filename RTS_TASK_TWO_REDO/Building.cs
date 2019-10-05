using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTS_TASK_TWO_REDO
{
    public enum ResourceType
    {
        WOOD,
        ROCK,
        GEMS,
        GOLD,
        FOOD
    }
    abstract class Building
    {
        protected int x;
        protected int y;
        protected int health;
        protected int maxHealth;
        protected string team;
        protected char symbol;
        protected bool isDestroyed = false;

        public Building(int x, int y, int health, string team, char symbol)
        {
            this.x = x;
            this.y = y;
            this.health = health;
            this.maxHealth = health;
            this.team = team;
            this.symbol = symbol;
        }
        public Building() { }

        public int X
        {
            get { return x; }
        }
        public int Y
        {
            get { return y; }
        }
        public string Team
        {
            get { return team; }
        }
        public char Symbol
        {
            get { return symbol; }
        }
        public abstract void Destroy();
        public abstract string Save();
        public override string ToString()
        {
            return
                "Team: " + team + "\n" +
                "Position: " + x + "," + y + "\n" +
                "Health: " + health + "|" + maxHealth + "\n";
        }
    }
}
