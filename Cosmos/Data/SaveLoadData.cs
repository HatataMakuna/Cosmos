using Cosmos.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Cosmos.Data
{
    public class SaveLoadData
    {
        private const string DataFileName = "UserData.cosmos";

        public void SaveData(List<Player> players, List<Channel> channels, List<Obstacle> obstacles)
        {
            var data = new Tuple<List<Player>, List<Channel>, List<Obstacle>>(players, channels, obstacles);
            try
            {
                using (FileStream fs = new FileStream("UserData.cosmos", FileMode.Create))
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    formatter.Serialize(fs, data);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error saving data: " + ex.Message);
            }
        }

        public (List<Player> players, List<Channel> channels, List<Obstacle> obstacles, bool flag) LoadData()
        {
            if (File.Exists(DataFileName))
            {
                try
                {
                    using (FileStream fs = new FileStream(DataFileName, FileMode.Open))
                    {
                        BinaryFormatter formatter = new BinaryFormatter();
                        var data = (Tuple<List<Player>, List<Channel>, List<Obstacle>>)formatter.Deserialize(fs);
                        return (data.Item1, data.Item2, data.Item3, false);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error loading data: " + ex.Message);
                    return (new List<Player>(), new List<Channel>(), new List<Obstacle>(), true);
                }
            }
            else
            {
                Console.WriteLine("Data file not found.");
            }
            // Return empty lists if loading fails
            return (new List<Player>(), new List<Channel>(), new List<Obstacle>(), false);
        }
    }
}
