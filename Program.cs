using System;
using System.Collections;
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

            JSONFileOutput fileOutput = new JSONFileOutput();
            JSONFileInput fileInput = new JSONFileInput();
            
            
            /*SpellBook spellBook = new SpellBook();
            ArrayList spells = spellBook.PrepareSpellBook();*/
            
            fileInput.ReadJSON();
            
            //fileOutput.WriteJson(spellBook.PrepareSpellBook());
            
            
        }
    }
}