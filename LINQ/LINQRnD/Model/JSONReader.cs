using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace LINQRnD.Model
{
    public static class JSONReader<T> where T : class
    {
        public static List<T> GetAll(string dataFileName)
        {
            string json = File.ReadAllText("Model/ " + dataFileName + " .json");
            var personalInfoList = JsonConvert.DeserializeObject<List<T>>(json);
            return personalInfoList;
        }
    }
}