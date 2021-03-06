﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.IO;

namespace IdentityIsolation.API
{
    public class DesignTimeDbContextFactory<T> : IDesignTimeDbContextFactory<T> where T : DbContext
    {
        public T CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json")
            .Build();

            var builder = new DbContextOptionsBuilder<T>();

            var connectionString = configuration.GetConnectionString("DbContext");

            builder.UseSqlServer(connectionString);

            var dbContext = (T)Activator.CreateInstance(typeof(T), builder.Options);

            return dbContext;
        }
    }
}
