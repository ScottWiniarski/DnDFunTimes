using System;
using System.Collections;
using System.IO;
using System.Text.Json;

namespace DnDFunTime.FileHandlers
{
    public class JSONFileOutput
    {
        //public string FileName = "DndSpells.json";

        public void WriteJson(ArrayList ListOfSpells)
        {
            var options = new JsonSerializerOptions {WriteIndented = true};
            string jsonString = JsonSerializer.Serialize(ListOfSpells, options);
            Console.WriteLine(jsonString);
            File.WriteAllText(@"C:\Users\Owner\RiderProjects\DnDFunTime\DndSpells.json", jsonString);
        }
    }
}