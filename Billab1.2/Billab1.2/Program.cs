// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.WriteLine("İlk sayıyı giriniz:");
var sayi1 = Int32.Parse(Console.ReadLine());

Console.WriteLine("İkinci sayıyı giriniz:");
var sayi2 = Int32.Parse(Console.ReadLine());

Console.WriteLine("Üçüncü sayıyı giriniz:");
var sayi3 = Int32.Parse(Console.ReadLine());

var kucuk = 0;
var ortanca = 0;

if (sayi1 < sayi2)
{
    if (sayi2 < sayi3)
    {
        kucuk = sayi1;
        ortanca = sayi2;
    }
    else if (sayi1 < sayi3)
    {
        kucuk = sayi1;
        ortanca = sayi3;
    }
    else if (sayi3 < sayi1)
    {
        kucuk = sayi3;
        ortanca = sayi1;
    }
}
else if (sayi2 < sayi1)
{
    if (sayi2 < sayi3)
    {
        kucuk = sayi2;
        if (sayi3 < sayi1)
        {
            ortanca = sayi3;
        }
        else ortanca = sayi1;
    }
    else
    {
        if (sayi3 < sayi1)
        {
            kucuk = sayi3;
            ortanca = sayi2;
        }

    }
}

/*
if (sayi1 > sayi2 && sayi2 > sayi3)
{
    Console.WriteLine("Ortanca sayi: " + sayi2);
    Console.WriteLine("\nKucuk sayinin 2 kati: " + sayi3 * 2);
}

else if (sayi1 > sayi3 && sayi3 > sayi2)
{
    Console.WriteLine("Ortanca sayi: " + sayi3);
    Console.WriteLine("\nKucuk sayinin 2 kati: " + sayi2 * 2);
}

else if (sayi2 > sayi3 && sayi3 > sayi1)
{
    Console.WriteLine("Ortanca sayi: " + sayi3);
    Console.WriteLine("\nKucuk sayinin 2 kati: " + sayi1 * 2);
}

else if (sayi2 > sayi1 && sayi1 > sayi3)
{
    Console.WriteLine("Ortanca sayi: " + sayi1);
    Console.WriteLine("\nKucuk sayinin 2 kati: " + sayi3 * 2);
}

else if (sayi3 > sayi1 && sayi1 > sayi2)
{
    Console.WriteLine("Ortanca sayi: " + sayi1);
    Console.WriteLine("\nKucuk sayinin 2 kati: " + sayi2 * 2);
}

else if (sayi3 > sayi2 && sayi2 > sayi1)
{
    Console.WriteLine("Ortanca sayi: " + sayi2);
    Console.WriteLine("\nKucuk sayinin 2 kati: " + sayi1 * 2);
}
*/

Console.WriteLine("Ortanca sayı: " + ortanca + " \nKüçük Sayının 2 Katı: " + kucuk * 2);
