public class Program
{
    struct VizeFinal
    {
        public double vize;
        public double final;
        public int ogrenciNo;
        public string ogrenciAdi;
        public string ogrenciSoyadi;
        public double OrtalamaPuan()
        {
            return (vize * 0.40 + final * 0.60);
        }
        public void EkranaYaz()
        {
            Console.WriteLine($"Okul No : {ogrenciNo}");
            Console.WriteLine($"Öğrenci Adı : {ogrenciAdi}");
            Console.WriteLine($"Öğrenci Soyadı : {ogrenciSoyadi}");
            Console.WriteLine($"Vize Notu : {vize}");
            Console.WriteLine($"Final Notu : {final}");
            Console.WriteLine($"Yıl Sonu Puanı : {OrtalamaPuan()}");
            Console.WriteLine($"Harf Notu : {HarfNotu()}");
        }
        public string HarfNotu()
        {
            if (45 > OrtalamaPuan())
            {
                return "FF";
            }
            else if (45 <= OrtalamaPuan() && OrtalamaPuan() < 55)
            {
                return "DC";
            }
            else if (55 <= OrtalamaPuan() && OrtalamaPuan() < 65)
            {
                return "CC";
            }
            else if (65 <= OrtalamaPuan() && OrtalamaPuan() < 75)
            {
                return "CB";
            }
            else if (75 <= OrtalamaPuan() && OrtalamaPuan() < 85)
            {
                return "BB";
            }
            else if (85 <= OrtalamaPuan() && OrtalamaPuan() < 90)
            {
                return "BA";
            }
            else if (90 <= OrtalamaPuan() && OrtalamaPuan() <= 100)
            {
                return "AA";
            }
            else
            {
                return "Bir Problem Var.";
            }
        }
    }
    static List<VizeFinal> sinifListesi = new List<VizeFinal>();
    public static void Main()
    {
        Menu();
    }
    static void Menu()
    {
        Console.Clear();
        Console.WriteLine("1. Öğrenci Yıl Sonu Notu Hesaplama\n2. Sınıf Listesi\n3. Çıkış");
        MenuSelection();
    }
    static void MenuSelection()
    {
        Console.Write("Yapılacak işlemi seçin : ");
        string choose = Console.ReadLine();
        switch (choose)
        {
            case "1":
                NewStudent();
                break;
            case "2":
                ListOfClass();
                break;
            case "3":
                Environment.Exit(0);
                break;
            default:
                Console.WriteLine("Hatalı seçim. Tekrar Deneyin.");
                MenuSelection();//Recursive
                break;

        }
    }
    static void NewStudent()
    {
        VizeFinal r = new VizeFinal();
        Console.Write("Öğrenci No :");
        r.ogrenciNo = Convert.ToInt32(Console.ReadLine());
        //Eğer Menüde double olması gereken bir ifade için kullanıcı string bir ifade girerse tekrar giriş yapınız nasıl yazdırırız? ??
        Console.Write("Öğrenci Adı :");
        r.ogrenciAdi = Console.ReadLine();
        Console.Write("Öğrenci Soyadı :");
        r.ogrenciSoyadi = Console.ReadLine();
        Console.Write("Vize Notu :");
        r.vize = Convert.ToDouble(Console.ReadLine());
        Console.Write("Final Notu :");
        r.final = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"Yıl Sonu Notu : {r.OrtalamaPuan()}");
        Console.WriteLine($"Harf Notu: {r.HarfNotu()}");

        sinifListesi.Add(r);

        Again();
    }
    static void ListOfClass()
    {
        for (int i = 0; i < sinifListesi.Count; i++)
        {
            sinifListesi[i].EkranaYaz();
            Console.WriteLine("----------------------------------------------------");

        }
    }
    static void Again()
    {
        Console.WriteLine("Menüye dönmek için ENTER");
        Console.ReadLine();

        Menu();
    }
}