using Microsoft.EntityFrameworkCore;
using Template.Models;

namespace Template.Databases;

public class TemplateContext : DbContext
{
    public TemplateContext(DbContextOptions<TemplateContext> options) : base(options)
    {

    }

    public DbSet<MyTemplate> myTemplates { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<MyTemplate>().ToTable("my_template");
    }
}
