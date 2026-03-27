namespace BudgetApp.Models;

public class Troskovi
{
    //Podaci od Troskova
    public int Id { get; set; }
    public string Naziv { get; set; } = string.Empty;
    public string Opis { get; set; } = string.Empty;
    public decimal Ukupno { get; set; }
    public string Napomena { get; set; } = string.Empty;
    public DateTime Datum { get; set; }
    
    //FK-ovi
    public int KorisnikId { get; set; }
    public Korisnik Korisnik { get; set; } = null!;
    
    
    public int KategorijaTroskaId { get; set; }
    public KategorijaTroska KategorijaTroska { get; set; } = null!;
    
    public int PrioritetTroskaId { get; set; }
    public PrioritetTroska PrioritetTroska { get; set; } = null!;



}
