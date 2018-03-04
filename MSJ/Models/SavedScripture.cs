using System;
namespace MyScriptureJournal.Models
{
    public class SavedScripture
    {

        public int Id { get; set; }
        public String Book { get; set; }
        public int Chapter { get; set;  }
        public int verse { get; set;  }
        public DateTime DateAdded { get; set; }
        public string Notes { get; set;  }

    }
}


//book, chapter, verse, note, and date added fields