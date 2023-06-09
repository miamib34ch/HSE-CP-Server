﻿using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata;

namespace HSE_CP_Server.Models
{
    public class Context: DbContext
    {
        public SqliteConnection DbPath { get; }

        public DbSet<Users> Users { get; set; }
        public DbSet<Role> Role { get; set; }
        public DbSet<Clients> Clients { get; set; }
        public DbSet<Sale> Sale { get; set; }
        public DbSet<Visit> Visit { get; set; }
        public DbSet<ProceduresInVisit> ProceduresInVisit { get; set; }
        public DbSet<ProcedureClient> ProcedureClient { get; set; }
        public DbSet<Procedure> Procedure { get; set; }
        public DbSet<UserDevices> UserDevices { get; set; }
        public DbSet<ProcedureCategorie> ProcedureCategorie { get; set; }
        //public DbSet<Skin> Skin { get; set; }
        //public DbSet<Method> Method { get; set; }
        //public DbSet<Needle> Needle { get; set; }
        //public DbSet<Pigments> Pigments { get; set; }
        //public DbSet<PigmentsInProcedures> PigmentsInProcedures { get; set; }

        public Context()
        {
            var connectionString = new SqliteConnectionStringBuilder
            {
                DataSource = $"{Environment.CurrentDirectory}\\BeautyStudio.db", // путь к базе данных
                Password = "test" // пароль от базы данных
            };
            DbPath = new SqliteConnection(connectionString.ToString());
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlite(DbPath);
        }
    }
}
