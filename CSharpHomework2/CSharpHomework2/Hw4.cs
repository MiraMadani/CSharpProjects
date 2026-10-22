//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Reflection.Metadata.Ecma335;
//using System.Text;
//using System.Threading.Tasks;

//namespace CSharpHomework2
//{
//    internal class Hw4
//    {

//        static void Main()
//        {
//            //Main Task Лесенкой называется набор кубиков, в котором каждый
//            //более верхний слой содержит на 1 кубик меньше, чем предыдущий.
//            //Требуется написать программу, вычисляющую  число ступеней,
//            //которое можно построить из N кубиков. Использовать рекурсию.
//            // К примеру, из 3 - ех кубиков, можно построить 2 - е ступени:
//            // [ ]
//            // [ ][ ]

//            int res = StepCount(3);
//            Console.WriteLine(res);
          
//            //2

//        }
//        static int StepCount(int a, int i = 2,int count = 0)
//        {
//            if (a > 0)
//            {
//                return StepCount(a - i, i + 1, count + 1);

//            }
//            else
//            {
//                return count;
//            }
//        }

//    }

//}


