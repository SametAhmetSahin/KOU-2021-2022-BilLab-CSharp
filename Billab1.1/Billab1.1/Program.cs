// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.WriteLine("Lütfen üçgenin dik kenarlarından birini giriniz.");

var kenar1 = float.Parse(Console.ReadLine());

Console.WriteLine("Lütfen üçgenin dik kenarlarından diğerini giriniz.");

var kenar2 = float.Parse(Console.ReadLine());

Console.WriteLine("Kenar1: " + kenar1 + " Kenar2: " + kenar2);
Console.WriteLine("Üçgenin alanı: " + kenar1 * kenar2 / 2.0 + " , Üçgenin hipotenüs uzunluğu: " + Math.Sqrt(Math.Pow(kenar1, 2) + Math.Pow(kenar2, 2)) );