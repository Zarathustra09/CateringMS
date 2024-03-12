using Microsoft.EntityFrameworkCore;
using MySqlConnector;
using CateringMS.Models;

namespace CateringMS.DataConnection
{
    public class MySqlDbContext:DbContext
    {
 
      

        public MySqlDbContext(DbContextOptions<MySqlDbContext> options) : base(options) { }
    }
}
