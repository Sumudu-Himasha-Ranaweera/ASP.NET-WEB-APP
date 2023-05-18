using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ASP_NET_APP.Model;

namespace ASP_NET_APP.Data
{
    public class ASP_NET_APPContext : DbContext
    {
        public ASP_NET_APPContext (DbContextOptions<ASP_NET_APPContext> options)
            : base(options)
        {
        }

        public DbSet<ASP_NET_APP.Model.User> User { get; set; } = default!;
    }
}
