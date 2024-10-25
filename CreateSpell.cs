using System;
using System.Linq;

namespace DnDFunTime
{
    public class CreateSpell : ActiveSpell
    {
        public CreateSpell(string name, string description, int spellLevel, string spellType, string castTime,
            string duration, bool isActive)
        {
            this.Name = name;
            this.Description = description;
            this.SpellLevel = spellLevel;
            this.SpellType = spellType;
            this.CastTime = castTime;
            this.Duration = duration;
            this.IsActive = isActive;
        }
    }
}