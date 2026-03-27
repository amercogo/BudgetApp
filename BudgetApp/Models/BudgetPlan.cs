namespace BudgetApp.Models;

public class BudgetPlan
{
    //Podaci od Budget Plana
    public int Id { get; set; }
    public string Naziv { get; set; } = string.Empty;
    public decimal UkupanPrihodPlana { get; set; }
    
    //FK-ovi
    public int KorisnikId { get; set; }
    public Korisnik Korisnik { get; set; } = null!;
    
    public ICollection<BudgetPlan_Trosak_Kategorija> StavkeKategorije { get; set; } = new List<BudgetPlan_Trosak_Kategorija>();
    
    
}
