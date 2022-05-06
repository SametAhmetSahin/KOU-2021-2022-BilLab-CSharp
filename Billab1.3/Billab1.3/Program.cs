// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
var bakiye = 1000;

while (true) {
    

    Console.WriteLine("Bakiyeniz: " + bakiye + "\n\n----İŞLEMLER----\n\n1. Para Çekme\n2.Para Yatırma\n3. Para Bakiye Sorgulama\n4. Kart İade\n\nİşleminizi Seçiniz: ");

    var girdi = int.Parse(Console.ReadLine());
    var tutar = 0;
    Console.WriteLine("Bakiyeniz: " + bakiye);

    switch (girdi)
{
    case 1:
            Console.WriteLine("Çekmek istediğiniz tutarı giriniz: ");
            tutar = int.Parse((Console.ReadLine()));
            if (tutar > 0 && bakiye - tutar > 0)
            {
                bakiye -= tutar;
                bakiye -= 5;
                Console.WriteLine("Hesabınızdan " + tutar + " TL çekilmiştir. 5 TL işlem ücreti kesintisiyle beraber yeni bakiyeniz " + bakiye + " TL'dir.");
            }
            else
            {
                Console.WriteLine("Girdiğiniz tutar geçersiz veya bakiyenizden fazladır.");
            }
        break;
    case 2:
            Console.WriteLine("Yatırmak istediğiniz tutarı giriniz: ");
            tutar = int.Parse((Console.ReadLine()));
            if (tutar >= 0)
            {
                bakiye += tutar;
                bakiye -= 5;
                Console.WriteLine("Hesabınıza " + tutar + " TL yatırılmıştır. 5 TL işlem ücreti kesintisiyle beraber yeni bakiyeniz " + bakiye + " TL'dir.");
            }
            else
            {
                Console.WriteLine("Girdiğiniz tutar geçersizdir.");
            }
            break;
    case 3:
            Console.WriteLine("Bakiyeniz " + bakiye + " TL'dir.");
            break;
    case 4:
            Console.WriteLine("Kartınızı almayı unutmayın!");
            return 0;
        break;
    default:
            Console.WriteLine("Geçersiz işlem girilmiştir!");
            break;
}

}
