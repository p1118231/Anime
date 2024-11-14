using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AnimeMvc.Models;

namespace AnimeMvc.Data
{
    public class AnimeContext : DbContext
    {
        public AnimeContext (DbContextOptions<AnimeContext> options)
            : base(options)
        {
        }

        public DbSet<AnimeMvc.Models.Anime> Anime { get; set; } = default!;
    }
}
