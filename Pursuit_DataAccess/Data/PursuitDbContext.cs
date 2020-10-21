using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pursuit_DataAccess.Data
{
    public class PursuitDbContext : DbContext
    {
        public PursuitDbContext(DbContextOptions<PursuitDbContext> options) : base(options)
        {
        }
    }
}
