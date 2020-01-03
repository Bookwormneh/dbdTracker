using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dbdTracker
{
    class dataHandler
    {
        static string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\dbdTrackerData\\";
        static string dataPath = folderPath + "dbdTrackerData.json";

        public static userData getData(string id)
        {
            if (!Directory.Exists(folderPath))
            {
                createFolder();
            }
            if (!File.Exists(dataPath))
            {
                createFile();
                
            }

            List<userData> items;
            using (StreamReader r = new StreamReader(dataPath))
            {
                string json = r.ReadToEnd();
                items = JsonConvert.DeserializeObject<List<userData>>(json);
            }
            
            if (items == null)
            {
                return new userData();
            }

            for (int i = 0; i < items.Count; i++)
            {
                if (items[i].steamID == id)
                {
                    return items[i];
                }
            }

            return new userData();
        }

        public static void writeData(userData data)
        {
            using (StreamWriter file = File.CreateText(dataPath))
            {
                JsonSerializer serializer = new JsonSerializer();
                //serialize object directly into file stream
                serializer.Serialize(file, data);
            }
        }

        private static void createFolder()
        {
            System.IO.Directory.CreateDirectory(folderPath);
        }

        private static void createFile()
        {
            using (System.IO.FileStream fs = System.IO.File.Create(dataPath))
            {
                
            }
        }
    }
}
