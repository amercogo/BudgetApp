using BudgetApp.Models;
using Microsoft.EntityFrameworkCore;

namespace BudgetApp.Data;

public class AppDbContext : DbContext
{
    //Svaki DB set = jedna tabela modela u Bazi
    public DbSet<Korisnik> Korisnici { get; set; } = null!;
    public DbSet<BudgetPlan> BudgetPlan { get; set; } = null!;
    public DbSet<BudgetPlan_Trosak_Kategorija> BudgetPlanTrosakKategorija { get; set; } = null!;
    public DbSet<KategorijaTroska> KategorijaTroska { get; set; } = null!;
    public DbSet<Prihodi> Prihodi { get; set; } = null!;
    public DbSet<PrioritetTroska> PrioritetTroska { get; set; } = null!;
    public DbSet<SigurnostPlate> SigurnostPlate { get; set; } = null!;
    public DbSet<Tagovi> Tagovi { get; set; } = null!;
    public DbSet<Troskovi> Troskovi { get; set; } = null!;
    
    //Incijaliziranje Baze
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=budgetApp.db");
    }
    
}