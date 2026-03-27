namespace BudgetApp.Models;

public class PrioritetTroska
{
    //Podaci od Prioriteta Troska
    //Ova tabela sluzi kao prioritet troska za Troskove
    public int Id { get; set; }
    public string Naziv { get; set; } = string.Empty;
    
    
    //FK-ovi
    public ICollection<Troskovi>  Troskovi { get; set; } = new List<Troskovi>();
}