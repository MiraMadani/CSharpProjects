//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Classwork
//{
//    internal class Classwork3
//    {
//        static int Main(string[] args)
//        {
//            // 1 Реализовать метод, в котором производиться
//            //возведения числа в степень. В метод передается число и степень, метод
//            //ничего не возвращает. После вызова метода, отобразить новое значение переменной.

//            //Pow(12, 2,out int res);
//            //Console.WriteLine(res) ;

//            //2 Разработать метод, который принимает массив или литеральные значения и находит
//            //все трехзначные числа массива, уменьшающиеся в 9 раз при зачеркивании
//            //средней цифры, и возвращает их количество. При этом нужно использовать params.

//            // Console.WriteLine( Function(189,343,225,789));

//            //3 Реализовать метод, повторяющий работу  метода Split(), класса String.
//            //Метод принимает строку и неограниченное количество сепараторов, по завершению работы,
//            //метод возвращает массив разделенной строки.  В самом методе можно использовать метод
//            //Substring или преобразование строки в  массив символов для ручного редактирования.


//            //4 Написать программу для вывода n членов арифметической прогрессии 1, 2, 3… с
//            //использованием рекурсивного метода.
//            return 0;
//        }

//        static string[] Split(string a,params string[] b)
//        {
//            string[] arr;
//            for(int i=0;i<a.Length;i++)
//            {
//                while (a[i]!=)
//                {

//                }
//            }
//        }
//        static int Function(params int[] arr)
//        {
//            int count = 0;
//            for(int i = 0; i < arr.Length; i++)
//            {
//                if (arr[i] >= 100)
//                {
//                    int number = (arr[i] / 100) * 10 + (arr[i]%10);
//                    if ((double)arr[i]/number==9.0)
//                    {
//                        count++;
//                    }
//                }
//            }
//            return count;
//        }
//        static void Pow(int x,int y,out int res)
//        {
//            res = 1;
//            for(int i=y;i>0;i--)
//            {
//                res *= x;
//            }
//        }
//    }
//}
