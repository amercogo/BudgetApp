namespace BudgetApp.Models;

public class Troskovi
{
    //Podaci od Troskova
    public int ID { get; set; }
    public string Naziv { get; set; } = string.Empty;
    public string Opis { get; set; } = string.Empty;
    public decimal Ukupno { get; set; }
    public string Napomena { get; set; } = string.Empty;
    public DateTime Datum { get; set; }
    
    //FK-ovi
    public int KorisnikID { get; set; }
    public Korisnik Korisnik { get; set; }
    
    
    public int KategorijaTroskaID { get; set; }
    public KategorijaTroska KategorijaTroska { get; set; }
    
    public int PrioritetTroskaID { get; set; }
    public PrioritetTroska PrioritetTroska { get; set; }


    
}
