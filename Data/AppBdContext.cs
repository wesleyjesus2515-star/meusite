
using Microsoft.EntityFrameworkCore;
using minhaloja.Models;



namespace minhaloja.Data;

public class AppBdContext : DbContext
{
public AppBdContext(DbContextOptions<AppBdContext>options): base (options){}
public DbSet<Utilitarios>Produtos{get;set;}
    }
    