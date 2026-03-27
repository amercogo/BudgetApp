namespace BudgetApp.Models;

public class BudgetPlan_Trosak_Kategorija
{
    //Podaci od Budget Plana (Trosak Kategorija)
    public int Id { get; set; }
    public decimal IznosKm { get; set; }
    public decimal ProcenatPlana  { get; set; }
    
    //FK-ovi
    public int KategorijaTroskaId { get; set; }
    public KategorijaTroska KategorijaTroska { get; set; } = null!;
    
    public int BudgetPlanId { get; set; }
    public BudgetPlan BudgetPlan { get; set; } = null!;


}