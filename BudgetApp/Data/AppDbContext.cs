using BudgetApp.Models;
using Microsoft.EntityFrameworkCore;

namespace BudgetApp.Data;

public class AppDbContext : DbContext
{
    //Svaki DB set = jedna tabela modela u Bazi
    public DbSet<Korisnik> Korisnici { get; set; }
    public DbSet<BudgetPlan> BudgetPlan { get; set; }
    public DbSet<BudgetPlan_Trosak_Kategorija> BudgetPlanTrosakKategorija { get; set; }
    public DbSet<KategorijaTroska> KategorijaTroska { get; set; }
    public DbSet<Prihodi> Prihodi { get; set; }
    public DbSet<PrioritetTroska> PrioritetTroska { get; set; }
    public DbSet<SigurnostPlate> SigurnostPlate { get; set; }
    public DbSet<Tagovi> Tagovi { get; set; }
    public DbSet<Troskovi> Troskovi { get; set; }
    
    //Incijaliziranje Baze
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=budgetApp.db");
    }
    
}