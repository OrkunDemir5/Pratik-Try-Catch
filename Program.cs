bool basarili = false;
int sayi = 0;

//her hata girdiğinde tekrara dönmesi için
while (!basarili) 
{
    try
    {
        Console.WriteLine("Bir sayı giriniz");
        sayi = Convert.ToInt32(Console.ReadLine());
        basarili = true;

    }// hatalı karakter girerse
    catch (Exception ex)
    {
        Console.WriteLine("Lütfen sayı giriniz");
    }
    finally
    {
        // ne olursa olsun çalışacak kod
    }
}
Console.WriteLine($"Başarılı girdiğiniz sayı : {sayi}");


