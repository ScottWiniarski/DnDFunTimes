using System;
using System.Collections;
using System.Collections.Generic;
using System.Text.Json;

namespace DnDFunTime
{
    public class SpellBook
    {
        public ArrayList ListOfSpells = new ArrayList();

        public string[] spellNames = {"Minor Illusion", "Cone of Cold", "Ray of Frost"};

        public string[] spellDescrip =
            {"Create a noise or image", "Shoot a cone of chilling frost", "A beam of freezing air"};

        public int[] spellLevels = {0, 4, 0};
        public string[] spellTypes = {"Illusion", "Evocation", "Evocation"};
        public string[] castTimes = {"Action", "Action", "Action"};
        public string[] durations = {"1 Minute", "Instant", "Instant"};
        public bool[] actives = {true, true, true};


        public void WriteJson()
        {
            for (int i = 0; i < 3; i++)
            {
                CreateSpell spell = new CreateSpell(spellNames[i], spellDescrip[i], spellLevels[i],
                    spellTypes[i], castTimes[i], durations[i], actives[i]);

                ListOfSpells.Add(spell);
            }

            string jsonString = JsonSerializer.Serialize(ListOfSpells);
            Console.WriteLine(jsonString);
        }
    }
}