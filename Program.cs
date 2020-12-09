using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S1.D4.TürDönüşümleri
{
    class Program
    {
        static void Main(string[] args)
        {
            byte sayi1 = byte.MaxValue;
            sayi1 = byte.MinValue;

            //bilinçli tür dönüşümü

            int sayi2 = 125;
            sayi1 = (byte)sayi2;

            Console.WriteLine(sayi1);

            //bilinçsiz tür dönüşümü 

            double sayi3 = 10;
            sayi3 = sayi2;
            Console.WriteLine(sayi3);
            //checked - unchecked

            unchecked
            {
                sayi2 = 512;
                sayi1 = (byte)sayi2;
            }


            //değer kaybında uyarı almak istiyorsak checed kullanmalıyız 

            // checked
            //
          //{
               // sayi2 = 512;
                //sayi1 = (byte)sayi2;
            //}

            //unchecked değer kaybı olursa uyarı vermemeyi sağlar 

            //object tüm veri tiplerinin atasıdır her tip değişkeni tanıyan ana tiptir 


            object temeltip = sayi2;
            temeltip = sayi3;
            temeltip = new 
            {
                marka = "honda",
                model = " civic",
            };

            //boxing işlemi 
            temeltip = sayi2; //boxing işlemi 
            sayi2 = (int)temeltip; //unboxing işlemi 

            
           
            
           
           
            Console.Write("");

        }
    }
}
