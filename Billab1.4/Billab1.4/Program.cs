// See https://aka.ms/new-console-template for more information

while (true)
{
    Console.WriteLine("Bir sayı giriniz:");
    var girdi = int.Parse(Console.ReadLine());
    if (girdi == 0) return 0;
    var kare = Math.Pow(girdi, 2);
    var basamaklartoplami = 0;
    while (kare > 0)
    {
        basamaklartoplami += (int) kare % 10;
        kare /= 10;
    }
    if (girdi == basamaklartoplami)
    {
        Console.WriteLine("Eşit");
    }
    else
    {
        Console.WriteLine(Math.Pow(girdi, 2) + " Eşit değil");
    }
}
