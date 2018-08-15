using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericListOrnek
{
    class Program
    {
        static void Main(string[] args)
        {

            //Menu
            //Yeni personel ekle

            //Personel ara
            //personel liste
            bool dongu = true;

            List<Personel> Personellerim = new List<Personel>();

            while (dongu)
            {

                Console.WriteLine("1-yeni personel ekle");
                Console.WriteLine("2-Personel Ara");
                Console.WriteLine("3-Personel liste");
                Console.WriteLine("çımak için 1-2-3 dışında bir tuşa basın");
                string Secim = Console.ReadLine();
                switch (Secim)
                {
                    case "1":
                        Personel P = YeniPersonelEkle();

                        if (Personellerim.Contains(P))
                        {
                            Personellerim.Add(P);
                        }
                        else
                        {
                            Console.WriteLine("Personel kayıtlı.");
                        }


                        break;
                    case "2":

                        personelAra(Personellerim);
                        break;
                    case "3":
                        for (int i = 0; i < Personellerim.Count; i++)
                        {
                            Console.WriteLine(Personellerim[i]);

                        }
                     Console.Clear();
                        break;
                    default:
                        dongu = false;

                        break;
                }
            }

          

        }

        private static void personelAra(List<Personel> Personellerim)
        {
            Console.WriteLine("Sicil Numarasını giriniz.");
            string SicilNumarasıAranacak = Console.ReadLine();


           for (int i = 0; i < Personellerim.Count; i++)
            {
                if (Personellerim[i].SicilNumarasi==SicilNumarasıAranacak)
                {
                    Console.WriteLine(Personellerim[i]);
                }
            }
        }

        private static Personel YeniPersonelEkle()
        {
            Personel temp =new Personel();
            Console.WriteLine("Personel sicil nuamrası:");
            temp.SicilNumarasi = Console.ReadLine();
            Console.WriteLine("Personel ad ve soyad:");
            temp.IsimSoyisim = Console.ReadLine();
            Console.WriteLine("Persoenl Email:");
            temp.EmailAdres = Console.ReadLine();
            return temp;
        }
    }

    public class Personel
    {

        public string SicilNumarasi { get; set; }
        public string IsimSoyisim { get; set; }

        public string EmailAdres { get; set; }


        public override string ToString()
        {


            return string.Format("{0}-{1}-{2}",SicilNumarasi,IsimSoyisim,EmailAdres);
        }
    }
}
