﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Who.Auth.Context;

namespace Who.Auth.Sqlite
{
    public static class SqliteServiceBuilder
    {
        public static void AddCoreDbContext(DbContextOptionsBuilder dbContextOptionsBuilder, string connectionString)
        {
            dbContextOptionsBuilder.UseSqlite(connectionString,
                sql => sql.MigrationsAssembly(typeof(SqliteServiceBuilder).Assembly.FullName));
  
        }

        public static void AddCoreDbContext(IServiceCollection serviceCollection, string connectionString)
        {
            serviceCollection.AddDbContext<AuthDbContext>(opt => opt.UseSqlite(connectionString, sql => sql.MigrationsAssembly(typeof(SqliteServiceBuilder).Assembly.FullName)));
        }
        
    }
}
