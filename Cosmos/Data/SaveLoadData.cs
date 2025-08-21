using Cosmos.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace Cosmos.Data
{
    public class SaveLoadData
    {
        private const string DataFileName = "UserData.cosmos";
        private const string SudoFileName = "SudoData.cosmos";

        // Save and load main data for the application
        public void SaveData(List<Player> players, List<Channel> channels, List<Obstacle> obstacles)
        {
            var data = new Tuple<List<Player>, List<Channel>, List<Obstacle>>(players, channels, obstacles);
            try
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    formatter.Serialize(ms, data);
                    byte[] rawData = ms.ToArray();
                    string base64Data = Convert.ToBase64String(rawData);

                    File.WriteAllText(DataFileName, base64Data, Encoding.UTF8);
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
                    string base64Data = File.ReadAllText(DataFileName, Encoding.UTF8);
                    byte[] rawData = Convert.FromBase64String(base64Data);

                    using (MemoryStream ms = new MemoryStream(rawData))
                    {
                        BinaryFormatter formatter = new BinaryFormatter();
                        var data = (Tuple<List<Player>, List<Channel>, List<Obstacle>>)formatter.Deserialize(ms);
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

        // Save and load sudo data for the application
        // Include competitors and courses
    }
}
