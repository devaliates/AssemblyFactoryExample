using Core;

namespace Turkiye;
public class Kisi : IKisi
{
    public int Id { get; set; }
    public string Ad { get; set; }
    public string Soyad { get; set; }

    public void Merhaba()
    {
        Console.WriteLine($"Merhaba ben Türkiye' den {Ad} {Soyad}");
    }
}