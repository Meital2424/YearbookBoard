//התקנת הפאקג'ים
using Microsoft.EntityFrameworkCore; 
using YearbookBoard.Core.Entities;

namespace YearbookBoard.Data
{
    // DbContext הגדרת הורשה של 
    //DbSet -וכן שינוי הסוג מליסט ל
    public class DataContext : DbContext
    {
        public DbSet<Event> EventList { get; set; }

        public DbSet<TelephoneBoard> TelephoneBoardList { get; set; }

        public DbSet<Updates> UpdatesList { get; set; }

        // OnConfiguring דריסת הפונקציה 
        // שימוש בדטאבייס לוקאלי
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=meital_db");
        }


        //public DataContext()
        //{
        //    EventList = new List<Event>();

        //    TelephoneBoardList = new List<TelephoneBoard>();

        //    UpdatesList = new List<Updates>();
        //}
    }
}