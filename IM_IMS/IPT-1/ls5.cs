using System.Globalization;

// ===== EINGABE =====
Console.Write("Artikelname: ");
string artikel = Console.ReadLine()!;

Console.Write("Einzelpreis (CHF): ");
decimal einzelpreis = decimal.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

Console.Write("Menge: ");
int menge = int.Parse(Console.ReadLine()!);

// ===== VERARBEITUNG =====
decimal gesamtpreis = einzelpreis * menge;

// ===== AUSGABE =====
Console.WriteLine();
Console.WriteLine("Zusammenfassung");
Console.WriteLine($"Artikel:      {artikel}");
Console.WriteLine($"Einzelpreis:  CHF {einzelpreis.ToString("F2", CultureInfo.InvariantCulture)}");
Console.WriteLine($"Menge:        {menge}");
Console.WriteLine($"Gesamtpreis:  CHF {gesamtpreis.ToString("F2", CultureInfo.InvariantCulture)}");