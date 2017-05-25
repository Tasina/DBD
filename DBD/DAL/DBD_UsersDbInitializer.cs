using System;
using System.Collections.Generic;
using System.Data.Entity;
using DBD.DAL.Models;


namespace DBD.DAL
{
    public class DBD_UsersDbInitializer : DropCreateDatabaseAlways<DBD_UsersContext>
    {
        private List<User> users = new List<User>
        {
            new User { Username="Hardy"},
            new User { Username="Tasin"},
            new User { Username="Rasmus"}
        };

        protected override void Seed(DBD_UsersContext context)
        {
            context.Users.AddRange(users);
            base.Seed(context);
        }
    }
}