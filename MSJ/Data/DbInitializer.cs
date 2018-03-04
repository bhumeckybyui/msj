using MyScriptureJournal.Models;
using System;
using System.Linq;

namespace MyScriptureJournal.Data
{
    public class DbInitializer
    {

        public static void Initialize(SavedScripturesContext context)
        {
            context.Database.EnsureCreated();

            if (context.SavedScripture.Any())
            {
                return;   // DB has been seeded
            }
            var sciprutres = new SavedScripture[]
           {
                new SavedScripture{
                    Book="1 Nephi",
                    Chapter=1,
                    verse=1,
                    DateAdded=DateTime.Parse("2005-09-01"),
                    Notes= "I like this one"
                    
                 }
            
           };
            context.SaveChanges();
        }
    }
}