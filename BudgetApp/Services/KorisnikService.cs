using BudgetApp.Data;
using BudgetApp.Models;
using Microsoft.EntityFrameworkCore;

namespace BudgetApp.Services;

public class KorisnikService
{
    private readonly AppDbContext _dbContext;
    
    public KorisnikService(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    
    
    public async Task<bool> Login(string username, string password)
    {
        // Traži korisnika u bazi po usernameu
        var korisnik = await _dbContext.Korisnici
            .FirstOrDefaultAsync(k => k.Username == username);

        // Ako korisnik ne postoji
        if (korisnik == null) return false;

        // BCrypt provjerava password sa hashom iz baze
        return BCrypt.Net.BCrypt.Verify(password, korisnik.PasswordHash);
    }
    
    public async Task<bool> Register(string username, string password)
    {
        // Provjeri da li username već postoji
        var postoji = await _dbContext.Korisnici
            .AnyAsync(k => k.Username == username);

        if (postoji) return false;

        // Hashuj password i spremi korisnika
        var noviKorisnik = new Korisnik
        {
            Username = username,
            PasswordHash = BCrypt.Net.BCrypt.HashPassword(password),
            Napravljeno = DateTime.Now
        };

        _dbContext.Korisnici.Add(noviKorisnik);
        await _dbContext.SaveChangesAsync();
        return true;
    }
}