using System;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int>sayilar=new List<int>();
            sayilar.Add(23);
            sayilar.Add(10);
            sayilar.Add(4);
            sayilar.Add(5);
            sayilar.Add(92);
            sayilar.Add(34);

            List<string>renkler=new List<string>();
            renkler.Add("kırmızı");
            renkler.Add("mavi");
            renkler.Add("turuncu");
            renkler.Add("sarı");
            renkler.Add("yeşil");

            //Count
            Console.WriteLine(renkler.Count);
            Console.WriteLine(sayilar.Count);

            //Foreach ve List.ForEach ile elamanları erişim
            foreach (var sayi in sayilar)
            {
                Console.WriteLine(sayi);
            }
            foreach (var renk in renkler)
            {
                Console.WriteLine(renk);
            }
            sayilar.ForEach(sayi=>Console.WriteLine(sayi));
            renkler.ForEach(renk=>Console.WriteLine(renk));

            //Listeden eleman çıkarma
            sayilar.Remove(4);
            renkler.Remove("yeşil");

            sayilar.ForEach(sayi=>Console.WriteLine(sayi));
            renkler.ForEach(renk=>Console.WriteLine(renk));

            //Liste içerisinde arama
            if(sayilar.Contains(10))
            {
                Console.WriteLine("10 liste içerisinde bulundu!");
            }
            else{
                Console.WriteLine("10 liste içerisinde bulunamadı!");
            }

            //Elaman ile index'e erişme
            Console.WriteLine(renkler.BinarySearch("sarı"));

            //Diziyi List'e çevirme
            string[] hayvanlar={"kedi","köpek","kuş"};
            List<string>hayvanlarList=new List<string>(hayvanlar);

            //Lİsteyi nasıl temizlerim 
            hayvanlarList.Clear();

            //liste çevresinde nesne tutmak
            List<Kullanicilar>kullaniciListesi=new List<Kullanicilar>();
            Kullanicilar kullanici1=new Kullanicilar();
            kullanici1.Isim="Ayşe";
            kullanici1.Soyisim="Yılmaz";
            kullanici1.Yas="26";

            Kullanicilar kullanici2=new Kullanicilar();
            kullanici2.Isim="Ali";
            kullanici2.Soyisim="Yılmaz";
            kullanici2.Yas="26";
            kullaniciListesi.Add(kullanici1);
            kullaniciListesi.Add(kullanici2);

            List<Kullanicilar>  yeniKull=new List<Kullanicilar>();
            yeniKull.Add(new Kullanicilar(){
                Isim="Deniz",
                Soyisim="Arda",
                Yas="23"
            });

            foreach (var Kullanici  in kullaniciListesi)
            {
                Console.WriteLine("Kullanıcı Adı: "+Kullanici.Isim);
                Console.WriteLine("Kullanıcı Soyadı: "+Kullanici.Soyisim);
                Console.WriteLine("Kullanıcı Yaşı: "+Kullanici.Yas);
            }
            
        }
    }
    public class Kullanicilar{
        private string isim;
        private string soyisim;
        private string yas;

        public string Isim{get=>isim;set=> isim = value;}
        public string Soyisim{get=>soyisim;set=> soyisim = value;}
        public string Yas{get=>yas;set=> yas = value;}
    }
}