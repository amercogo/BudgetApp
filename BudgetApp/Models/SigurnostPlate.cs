namespace BudgetApp.Models;

public class SigurnostPlate
{
    //Podaci od Sigurnost Plate
    //Ova tabela sluzi kao vrsta Sigurnosti za Prihode
    public int Id { get; set; }
    public string Naziv { get; set; } = string.Empty;
    
    //FK-ovi
    public ICollection<Prihodi>  Prihodi { get; set; } = new List<Prihodi>();
}