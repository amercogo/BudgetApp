# BudgetApp

Desktop aplikacija za upravljanje ličnim finansijama, razvijena u C# i WPF-u.

---

## O projektu

BudgetApp omogućava korisnicima pregled i kontrolu prihoda i troškova kroz jasno strukturiran interfejs. Aplikacija podržava kreiranje budget planova po kategorijama, analitiku po vremenskim periodima i export finansijskih izvještaja.

---

## Funkcionalnosti

- Upravljanje prihodima — dodavanje, editovanje, brisanje, filtriranje i sortiranje
- Upravljanje troškovima — po kategorijama i prioritetima
- Budget planovi — raspodjela prihoda po kategorijama putem postotnih ograničenja
- Pregled i analitika — grafovi po periodu, top 3 kategorije troškova, top 3 izvora prihoda
- Warning sistem — obavještenje kad su troškovi prekoračili limit, čestitka kad su u granicama
- Export — PDF i Excel izvještaji za prihode, troškove i pregled
- Lokalna autentifikacija — username i password sa hashovanim pohranjivanjem

---

## Tech stack

| Sloj | Tehnologija |
|---|---|
| UI | WPF (.NET 8), MaterialDesignInXAML |
| MVVM | CommunityToolkit.Mvvm |
| Baza podataka | SQLite, Entity Framework Core 8 |
| Validacija | FluentValidation |
| Autentifikacija | BCrypt.Net-Next |
| Grafovi | LiveChartsCore.SkiaSharpView.WPF |
| PDF export | QuestPDF |
| Excel export | ClosedXML |
| Logovanje | Serilog |
| DI | Microsoft.Extensions.DependencyInjection |

---

## Arhitektura

Projekt prati slojevitu arhitekturu sa jasnim razdvajanjem odgovornosti:

```
BudgetApp/
├── Models/          EF Core entiteti
├── ViewModels/      MVVM logika
├── Views/           XAML prozori i kontrole
├── Services/        Business logika
├── Repositories/    Pristup bazi podataka
├── Data/            DbContext i migracije
├── Validators/      FluentValidation pravila
├── Helpers/         Pomoćne klase i konverteri
└── Assets/          Resursi
```

---

## Baza podataka

Aplikacija koristi SQLite bazu sa sljedećim tabelama:

- `Korisnici` — korisnički računi
- `Prihodi` — evidencija prihoda
- `Troskovi` — evidencija troškova
- `BudgetPlan` — korisnički planovi budgeta
- `BudgetPlan_Trosak_Kategorija` — raspodjela plana po kategorijama
- `KategorijaTroska` — kategorije troškova
- `PrioritetTroska` — prioriteti troškova
- `Tagovi` — tagovi za prihode
- `SigurnostPlate` — vrste sigurnosti prihoda

---

## Error handling

Aplikacija koristi višeslojan pristup upravljanju greškama:

- **Validacija inputa** — FluentValidation na svakom modelu prije slanja u bazu
- **Result pattern** — servisi vraćaju `Result<T>` umjesto bacanja izuzetaka
- **DB greške** — hvatanje `DbUpdateException` sa logiranjem putem Serloga
- **Export greške** — poseban handling za zaključane fajlove i nedostatak dozvola
- **Global handler** — `AppDomain.UnhandledException` kao zadnja linija odbrane

---

## Pokretanje projekta

**Preduslovi:**
- .NET 8 SDK
- JetBrains Rider ili Visual Studio 2022

**Koraci:**

```bash
git clone https://github.com/TVOJE_IME/BudgetApp.git
cd BudgetApp
dotnet restore
dotnet ef database update
dotnet run
```

---

## Status projekta

Projekt je u fazi aktivnog razvoja.
