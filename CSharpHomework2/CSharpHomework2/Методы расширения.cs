//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Runtime.CompilerServices;
//using System.Text;
//using System.Threading.Tasks;

//namespace CSharpHomework2
//{
//    internal class Методы_расширения
//    {
//        public static void Main()
//        {
//            //Main Task
//            Animal[] arr = new Animal[4] { new Animal(2, true, 3, "Cookie", "orange"), new Animal(2, false, 1, "Pure", "orange"), new Animal(4, false, 6, "Marshmallow", "white"), new Animal(7, true, 3, "Rex", "brown") };
//            foreach(var item in arr)
//            {
//                Console.WriteLine(item);
//                Console.WriteLine();
//            }

//            var res = arr.Select((x) =>
//                      new {str=x.NickName,str2=x.FurColor});


//            foreach (var item in res)
//            {
//                Console.WriteLine(item);
//                Console.WriteLine();
//            }


//        }
//    }

    
//    public class Animal
//    {
//        public int Weight { get; set; }
//        public bool Gender { get; set; }
//        public int Age { get; set; }
//        public string NickName{ get; set; }
//        public string FurColor { get; set; }

//        public Animal(int w,bool g,int h,string nickName,string f)
//        {
//            Weight = w;
//            Gender = g;
//            Age= h;
//            NickName= nickName;
//            FurColor= f;
//        }
//        public override string ToString()
//        {
//            string res = "Weight :" + Weight + " Age :" + Age + " Name :" + NickName + " FurColor :" + FurColor+" Gender(true-female false-male):"+Gender;
//            return res;
//        }


//    }

  
//}
