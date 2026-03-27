namespace BudgetApp.Models;

public class Tagovi
{
    //Podaci od Tagova
    //Ova tabela sluzi kao lista tagova za Prihode
    public int Id { get; set; }
    public string Naziv { get; set; } = string.Empty;
    
    //FK-ovi
    public ICollection<Prihodi>  Prihodi { get; set; } = new List<Prihodi>();
    
}