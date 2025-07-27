using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cosmos.Model;

namespace Cosmos.Data
{
    public class InitData
    {
        public List<Obstacle> Obstacles { get; private set; }
        public List<Channel> Channels { get; private set; }
        public List<Player> Players { get; private set; }

        public void Initialize()
        {
            // Initialize the data for the Cosmos application
            // This could include setting up initial players, obstacles, channels, etc.
            // For now, we will just print a message to indicate initialization
            Obstacles = new List<Obstacle>
            {
                new Obstacle(1, "Wall Climb", "A steep wall that requires climbing skills.", 3, 120, 5, new List<string> { "climbing" }, 15, 10, 12, 14, 10, 8, 9, 11, 13, 10),
                new Obstacle(2, "Balance Beam", "A narrow beam that tests balance.", 2, 60, 3, new List<string> { "balance" }, 10, 8, 9, 7, 6, 15, 12, 5, 8, 7),
                new Obstacle(3, "Monkey Bars", "A series of bars to swing across.", 4, 150, 6, new List<string> { "strength", "agility" }, 12, 14, 15, 16, 11, 13, 10, 18, 14, 12)
            };

            Channels = new List<Channel>
            {
                new Channel { ID = 1, name = "Beginner Channel", currentLevel = 1, currentObstacle = Obstacles[0] },
                new Channel { ID = 2, name = "Intermediate Channel", currentLevel = 2, currentObstacle = Obstacles[1] },
                new Channel { ID = 3, name = "Advanced Channel", currentLevel = 3, currentObstacle = Obstacles[2] }
            };

            Players = new List<Player>
            {
                new Player { ID = 1, name = "Player 1", availablePoints = 5, speed = 10, tech = 10, grip = 10, strength = 10, balance = 10, lache = 10, stamina = 10, intelligence = 10 },
                new Player { ID = 2, name = "Player 2", availablePoints = 3, speed = 12, tech = 11, grip = 9, strength = 14, balance = 8, lache = 10, stamina = 12, intelligence = 11 }
            };

            // Here you would typically save these initialized objects to a database or some persistent storage


            Console.WriteLine("Cosmos data initialized.");
        }
    }
}