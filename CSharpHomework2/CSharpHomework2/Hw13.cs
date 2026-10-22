//using Microsoft.VisualBasic;
//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CSharpHomework2
//{
//    internal class Hw13
//    {
//        public static void Main()
//        {
//            //Main Task
//            MyCollection collection= new MyCollection() { Arr=new int[] { 1,2,3,4,5} };
//            Console.WriteLine(collection[0]);
//            bool res=collection.Contains(1);
//            Console.WriteLine(res);
//        }
//    }
//    public class MyCollection : System.Collections.ICollection
//    {
//        public int this[int index]   // indexer declaration
//        {
//            get => Arr[index];
//            set => Arr[index] = value;
//        }
//        public void Add(int item)
//        {
//            int[] arr2 = new int[Arr.Length];
//            arr2[Arr.Length ] = item;
//            Arr=arr2;
//        }
//        public void Clear()
//        {
//            int[] arr2 = new int[0];
//            Arr = arr2;
//        }
//        public bool Contains(int a)
//        {
//            foreach (var item in Arr)
//            {
//                if (item == a)
//                {
//                    return true;
//                }
//                else
//                {
//                    return false;
//                }
//            }
//            return true;
//        }
//        public int[] Arr { get; set; }
//        int ICollection.Count => Arr.Length;

//        bool ICollection.IsSynchronized => true;

//        object ICollection.SyncRoot => Arr;

//        void ICollection.CopyTo(Array array, int index)
//        {


//            Arr.CopyTo(array, index);
//        }

//        IEnumerator IEnumerable.GetEnumerator()
//        {


//            return Arr.GetEnumerator();
//        }
//    }
//}
