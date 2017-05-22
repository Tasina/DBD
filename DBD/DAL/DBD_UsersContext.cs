using System.Data.Entity;

namespace DBD.DAL
{
    public class DBD_UsersContext : DbContext
    {
        public DBD_UsersContext() : base("name=DBD_Users_Database")
        {
            Database.SetInitializer(new DBD_UsersDbInitializer());
        }
               public System.Data.Entity.DbSet<Models.User> Users { get; set; }
    }
}
