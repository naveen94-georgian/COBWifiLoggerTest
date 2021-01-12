using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COBWifiApiTest.Models
{
    public class XirrusDbContext : DbContext
    {
        private readonly IConfiguration _config;

        public XirrusDbContext(IConfiguration Configuration, DbContextOptions options) : base(options)
        {
            _config = Configuration;
            Console.WriteLine(_config["database:connection"]);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            var conn = _config["database:connection"];
            optionsBuilder.UseMySQL(conn);
        }

        public DbSet<Xirrus> Xirruss { get; set; }

    }
}
