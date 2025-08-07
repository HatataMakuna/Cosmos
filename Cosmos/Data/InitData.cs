using System;
using System.Collections.Generic;
using Cosmos.Model;

namespace Cosmos.Data
{
    // This class is only to initialize the data for development purposes.
    // For release version, this class should not be used.
    public class InitData
    {
        public List<Obstacle> Obstacles { get; private set; }
        public List<Channel> Channels { get; private set; }
        public List<Player> Players { get; private set; }

        public InitData(List<Obstacle> obstacles, List<Channel> channels, List<Player> players)
        {
            Obstacles = obstacles ?? new List<Obstacle>();
            Channels = channels ?? new List<Channel>();
            Players = players ?? new List<Player>();

            // If the lists are empty, initialize them with default values
            if (Obstacles.Count == 0 || Channels.Count == 0 || Players.Count == 0)
            {
                Initialize();
            }
        }

        public void Initialize()
        {
            // Initialize the data for the Cosmos application
            // This could include setting up initial players, obstacles, channels, etc.
            Obstacles = new List<Obstacle>
            {
                new Obstacle(1, "Wall Climb", "A steep wall that requires climbing skills.", 3, 120, new List<string> { "climbing" }, 5, 15, 10, 12, 14, 10, 8, 9, 11, 13, 10),
                new Obstacle(2, "Balance Beam", "A narrow beam that tests balance.", 2, 60, new List<string> { "balance" }, 3, 10, 8, 9, 7, 6, 15, 12, 5, 8, 7),
                new Obstacle(3, "Monkey Bars", "A series of bars to swing across.", 4, 150, new List<string> { "strength", "agility" }, 6, 12, 14, 15, 16, 11, 13, 10, 18, 14, 12),
                new Obstacle(4, "Rope Swing", "A rope swing to cross a gap.", 3, 90, new List<string> { "lache" }, 4, 11, 10, 12, 13, 9, 14, 10, 15, 12, 11),
                new Obstacle(5, "Cargo Net", "A net to climb over.", 2, 80, new List<string> { "climbing" }, 3, 10, 9, 11, 12, 8, 7, 10, 9, 11, 10),
                new Obstacle(6, "Woodpost Stairs", "A set of unstable poles that require careful balance, most players tend to complete this obstacle in quick time but speed kills, who knows.", 3, 100, new List<string> { "balance", "agility" }, 4, 9, 8, 10, 11, 7, 12, 13, 6, 10, 9)
            };

            Channels = new List<Channel>
            {
                new Channel(1, "Beginner Channel", 1, GetRandomObstacle()),
                new Channel(2, "Intermediate Channel", 2, GetRandomObstacle()),
                new Channel(3, "Advanced Channel", 3, GetRandomObstacle())
            };

            Players = new List<Player>
            {
                new Player { ID = 1, name = "Player 1", availablePoints = 5, speed = 10, tech = 10, grip = 10, strength = 10, balance = 10, lache = 10, stamina = 10, intelligence = 10 },
                new Player { ID = 2, name = "Player 2", availablePoints = 3, speed = 12, tech = 11, grip = 9, strength = 14, balance = 8, lache = 10, stamina = 12, intelligence = 11 }
            };

            Console.WriteLine("Cosmos data initialized.");
        }

        // Method to get a random obstacle
        public Obstacle GetRandomObstacle()
        {
            Random rand = new Random();
            int index = rand.Next(Obstacles.Count);
            return Obstacles[index];
        }
    }
}