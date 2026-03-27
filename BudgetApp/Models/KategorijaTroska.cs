namespace BudgetApp.Models;

public class KategorijaTroska
{
    //Podaci od Kategorije Troska
    //Ova tabela sluzi kao kategorija troska za Troskove
    public int Id { get; set; }
    public string Naziv { get; set; } = string.Empty;
    
    
    //FK-ovi
    public ICollection<Troskovi>  Troskovi { get; set; }  = new List<Troskovi>();
}