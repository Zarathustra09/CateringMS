using Microsoft.EntityFrameworkCore;
using MySqlConnector;
using CateringMS.Models;
using System.Collections.Generic;

namespace CateringMS.DataConnection
{
    public class MySqlDbContext:DbContext
    {


        public DbSet<User> Users { get; set; }
        public DbSet<CateringMS.Models.CateringOrder> CateringOrders { get; set; } // Add DbSet for Coach mode

        public MySqlDbContext(DbContextOptions<MySqlDbContext> options) : base(options) { }
    }
}
