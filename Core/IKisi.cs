namespace Core;
public interface IKisi
{
    public int Id { get; set; }
    public string Ad { get; set; }
    public string Soyad { get; set; }

    public void Merhaba();
}