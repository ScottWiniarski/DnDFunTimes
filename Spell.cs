using System;

namespace DnDFunTime
{
    public abstract class Spell
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int SpellLevel { get; set; }
        public string SpellType { get; set; }
        public string CastTime { get; set; }
        public string Duration { get; set; }
    }
}