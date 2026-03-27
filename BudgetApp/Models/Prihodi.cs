
namespace BudgetApp.Models;

public class Prihodi
{
    //Podaci od Prihoda
    public int Id { get; set; }
    public string Naziv { get; set; } = string.Empty;
    public string Opis { get; set; } = string.Empty;
    public decimal Ukupno { get; set; }
    public string Napomena { get; set; } = string.Empty;
    public DateTime Datum { get; set; }
    
    //FK-ovi
    public int KorisnikId { get; set; }
    public Korisnik Korisnik { get; set; } = null!;
    
    public int TagoviId { get; set; }
    public Tagovi Tag { get; set; } = null!;
    
    public int SigurnostPlateId { get; set; }
    public SigurnostPlate Sigurnost { get; set; } = null!;
}