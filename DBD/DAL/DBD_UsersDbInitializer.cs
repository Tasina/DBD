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
            new User { Id=1, FirstName="Hardy", LastName="Drachmann", Address="Stormgade 18, 3. th" },
            new User { Id=2, FirstName="Tasin", LastName="Akdeniz", Address="Bredgade 22" },
            new User { Id=3, FirstName="Rasmus", LastName="Nielsen", Address="Nørregade 8" },
            new User { Id=4, FirstName="Bjarne", LastName="Nielsen", Address="Østergade 57"},
            new User { Id=5, FirstName="Jens", LastName="Hansen", Address="Gormsgade 22, 1. tv"}
        };

        protected override void Seed(DBD_UsersContext context)
        {
            context.Users.AddRange(users);
            base.Seed(context);
        }

    }
}