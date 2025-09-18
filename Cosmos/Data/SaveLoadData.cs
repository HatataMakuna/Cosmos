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
        public void SaveData(
            List<Player> players, List<Channel> channels, List<Obstacle> obstacles
        )
        {
            var mainData = new Tuple<List<Player>, List<Channel>, List<Obstacle>>(players, channels, obstacles);
            SaveDataProcess(DataFileName, mainData);
        }

        public void SaveSudoData(List<Course> courses, List<Competitor> competitors)
        {
            var sudoData = new Tuple<List<Course>, List<Competitor>>(courses, competitors);
            SaveDataProcess(SudoFileName, sudoData);
        }

        private void SaveDataProcess(string fileName, object data)
        {
            try
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    formatter.Serialize(ms, data);
                    byte[] rawData = ms.ToArray();
                    string base64Data = Convert.ToBase64String(rawData);

                    File.WriteAllText(fileName, base64Data, Encoding.UTF8);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error saving main data: " + ex.Message);
            }
        }

        public (List<Player> players, List<Channel> channels, List<Obstacle> obstacles, bool flag) LoadData()
        {
            bool isError;
            var data = LoadDataProcess<
                Tuple<List<Player>, List<Channel>, List<Obstacle>>
            >(DataFileName, out isError);

            if (isError || data == null)
            {
                return (new List<Player>(), new List<Channel>(), new List<Obstacle>(), true);
            }

            return (data.Item1, data.Item2, data.Item3, false);
        }

        public (List<Competitor> competitors, List<Course> courses, bool flag) LoadSudoData()
        {
            bool isError;
            var data = LoadDataProcess<
                Tuple<List<Competitor>, List<Course>>
            >(SudoFileName, out isError);

            if (isError || data == null)
            {
                return (new List<Competitor>(), new List<Course>(), true);
            }

            return (data.Item1, data.Item2, false);
        }

        // T - generics to handle different tuple types
        private T LoadDataProcess<T>(string fileName, out bool isError) where T : class
        {
            isError = false;

            if (File.Exists(fileName))
            {
                try
                {
                    string base64Data = File.ReadAllText(fileName, Encoding.UTF8);
                    byte[] rawData = Convert.FromBase64String(base64Data);

                    using (MemoryStream ms = new MemoryStream(rawData))
                    {
                        BinaryFormatter formatter = new BinaryFormatter();
                        return (T)formatter.Deserialize(ms);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error loading data from {fileName}: " + ex.Message);
                    isError = true;
                    return default;
                }
            }
            else
            {
                Console.WriteLine($"Data file {fileName} not found.");
                isError = true;
                return default;
            }
        }
    }
}
