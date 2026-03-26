namespace BudgetApp.Models;

public class BudgetPlan
{
    //Podaci od Budget Plana
    public int ID { get; set; }
    public string Naziv { get; set; } = string.Empty;
    public decimal UkupanPrihodPlana { get; set; }
    
    //FK-ovi
    public int KorisnikID { get; set; }
    public Korisnik Korisnik { get; set; }
    
    public ICollection<BudgetPlan_Trosak_Kategorija> StavkeKategorije { get; set; } = new List<BudgetPlan_Trosak_Kategorija>();
    
    
}
