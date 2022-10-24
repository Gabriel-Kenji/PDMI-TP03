using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using APIPDM.Models;

namespace APIPDM.Data
{
    public class APIPDMdbContext : DbContext
    {
        public APIPDMdbContext (DbContextOptions<APIPDMdbContext> options)
            : base(options)
        {
        }

        public DbSet<APIPDM.Models.Login> Logins { get; set; } = default!;
    }
}
