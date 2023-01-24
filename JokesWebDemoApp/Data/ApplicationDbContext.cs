using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using JokesWebDemoApp.Models;

namespace JokesWebDemoApp.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<JokesWebDemoApp.Models.Joke> Joke { get; set; } = default!;
    }
}