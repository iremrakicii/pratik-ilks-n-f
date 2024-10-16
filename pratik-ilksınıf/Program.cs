using pratik_ilksınıf;

class Program
{
    static void Main()
    {
        Person ogrenci = new Person();

        Console.WriteLine("Öğrencimizin kişisel bilgileri:");
        ogrenci.Name = "İrem";
        ogrenci.Surname = "Rakıcı";
        ogrenci.BirthDate = new DateTime(2000, 09, 12);

        ogrenci.IsimYazdir();
        ogrenci.SoyadYazdir();
        ogrenci.DogumTarihi();

        Console.WriteLine("--------------------------");

        Person ogrenci2 = new Person();

        Console.WriteLine("Öğrencimizin kişisel bilgileri:");
        ogrenci2.Name = "Yasin Enes";
        ogrenci2.Surname = "Şişik";
        ogrenci2.BirthDate = new DateTime(2000, 03, 12);

        ogrenci2.IsimYazdir();
        ogrenci2.SoyadYazdir();
        ogrenci2.DogumTarihi();

        Console.WriteLine("--------------------------");

        Person ogretmen = new Person();

        Console.WriteLine("Öğretmenimizin kişisel bilgileri:");

        ogretmen.Name = "Ahmet";
        ogretmen.Surname = "Rakıcı";
        ogretmen.BirthDate = new DateTime(1966, 09, 26);

        ogretmen.IsimYazdir();
        ogretmen.SoyadYazdir();
        ogretmen.DogumTarihi();

    }
}