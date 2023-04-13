using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace NewAbpProject.EntityFrameworkCore
{
    public static class NewAbpProjectDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<NewAbpProjectDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<NewAbpProjectDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
