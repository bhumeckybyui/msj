using MyScriptureJournal.Models;
using Microsoft.EntityFrameworkCore;

namespace MyScriptureJournal.Data
{
    public class SavedScripturesContext : DbContext
    {
       
        public SavedScripturesContext(DbContextOptions<SavedScripturesContext> options) : base(options)
        {
        }

        public DbSet<SavedScripture> SavedScripture { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SavedScripture>().ToTable("SavedScripture");
         
        }
    }
}
