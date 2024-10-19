using System;
using System.Linq;

namespace DnDFunTime
{
    public class CreateSpell : ActiveSpell
    {
        /*private string _name = "Minor Illusion";
        private string _Description = "Create a noise or image at a chosen location.";
        private int _SpellLevel = 0;
        private string _SpellType = "Illusion";
        private string _CastTime = "Action";
        private string _Duration = "1 Minute";
        private bool _IsActive = true;*/

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

        /*public string SpellName
        {
            get => _name;
            set => _name = value;
        }
        public string SpellDescription 
        {
            get => _Description;
            set => _Description = value;
        }
        public int SpellLevel 
        {
            get => _SpellLevel;
            set => _SpellLevel = value;
        }
        public string SpellType 
        {
            get => _SpellType;
            set => _SpellType = value;
        }
        public string CastTime 
        {
            get => _CastTime;
            set => _CastTime = value;
        }
        public string Duration { get; set; }
        public bool IsActive 
        { 
            get => _IsActive;
            set => _IsActive = value;
        }

        public void LoadSpell(string name, string description, int spellLevel, string duration, string castTime,
            string spellType, bool isActive)
        {
            
        }*/
        /*public void LoadSpell()
        {
            CreateSpell spell = new CreateSpell();
            ((Spell)spell).Name = SpellName;
            ((Spell)spell).Description = SpellDescription;
            ((Spell)spell).SpellLevel = SpellLevel;
            ((Spell)spell).Duration = Duration;
            ((Spell)spell).CastTime = CastTime;
            ((Spell)spell).SpellType = SpellType;
            spell.IsActive = IsActive;
        }*/
    }
}