namespace BudgetApp.Models;

public class BudgetPlan_Trosak_Kategorija
{
    //Podaci od Budget Plana (Trosak Kategorija)
    public int ID { get; set; }
    public decimal IznosKM { get; set; }
    public decimal procenatPlana  { get; set; }
    
    //FK-ovi
    public int KategorijaTroskaID { get; set; }
    public KategorijaTroska KategorijaTroska { get; set; }
    
    public int BudgetPlanID { get; set; }
    public BudgetPlan BudgetPlan { get; set; }
    
    
}