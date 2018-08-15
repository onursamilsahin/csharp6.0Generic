using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp6._1genericList
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dizi tanımlama

            int[] dizi1 = new int[2];


            dizi1[0] = 1;
            dizi1[1] = 2;
            /*
             * Tip güvenli (avantaj)
             * Müdahale ksımında sıkıntı oluyor(dezavantaj)
             */

            //Arraylist

            ArrayList dizi2 = new ArrayList();

            dizi2.Add(11);
            dizi2.Add(22);

            //Generic list


            List<int> GenericListe = new List<int>();

            //Deger ekle ,tek için add birden fazla ekleem için addRange
            GenericListe.Add(11);
            GenericListe.Add(11);
            GenericListe.Add(11);
            GenericListe.Add(11);
            GenericListe.Add(11);
            GenericListe.AddRange(dizi1);

            Console.WriteLine("Generic listimin adedi:{0}",GenericListe.Count);
           
            //Deger düzenleme

            GenericListe[0] = 111111;


            //silme işlemi


            GenericListe.Remove(111111);



            //Döngü ile ekrana yazma 


            foreach (var item in GenericListe)
            {
                Console.WriteLine("Generic listem :{0}",item);
            }



            //Yardımcı metotlar

            Console.WriteLine("capacity:{0}-count:{1}",GenericListe.Capacity,GenericListe.Count);
            GenericListe.TrimExcess();
            Console.WriteLine("capacity:{0}-count:{1}", GenericListe.Capacity, GenericListe.Count);

            //contains metotu verilen değerin generiz list içerisinde olup olmadığı kontrol eden metottur.True veya false değeri döndürür.






            Console.ReadLine();


        }
    }
}
