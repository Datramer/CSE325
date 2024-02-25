using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MyScriptures3.Models;

namespace MyScriptures3.Data
{
    public class MyScriptures3Context : DbContext
    {
        public MyScriptures3Context (DbContextOptions<MyScriptures3Context> options)
            : base(options)
        {
        }

        public DbSet<MyScriptures3.Models.Scripture> Scripture { get; set; } = default!;
    }
}
