using Microsoft.EntityFrameworkCore;
using Program.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Program.DbContext
{
    public class MoneyBotContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public MoneyBotContext (DbContextOptions<MoneyBotContext> options)
            :base (options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Money> Moneys { get; set; }
    }
}
