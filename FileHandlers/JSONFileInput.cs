using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace DnDFunTime.FileHandlers
{
    public class JSONFileInput
    {
        public class Spell
        {
            [JsonPropertyName("IsActive")]
            public bool IsActive { get; set; }
            [JsonPropertyName("Name")] 
            public string Name { get; set; }
            [JsonPropertyName("Description")] 
            public string Description { get; set; }
            [JsonPropertyName("SpellLevel")] 
            public int SpellLevel { get; set; }
            [JsonPropertyName("SpellType")] 
            public string SpellType { get; set; }
            [JsonPropertyName("CastTime")] 
            public string CastTime { get; set; }
            [JsonPropertyName("Duration")] 
            public string Duration { get; set; }
        }

        public void ReadJSON()
        {
            string fileName = @"C:\Users\Owner\RiderProjects\DnDFunTime\DndSpells.json";
            //using FileStream openStream = File.OpenRead(fileName);
            string openStream = File.ReadAllText(fileName);
            Console.WriteLine(openStream);

           // ActiveSpell? activeSpell = await JsonSerializer.Deserialize< ActiveSpell >(openStream);
           var spellList = JsonSerializer.Deserialize<List<Spell>>(openStream);
           
           Console.WriteLine(spellList);
           foreach (var spell in spellList)
           {
               Console.WriteLine(spell.Name);
           }
        }
    }
}