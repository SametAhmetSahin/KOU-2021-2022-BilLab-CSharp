// See https://aka.ms/new-console-template for more information


// Botched this up. Might reattempt later.

Console.WriteLine("Matrisin satir sayisini giriniz:");
var satir = int.Parse(Console.ReadLine());

Console.WriteLine("Matrisin sütun sayisini giriniz:");
var sutun = int.Parse(Console.ReadLine());
int sira = 0;

for (int i=0;i<satir;i++)
{
    for (int j=0;j<sutun;j++)
    {
        sira++;
        Console.Write(sira + " ");
        
    }
    Console.Write("\n");
}