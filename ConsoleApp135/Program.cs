double sayi1 = 0, sayi2 = 0;

Console.Write("Birinci sayıyı giriniz:");
sayi1 = Convert.ToDouble(Console.ReadLine());
Console.Write("İkinci sayıyı giriniz:");
sayi2 = Convert.ToDouble(Console.ReadLine());

double fark = sayi1 - sayi2;

if (fark > 0)
    Console.WriteLine("Farkları pozitiftir. Fark={0}", fark);
else if (fark < 0)
    Console.WriteLine("Farkları negatiftir. Fark={0}", fark);
else if (fark == 0)
    Console.WriteLine("Farkları sıfırdır. Fark={0}", fark);

Console.ReadKey();