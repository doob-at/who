﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Who.Auth.Context;

namespace Who.Auth.SqlServer
{
    public static class SqlServerServiceBuilder
    {
        public static void AddCoreDbContext(DbContextOptionsBuilder dbContextOptionsBuilder, string connectionString)
        {
            dbContextOptionsBuilder.UseSqlServer(connectionString,
                sql => sql.MigrationsAssembly(typeof(SqlServerServiceBuilder).Assembly.FullName));
        }

        public static void AddCoreDbContext(IServiceCollection serviceCollection, string connectionString)
        {
            serviceCollection.AddDbContext<AuthDbContext>(opt => opt.UseSqlServer(connectionString, sql => sql.MigrationsAssembly(typeof(SqlServerServiceBuilder).Assembly.FullName)));
        }
    }
}
