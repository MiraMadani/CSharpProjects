//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Classwork
//{
//    internal class Collections2
//    {
//        public static void Main()
//        {
//            //1
//            string[] arr = new string[7] { "mira","polina","lera","joj","bob","lora","amanda"};

//            var arr2=from item in arr where item[0]==item[item.Length-1] select item;


//            //string a = "lol lol kek , hamster kek ";
//            //string[] b=a.Split(' ');
           
//            //Dictionary<string,int> dict= new Dictionary<string,int>(StringComparer.OrdinalIgnoreCase);
//            //foreach(var item in b)
//            //{
//            //    if (dict.ContainsKey(item))
//            //    {
//            //        dict[item] += 1;

//            //    }
//            //    else
//            //    {
//            //        dict.Add(item, 1);
//            //    }
//            //}
//            //int[] arr=dict.Values.ToArray();
//            //int min = arr.Min();
//            //foreach(var item in dict)
//            //{
//            //    if (item.Value == min && item.Key !="" && item.Key != ",")
//            //    {
//            //        Console.WriteLine(item.Key+" встречается меньше всего");
//            //    }
//            //}
//        }
//        public int[] Method(int[] arr1, int[] arr2)
//        {
            
//            int[] res=arr1.Intersect(arr2).ToArray();

//            return res;
//        }
//    }
//}
