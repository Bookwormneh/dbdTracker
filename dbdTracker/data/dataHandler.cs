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
        static readonly string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\dbdTrackerData\\";
        static readonly string dataPath = folderPath + "dbdTrackerData.json";

        public static List<userData> data;

        public static void getData()
        {
            if (!Directory.Exists(folderPath))
            {
                createFolder();
            }
            if (!File.Exists(dataPath))
            {
                createFile();
                
            }

            if (data == null)
            {
                data = new List<userData>();
                return;
            }

            //List<userData> items;
            using (StreamReader r = new StreamReader(dataPath))
            {
                string json = r.ReadToEnd();
                data = JsonConvert.DeserializeObject<List<userData>>(json);
            }
            
            //return items;
        }
        
        public static void writeData()
        {
            using (StreamWriter file = File.CreateText(dataPath))
            {
                JsonSerializer serializer = new JsonSerializer();
                //serialize object directly into file stream
                serializer.Serialize(file, data);
            }
        }

        public static int findData(string ID)
        {
            if (data == null)
            {
                return -1;
            }

            for (int i = 0; i < data.Count; i++)
            {
                if (data[i].steamID == ID)
                {
                    return i;
                }
            }
            return -1;
        }

        public static int addData(string ID)
        {
            data.Add(new userData());
            data[data.Count - 1].steamID = ID;
            return data.Count - 1;
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
