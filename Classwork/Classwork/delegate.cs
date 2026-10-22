//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Security.Cryptography.X509Certificates;
//using System.Text;
//using System.Threading.Tasks;
//using static System.Runtime.InteropServices.JavaScript.JSType;

//namespace Classwork
//{
//    internal class @delegate
//    {
//        delegate void Message(int[] arr);

//        delegate T SomeOp<T>(T v);

//        delegate int Stepen(int a);

//        delegate void Delegate(ref int[] arr);
//        static void Main()
//        {





//            //Delegate d = delegate (ref int[] arr)
//            //{
//            //    Array.Resize(ref arr,arr.Length+1);
//            //    arr[arr.Length - 1] = 24;
//            //};


//            //int[] arr = new int[10];
//            //Random r = new Random();

//            //for(int i = 0; i < 10; i++)
//            //{
//            //    arr[i]= r.Next(1, 10);
//            //    Console.WriteLine(arr[i]);
//            //}

//            //d(ref arr);
//            //for (int i = 0; i < 11; i++)
//            //{
//            //    Console.WriteLine(arr[i]);

//            //}
       

//            User user = new User("Mira");
//            user.Notify += Show;
//            user.Notify += Show2;

//            user.Eat();
//            user.Walk();
//            user.Sleep();

//            Func("ccv", b => b.Length > 7 ? true : false);

//            int[] arr = new int[4] { 1, 2, 3, 4 };
//            Sum(array =>
//            {
//                int res = 0;
//                for (int i = 0; i < 4; i++)
//                {
//                    res += array[i];
//                }
//                return res;
//            }, arr);
            
//        }



//        interface INumber
//        {
//            int GetNumber();
//        }

//        class Class1 : INumber
//        {
//           public int Number { get; set; }
//            public int GetNumber()
//            {
//                int[] arr = new int[Number];
//            }
//        }






















//        public interface IVehicle
//        {
//            int Fluel { get; set; }
            

//            void FluelUsed();

//        }

//        public class Car : IVehicle
//        {
//           public  int Fluel { get; set; }
           
//            public void FluelUsed()
//            {
//                Console.WriteLine(Fluel-1);
//            }
//        }

//        public class CarHybrid : IVehicle
//        {
//            public int Fluel { get; set; }

//            public void FluelUsed()
//            {
//                Console.WriteLine(Fluel - 2);
//            }
//        }

//        public class Helicopter : IVehicle
//        {
//            public int Fluel { get; set; }

//            public void FluelUsed()
//            {
//                Console.WriteLine(Fluel - 3);
//            }
//        }

//        public static void Sum(Func<int[],int> a, int[] arr)
//        {
//            Console.WriteLine(a(arr));
//        }
//        public static void Func(string a, Predicate<string> b) 
//        {
//            b(a);
//        }

//        static void Show(string a)
//        {
//            Console.WriteLine(a);
//        }
//        static void Show2(string a)
//        {
//            Console.WriteLine("Func 2-"+ a);
//        }

//        class User
//        {

//            public delegate void Handler(string a);
//            public event Handler Notify;
//            public string Name { get; set; }

//            public User(string a)
//            {
//                Name = a;
//            }
//            public void Walk()
//            {
//                Notify?.Invoke("Walk");
//            }

//            public void Eat()
//            {
//                Notify?.Invoke("Eat");
//            }
//            public void Sleep()
//            {
//                Notify?.Invoke("Sleep");
//            }

//            public User()
//            {

//            }

//        }




//        public static int Number(int n)
//        {
//            int res = 0;
//            while(n > 0)
//            {
//                res += n % 10;
//                n /= 10;
//            }
//            return res;
//        }

//        public static void Line(string n)
//        {
//            char[] arr=new char[n.Length];
//            for(int i = n.Length - 1,k=0; i >=0; i--)
//            {
//                arr[k] = n[i];
//                Console.Write(arr[k]);
//                k++;
//            }
//        }

//        public static void SortByMax(int[] array)
//        {
//            var len = array.Length;
//            for (var i = 1; i < len; i++)
//            {
//                for (var j = 0; j < len - i; j++)
//                {
//                    if (array[j] > array[j + 1])
//                    {
//                         int temp= array[j];
//                         array[j]=  array[j + 1];
//                         array[j + 1]= temp;

//                    }
//                }
//            }
//            Console.WriteLine();
//            Console.WriteLine("отсортированый масив в большую сторону");
//            for (int i = 0; i < len; i++)
//            {
//                Console.Write(array[i]+" ");
//            }
//        }



//        public static void SortByMin(int[] array)
//        {
//            var len = array.Length;
//            for (var i = 1; i < len; i++)
//            {
//                for (var j = 0; j < len - i; j++)
//                {
//                    if (array[j] < array[j + 1])
//                    {
//                        int temp = array[j];
//                        array[j] = array[j + 1];
//                        array[j + 1] = temp;

//                    }
//                }
//            }
//            Console.WriteLine();
//            Console.WriteLine("отсортированый масив в меньшую сторону");
//            for (int i = 0; i < len; i++)
//            {
//                Console.Write(array[i] + " ");
//            }
//        }



//        public static void EvenNumbers(int[] arr)
//        {
//            int size = 0;
//            for(int i = 0; i < arr.Length; i++)
//            {
//                if (arr[i] % 2 == 0)
//                {
//                    size++;
//                }
//            }
//            int[]res=new int[size];
//            Console.WriteLine();
//            Console.WriteLine("Четный масив");
//            for (int i = 0,k=0; i < arr.Length; i++)
//            {
//                if (arr[i] % 2 == 0)
//                {
//                    res[k] = arr[i];
//                    Console.Write(res[k]+" ");
//                    k++;
//                }
//            }

//        }




//        public static void NotEvenNumbers(int[] arr)
//        {
//            int size = 0;
//            for (int i = 0; i < arr.Length; i++)
//            {
//                if (arr[i] % 2 != 0)
//                {
//                    size++;
//                }
//            }
//            int[] res = new int[size];
//            Console.WriteLine();
//            Console.WriteLine("Нечетный масив");
//            for (int i = 0, k = 0; i < arr.Length; i++)
//            {
//                if (arr[i] % 2 != 0)
//                {
//                    res[k] = arr[i];
//                    Console.Write(res[k] + " ");
//                    k++;
//                }
//            }

//        }


//    }










   
//}
