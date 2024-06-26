﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Intro();

            string sentence = "My name is Mustafa OK";

            var result = sentence.Length;
            var result2 = sentence.Clone();
            sentence = "My name is Name :o ";


            bool result3 = sentence.EndsWith("k");
            bool result4 = sentence.StartsWith("My name");

            //var result5 = sentence.IndexOf("M");   //M=0,y=1, =2  
            var result5 = sentence.IndexOf("name");   //M=0,y=1, =2  3. ise name ile başlıyor
            var result6 = sentence.IndexOf("namee");
            var result7 = sentence.IndexOf(" ");  // boşluğu arıyorum birden fazla var 
            var result8 = sentence.LastIndexOf(" "); // aramaya sondan başlar
            var result9 = sentence.Insert(0, "Hello "); //sentencein 0 ıncı karakterinden sonra Hello ekle
            var result10= sentence.Substring(3, 4); // 3. karakterden itibaren 4 karakter al
            var result11= sentence.ToLower();  // tüm harfleri küçült
            var result12= sentence.ToUpper();   //tüm harfleri büyült
            var result13= sentence.Replace(" ","_");  //boşlıuk yerine _ koy
            var result14=sentence.Remove(2, 4);   // 2. karakterden itibaren 4 tane uçur hiç yazmazsan hepsini ucurur.



            Console.WriteLine(result2);  //sentence klonlandı aynısı atandı
            Console.WriteLine(sentence);        // yeni verilince üstünde yeni kaldı bunu tam anlamadım normalde int,bool,decimal filanda bu oluyordu ama stringde olmuyor demişti sanki 



            Console.WriteLine(result5);
            Console.WriteLine(result6);   // bulamayınca -1 döndürüyor
            Console.WriteLine(result7);    //bulduğu ilk boşluğu sayar ondan sonra devam etmez aramaya
            Console.WriteLine(result8);
            Console.WriteLine(result9);
            Console.WriteLine(result10);
            Console.WriteLine(result11);
            Console.WriteLine(result12);
            Console.WriteLine(result13);
            Console.WriteLine(result14);




            Console.ReadLine();











        }







        private static void Intro()
        {
            string city = "Ankara";
            //Console.WriteLine(city[0]);

            foreach (var s in city)
            {
                Console.WriteLine(s);
            }

            string city2 = "İstanbul";
            //string result = city + city2;
            //Console.WriteLine(result);
            Console.WriteLine(String.Format("{0} {1}", city, city2));
            Console.WriteLine("{0} {1}", city, city2);  //Üstteki ile aynı
            Console.ReadLine();
        }
    }
}
