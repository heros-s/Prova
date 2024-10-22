using Microsoft.EntityFrameworkCore;
using HerosDinao.Models;

namespace HerosDinao.Data;

public class AppDbContext : DbContext
{
  public DbSet<Funcionario> Funcionarios { get; set; }
  public DbSet<FolhaPagamento> FolhasPagamento { get; set; }

  public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

  protected override void OnModelCreating(ModelBuilder modelBuilder)
  {
      base.OnModelCreating(modelBuilder);
  }
}