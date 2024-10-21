using Microsoft.EntityFrameworkCore;
using MyWebApi.Models;

namespace MyWebApi;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {

    }
    public DbSet<Villa> Villas { get; set; }
}
