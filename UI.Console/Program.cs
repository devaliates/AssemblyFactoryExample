using Core;

using UI.Console;

IKisi kisi = Factory.CreateKisi();
kisi.Ad = "Abuzer";
kisi.Soyad = "Kadayıf";
kisi.Id = 1;

kisi.Merhaba();

Console.Read();