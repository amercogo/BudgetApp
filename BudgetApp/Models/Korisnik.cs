namespace BudgetApp.Models;

public class Korisnik
{
    //Podaci od Korisnika
    public int Id { get; set; }
    public string Username { get; set; } = string.Empty;
    public string PasswordHash { get; set; } = string.Empty;
    public DateTime Napravljeno { get; set; } = DateTime.Now;
    
    //Navigacijska svojstva
    public ICollection<Prihodi> Prihodi {get; set;} = new List<Prihodi>();
    public ICollection<Troskovi> Troskovi { get; set; } = new List<Troskovi>();
    public ICollection<BudgetPlan> BudgetPlan { get; set; } = new List<BudgetPlan>();
    
    
    
}