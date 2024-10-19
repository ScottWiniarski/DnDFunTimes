using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using DnDFunTime.FileHandlers;

namespace DnDFunTime
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            /*CreateSpell newSpell = new CreateSpell();
            newSpell.LoadSpell();*/
            SpellBook spellBook = new SpellBook();
            spellBook.WriteJson();

            /*
             * // can determine what object type the properties are, but cannot access the values 
            PropertyInfo[] props = typeof(CreateSpell).GetProperties();
            foreach (PropertyInfo peas in props)
            {
                //Where value is the value you're wanting to write in (so from your resultItems array)
                //props.SetValue(newSpell, value);
                Console.WriteLine(peas.Name);
                var val = peas.PropertyType;
                if (val == typeof(string) || val == typeof(int) || val == typeof(bool))
                {
                    // gets the actual type of the property and prints it, like String or Boolean.
                    Console.WriteLine(peas.PropertyType.Name, peas.PropertyType.GetEnumValues());
                }
            }
            */

            JSONFileOutput jsonOutput = new JSONFileOutput();
            //jsonOutput.PrintJson(newSpell);
        }
    }
}