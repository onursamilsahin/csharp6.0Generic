using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp6._0Generic
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //Kodu yazarken farklı veri tiplerine aynı isimle ulaşmak istiyorsam Generic yapsını kullanabilirim.
        //    Ogrenci<int,string,Guid> O1=new Ogrenci<int, string, Guid>();


        //    O1.DatabaseId=new Guid();

        //    O1.Isim = "john";
        //    O1.Soyisim = "doe";
        //    O1.OgrenciId = 1;
        //    O1.OgrenciNumarasi = 111;

        //    Ogrenci<Decimal,string,Guid> O2=new Ogrenci<decimal, string, Guid>();

        //    O2.DatabaseId=new Guid();
        //Generic Örnekler
        Musteri<int,string> M1=new Musteri<int, string>();


            M1.MusteriId = 1;

            M1.Isim = "john";
            M1.Soyisim = "doe";
            M1.Email="asdsda@asdasd.com";
             M1.DatabaseKaydet(M1.MusteriId,M1.Isim,M1.Soyisim);

            Console.ReadLine();



        }


    }

    class Ogrenci<T,Y,Z>
    {

        public  T OgrenciNumarasi { get; set; }

        public T OgrenciId { get; set; }

        public Y Isim { get; set; }

        public Y Soyisim { get; set; }

        public Z DatabaseId { get; set; }    

    }


    class Musteri<T, H> 
    {


        public T MusteriId { get; set; }

        public H Isim { get; set; }

        public H Soyisim { get; set; }

        public H Email { get; set; }

        public void DatabaseKaydet(T MusteriId,H Isimi, H Soyisim)
        {
            Console.WriteLine("{0}-{1} degeri database e kayıt edildi",Isim,Soyisim);



        }

    }
}
