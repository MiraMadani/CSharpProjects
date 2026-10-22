//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Reflection.Metadata.Ecma335;
//using System.Runtime.CompilerServices;
//using System.Text;
//using System.Threading.Tasks;

//namespace Classwork
//{
//    internal class Class3
//    {
//        public static void Main()
//        {
//            //Person p=new Person();
//            //((IMovable)p).Move();
//            //string a=((IMovable)p).Name;

//            //ProductShop a=new ProductShop();
//            //a.Name = "Silpo";
//            //ProductShop b = new ProductShop();
//            //b = (ProductShop)a.Clone();
//            //a.Name = "ATB";
//            //Console.WriteLine(a.Name);
//            //Console.WriteLine(b.Name);

//            int[] ar = new int[10];
//            Random r = new Random();
//            for (int i = 0; i < ar.Length; i++)
//            {
//                ar[i] = r.Next(1, 10);
//                Console.Write(ar[i] + " ");
//            }
//            Console.WriteLine();


//            int[] res=ar.GetEvenNumbers();
//            foreach(var item in res)
//            {
//                Console.Write(item+" ");
//            }

//            string email = "jnjnjnj@gmail.com";
//            Console.WriteLine(email.EmailChecker());
//        }


//    }
//    public static class Extansion
//    {


//        public static bool EmailChecker (this string a){

//            bool res = true;
//            if (!a.Contains("@gmail.com"))
//            {
//                res= false;
//            }

//            return res;
//        }



//        public static int[] GetEvenNumbers(this int[] a)
//        {
//            int count = 0;
//            for (int i = 0; i < a.Length; i++)
//            {
//                if (a[i] % 2 == 0)
//                {
//                    count++;
//                }
//            }
//            int[] result = new int[count];
//            for (int i = 0, k = 0; i < a.Length; i++)
//            {
//                if (a[i] % 2 == 0)
//                {
//                    result[k] = a[i];
//                    k++;
//                }
//            }
//            return result;
//        }
//    }
//}
