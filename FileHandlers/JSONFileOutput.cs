using System;
using System.IO;
using System.Text.Json;

namespace DnDFunTime.FileHandlers
{
    public class JSONFileOutput
    {
        public string FileName = "DndSpells.json";

        public void PrintJson(CreateSpell newSpell)
        {
            FileStream createStream = File.Create(FileName);
            string jsonString = JsonSerializer.Serialize(newSpell);
            Console.WriteLine(jsonString);
            //JsonSerializer.Serialize(createStream, newSpell);
            //Console.WriteLine(File.ReadAllTextAsync(FileName));
        }
    }
}