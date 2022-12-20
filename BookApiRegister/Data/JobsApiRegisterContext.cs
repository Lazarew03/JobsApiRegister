using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using JobsApiRegister;

namespace JobsApiRegister.Data
{
    public class JobsApiRegisterContext : DbContext
    {
        public JobsApiRegisterContext (DbContextOptions<JobsApiRegisterContext> options)
            : base(options)
        {
        }

        public DbSet<JobsApiRegister.Jobs> Jobs { get; set; } = default!;
    }
}
