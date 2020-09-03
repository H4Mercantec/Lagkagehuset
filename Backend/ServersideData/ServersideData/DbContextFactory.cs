using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServersideData
{
    class DbContextFactory : IDesignTimeDbContextFactory<SQLDbContext>
    {
        public SQLDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<SQLDbContext>();
            builder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=LagkagehusetDatabase;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            return new SQLDbContext(builder.Options);
        }
    }
}
