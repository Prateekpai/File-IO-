using System;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace JSONDemo
{
    public class JSONHandler
    {
        public static void JSONImplement()
        {
            string importJSONFilePath = @"E:\LFP 119\Day 28\UC15\UC15\Import.json";

            string ExportJSOnFilePath = @"E:\LFP 119\Day 28\UC15\UC15\Export.json";

            var Obj = JsonConvert.DeserializeObject<List<AddressData>>(File.ReadAllText(importJSONFilePath));

            JsonSerializer serializer = new JsonSerializer();
            using (StreamWriter sw = new StreamWriter(ExportJSOnFilePath))
            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                serializer.Serialize(writer, Obj);
            }
        }
    }
}
