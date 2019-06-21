using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace LINQRnD.Model
{
    public static class JSONReader
    {
        public static List<PersonalInfo> GetAll()
        {
            string json = File.ReadAllText("Model/dummydata.json");
            var personalInfoList = JsonConvert.DeserializeObject<List<PersonalInfo>>(json);
            return personalInfoList;
        }
    }
}