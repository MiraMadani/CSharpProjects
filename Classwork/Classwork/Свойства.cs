//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Runtime.CompilerServices;
//using System.Text;
//using System.Threading.Tasks;

//namespace Classwork
//{
//    internal class Свойства
//    {
//        static void  Main()
//        {
//            //1
//            //Image a=new Image();
//            // a.Name = "Mdvs";
//            // a.Alt = "Mdvs"; 
//            // a.Source = "Mdvs";
//            // a.Height = 10;
//            // a.Width = 10;
//            // Console.WriteLine(a.Name);
//            // Console.WriteLine(a.Alt);
//            // Console.WriteLine(a.Source);
//            // Console.WriteLine(a.Height);
//            // Console.WriteLine(a.Width);
//            //2
//            //int[] arr1 = new int[10];
//            //int[] arr2 = new int[10];
//            //Random random= new Random();
//            //for(int i=0;i<arr1.Length;i++) {
//            //    arr1[i] = random.Next(1,30);
//            //}
//            //arr2 = arr1[..];
//            //Array.Sort(arr2);
//            //foreach(var element in arr2)
//            //{
//            //    Console.WriteLine(element);
//            //}
//            //double res = MyMath.Add(1, 2, 3, 4);
//            //Console.WriteLine(res);
//            // res = MyMath.Mult(8,10);
//            //Console.WriteLine(res);

//            //2 
//            Coffee c = new Coffee("12334HHgg", "dfd");
//            Coffee c1 = new Coffee("12334HHgg", "dfd");
//            Coffee c2 = new Coffee("12334HHgg", "dfd");
//            Coffee c3= new Coffee("12334HHgg", "dfd");
//            Coffee c4= new Coffee("12334HHgg", "dfd");
//            Coffee c5 = new Coffee("12334HHgg", "dfd");

//        }
//    }

//     class Coffee
//    {
//        private static int count=5;
//        private  string id;
//        private  string name;

//         static  Coffee()
//        {
//            Console.WriteLine("Hello");
//        }
//        public  Coffee(string id, string name)
//        {
//            if (count!=0) {
//                this.id = id;
//                this.name = name;
//                count--;
//            }
//            else
//            {
//                Console.WriteLine("No more coffee");
//            }
//        }

//    }
//    static class MyMath
//    {
//        public static double Add(params double[] a)
//        {
//            double res = 0;
//            foreach(var element in a)
//            {
//                res+= element;
//            }
//            return res;
//        }
//        public static double Mult(params double[] a)
//        {
//            double res = 1;
//            foreach (var element in a)
//            {
//                res *= element;
//            }
//            return res;
//        }
//    }
//    class Image
//    {
//        private string name;
//        private int width;
//        private int height;
//        private string src;
//        private string alt;

//        public int Height
//        {
//            get
//            {
//                return height;
//            }
//            set
//            {
//                height = value;
//            }
//        }
       
//        public int Width
//        {
//            get
//            {
//                return width;
//            }
//            set
//            {
//               width = value;
//            }
//        }
//        public string Name
//        {
//            get
//            {
//                return name;
//            }
//            set
//            {
//                name = value;
//            }
//        }
//        public string Source
//        {
//            get
//            {
//                return src;
//            }
//            set
//            {
//                src = value;
//            }
//        }
//        public string Alt
//        {
//            get
//            {
//                return alt;
//            }
//            set
//            {
//                alt = value;
//            }
//        }

//    }
//}
