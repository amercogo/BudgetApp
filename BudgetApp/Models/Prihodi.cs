using DocumentFormat.OpenXml.Bibliography;

namespace BudgetApp.Models;

public class Prihodi
{
    //Podaci od Prihoda
    public int ID { get; set; }
    public string Naziv { get; set; } = string.Empty;
    public string Opis { get; set; } = string.Empty;
    public decimal Ukupno { get; set; }
    public string Napomena { get; set; } = string.Empty;
    public DateTime Datum { get; set; }
    
    //FK-ovi
    public int KorisnikID { get; set; }
    public Korisnik Korisnik { get; set; }
    
    public int TagoviID { get; set; }
    public Tag Tag { get; set; }
    
    public int SigurnostPlateID { get; set; }
    public SigurnostPlate Sigurnost { get; set; }
}