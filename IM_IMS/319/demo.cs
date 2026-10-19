Console.Write("Zahl 1:");
int zahl1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Zahl 2:");
int zahl2 = Convert.ToInt32(Console.ReadLine());
if (zahl2 < zahl1 && zahl1 > 5)
{
    int temp = zahl1;
    zahl1 = zahl2;
    zahl2 = temp;
}
else
{
    if (zahl1 == zahl2)
        zahl1 = 5;
    zahl2 = 8;
}
Console.WriteLine("Ausgabe 1 = " + Convert.ToString(zahl1));
Console.WriteLine("Ausgabe 2 = " + Convert.ToString(zahl2));