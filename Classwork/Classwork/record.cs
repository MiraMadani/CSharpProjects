//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Classwork
//{
//    internal class record
//    {
//        static void Main()
//        {
//            DayTemperature[] arr = new DayTemperature[3] { new DayTemperature(23, 12), new DayTemperature(30, 0), new DayTemperature(28, 5) };
//            int[] res = new int[3];
//            int i = 0;
//            foreach(DayTemperature t in arr )
//            {
//                res[i] = Math.Abs(t.Max - t.Min);
//                i++;
//            }
//            Console.WriteLine(arr[Array.IndexOf(res,res.Max())]);

//            TClass<int> a = new TClass<int>(23008);
//            TClass<short> b = new TClass<short>(23);
//            TClass<string> c = new TClass<string>("lol");
//            a.GetType(a);
//            b.GetType(b);
//            c.GetType(c);


//        }
//    }


//    class TClass<T>
//    {
//        public T Value { get; set; }
//        public TClass(T value)
//        {
//            Value = value;
//        }
//        public  void GetType(TClass<T> a)
//        {
//            switch(a)
//            {
//                case TClass<int> :
//                    Console.WriteLine("Type: int"+" Value:"+a.Value);
//                    break;
//                case TClass<short>:
//                    Console.WriteLine("Type: short" + " Value:" + a.Value);
//                    break;
//                case TClass<string>:
//                    Console.WriteLine("Type: string" + " Value:" + a.Value);
//                    break;
//                case TClass<long>:
//                    Console.WriteLine("Type: long" + " Value:" + a.Value);
//                    break;
//            }
//        }
//    }
//  record DayTemperature(int Max,int Min) { }
//}
