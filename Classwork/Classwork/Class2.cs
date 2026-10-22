//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Classwork
//{
//    internal class Class2
//    {
//        static void Main()
//        {
//            //int[] arr = new int[10];

//            //Func(arr,0);
//            //foreach (int i in arr) Console.WriteLine(i);


//            try
//            {
//                Class a= new Class();
//                a.Age = 900;

//            }
//            catch(Exception )
//            {
//                Console.WriteLine("Invalid age");
//            }

//        }

//        class Class
//        {
//            private int age;
//            public int Age{
//                get
//                {
//                    return age;
//                }

//                set
//                {
//                    if(value<0 || value > 120)
//                    {
//                        throw new Exception();
//                    }
//                    else
//                    {
//                        age = value;

//                    }
//                }
                    
//            }
//        }
//        public static int Func(int[]arr,int index)
//        {
//            try
//            {
//                for (int i = index; i < 10; i++)
//                {
//                     index = i;
//                    arr[i] = Convert.ToInt32(Console.ReadLine());
                    
//                }
//                return 0;
//            }
//            catch (Exception)
//            {
//                Console.WriteLine("Error");
//                return Func(arr,index);
//            }
//        }
//    }
    
//}
