Console.Write("Tag: ");
int t = Convert.ToInt32(Console.ReadLine());
Console.Write("Monat: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Jahr: ");
int j = Convert.ToInt32(Console.ReadLine());

// Originalwerte merken, weil m und j gleich verändert werden
int tag = t, monat = m, jahr = j;

if (m <= 2)
{
    m += 10;
    j -= 1;
}
else
{
    m -= 2;
}

int c = j / 100;
j = j % 100;

int h = (((26 * m - 2) / 10) + t + j + j / 4 + c / 4 - 2 * c) % 7;
if (h < 0)
{
    h += 7;
}

string wochentag;
switch (h)
{
    case 0: wochentag = "Sonntag"; break;
    case 1: wochentag = "Montag"; break;
    case 2: wochentag = "Dienstag"; break;
    case 3: wochentag = "Mittwoch"; break;
    case 4: wochentag = "Donnerstag"; break;
    case 5: wochentag = "Freitag"; break;
    default: wochentag = "Samstag"; break;
}

Console.WriteLine("Der " + tag + "." + monat + "." + jahr + " ist ein " + wochentag);