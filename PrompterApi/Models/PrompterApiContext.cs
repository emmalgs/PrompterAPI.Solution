using Microsoft.EntityFrameworkCore;

namespace PrompterApi.Models
{
  public class PrompterApiContext : DbContext
  {
    public DbSet<Prompt> Prompts { get; set; }

    public PrompterApiContext(DbContextOptions options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Prompt>()
        .HasData(
          new Prompt { PromptId = 1, PromptText = "What is your favorite color?" }
        );
    }
  }
}