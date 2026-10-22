//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CSharpHomework2
//{
//    internal class Hw12
//    {
//        static void Main()
//        {
//            //Main Task
//            TArray<int> arr1 = new TArray<int>(new int[] {1,2,3,4,5});
//            arr1.Show();
//            TArray<string> arr2 = new TArray<string>(new string[] {"apple","red","food","hamster"});
//            arr2.Show();
//            Console.WriteLine(new string('-',20));
//            arr1.Add(9);
//            arr1.Show();
//            arr2.Add("cucumber");
//            arr2.Show();

//            Console.WriteLine(new string('-', 20));

//            arr1.Delete(4);
//            arr1.Show();
//            arr2.Delete("red");
//            arr2.Show();

//            Console.WriteLine(new string('-', 20));

//            Console.WriteLine("Arr1 Length: "+arr1.Length());
//            Console.WriteLine("Arr2 Length: " + arr2.Length());

//            Console.WriteLine(new string('-', 20));

//            Console.WriteLine("Arr1 element: " + arr1.GetElementByIndex(3));
//            Console.WriteLine("Arr2 element: " + arr2.GetElementByIndex(2));

//        }
//    }
//    class TArray<T>
//    {
//        public T[] Arr { get; set; }
//        public TArray(T[] arr)
//        {
//            Arr = arr;
//        }

//        public void Show()
//        {
//            foreach(var item in Arr)
//            {
//                Console.WriteLine(item);
//            }
//        }
//        public int Length()
//        {
//            return Arr.Length;
//        }
//        public void Add(T element)
//        {
//            T[] arr2 = new T[Arr.Length + 1];
//            for(int i = 0; i < Arr.Length; i++)
//            {
//                arr2[i] = Arr[i];
//            }
//            arr2[Arr.Length] = element;
//            Arr = arr2;
//        }

//        public void Delete(T element)
//        {
//            T[] arr2 = new T[Arr.Length - 1];
//            for (int i = 0, k=0; i < Arr.Length; i++)
//            {
//                if (Arr[i].Equals(element))
//                {
//                    continue;
//                }
//                arr2[k] = Arr[i];
//                k++;
//            }
//            Arr = arr2;
//        }

//        public T GetElementByIndex(int k)
//        {
//            return Arr[k];
//        }

//    }
//}
