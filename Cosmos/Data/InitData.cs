using System;
using System.Collections.Generic;
using Cosmos.Model;

namespace Cosmos.Data
{
    // This class is only to initialize the data for development purposes.
    public class InitData
    {
        public List<Obstacle> Obstacles { get; private set; }
        public List<Channel> Channels { get; private set; }
        public List<Player> Players { get; private set; }
        public List<Course> Courses { get; private set; }
        public List<Competitor> Competitors { get; private set; }

        public InitData(List<Obstacle> obstacles, List<Channel> channels, List<Player> players, List<Course> courses, List<Competitor> competitors)
        {
            Obstacles = obstacles ?? new List<Obstacle>();
            Channels = channels ?? new List<Channel>();
            Players = players ?? new List<Player>();
            Courses = courses ?? new List<Course>();
            Competitors = competitors ?? new List<Competitor>();

            // If the lists are empty, initialize them with default values
            if (Obstacles.Count == 0 || Channels.Count == 0 || Players.Count == 0)
            {
                Initialize();
            }

            if (Courses.Count == 0 || Competitors.Count == 0)
            {
                InitializeCompetitorsAndCourses();
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
                new Channel(1, "Channel 1", 1, GetRandomObstacle()),
                new Channel(2, "Channel 2", 2, GetRandomObstacle()),
                new Channel(3, "Channel 3", 3, GetRandomObstacle())
            };

            Players = new List<Player>
            {
                new Player { ID = 1, name = "Player 1", availablePoints = 5, speed = 10, tech = 10, grip = 10, strength = 10, balance = 10, lache = 10, stamina = 10, intelligence = 10 },
                new Player { ID = 2, name = "Player 2", availablePoints = 3, speed = 12, tech = 11, grip = 9, strength = 14, balance = 8, lache = 10, stamina = 12, intelligence = 11 }
            };

            Console.WriteLine("Cosmos data initialized.");
        }

        // Method to initalize competitors and courses
        public void InitializeCompetitorsAndCourses()
        {
            Competitors = new List<Competitor>
            {
                new Competitor(1, "Competitor 1", 1, 1, 1, 1, 1, 1, 1, 2, 2, 2, "oof", 1, false),
                new Competitor(2, "Competitor 2", 1, 1, 1, 1, 1, 1, 1, 2, 2, 2, "oof", 1, false)
            };
            Console.WriteLine("Competitors initialized." + Environment.NewLine + "Competitors count: " + Competitors.Count);
            Courses = new List<Course>
            {
                new Course(1, "Course 1",
                    new List<Stage>{
                        // Obstacles[0] return null
                        new Stage("1", "Stage 1", new List<Obstacle> { Obstacles[0], Obstacles[1], Obstacles[2] }, 60),
                        new Stage("2", "Stage 2", new List<Obstacle> { Obstacles[0], Obstacles[1], Obstacles[2] }, 60),
                        new Stage("3", "Stage 3", new List<Obstacle> { Obstacles[0], Obstacles[1], Obstacles[2] }, 60),
                        new Stage("4", "Stage 4", new List<Obstacle> { Obstacles[0], Obstacles[1], Obstacles[2] }, 60),
                    }
                ),
                new Course(1, "Course 1",
                    new List<Stage>{
                        new Stage("1", "Stage 1", new List<Obstacle> { Obstacles[0], Obstacles[1], Obstacles[2] }, 60),
                        new Stage("2", "Stage 2", new List<Obstacle> { Obstacles[0], Obstacles[1], Obstacles[2] }, 60),
                        new Stage("3", "Stage 3", new List<Obstacle> { Obstacles[0], Obstacles[1], Obstacles[2] }, 60),
                        new Stage("4", "Stage 4", new List<Obstacle> { Obstacles[0], Obstacles[1], Obstacles[2] }, 60),
                    }
                ),
            };
            Console.WriteLine("Courses initialized." + Environment.NewLine + "Courses count: " + Courses.Count);
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