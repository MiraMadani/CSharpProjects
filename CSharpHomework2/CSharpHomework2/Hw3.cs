//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Security.Cryptography;
//using System.Text;
//using System.Threading.Tasks;

//namespace CSharpHomework2
//{
//    internal class Hw3
//    {
//        static void Main()
//        {


//            //  Main task
//            //Дана строка текста. Определить сколько раз встречается каждый
//            //символ в строке. Например: 
//            //Пусть исходная строка Str: "x w x y x w".
//            //Тогда х -встречается 3 раза, у - встречается 1 раз, w - встречается 2 раза.

//            //char[] symbols = new char[13];//масив в котором будут записаны только исключительные символы массивав
//            //int[] counts = new int[13];//массив с количествами исключительных елементов массива

//            //int k = 0;
//            //string a = "I like hamsters lol";//строка

//            //for (int i = 0; i < a.Length; i++)//цыкл в котором в массив записываються исключительные елементы массива
//            //{
//            //    if (!symbols.Contains(a[i]))
//            //    {
//            //        symbols[k] = a[i];
//            //        k++;
//            //    }
//            //}

//            //for (int i = 0; i < symbols.Length; i++)//в цыле подсчитывается количество каждого исключительного елемента в массиве
//            //{
//            //    counts[i] = Count(a, symbols[i]);
//            //}

//            //for (int i = 0; i < symbols.Length; i++)//вывод символов и их количеств
//            //{
//            //    Console.WriteLine(symbols[i] + " " + counts[i]);
//            //}



//            //1 Дано натуральное число N. Нужно переставить
//            //его цифры так, чтобы образовалось наибольшее число, записанное теми же цифрами.

//            //int number = 2039;
//            //string c = number.ToString();
//            //char[] res=new char[c.Length];
//            //int index=0;
//            //int size = c.Length;
//            //for (int i = 0; i <size;i++)
//            //{
//            //    index = c.IndexOf(c.Max());
//            //    res[i] = c[index];
//            //    c = c.Remove(index, 1);
//            //}
//            //Console.WriteLine(res) ;




//            //2 Дана строка, убедиться, что все символы в строке имеет равное количество. К примеру, строка
//            //– abaababcbccc, имеет равное количество символов, а строка – abbc, не равное.

//            //string a = "abaababcbccc";
//            //int k = 0;
//            //char[] symbols = new char[3];//масив в котором будут записаны только исключительные символы массивав
//            //for (int i = 0; i < a.Length; i++)//цыкл в котором в массив записываються исключительные елементы массива
//            //{
//            //    if (!symbols.Contains(a[i]))
//            //    {
//            //        symbols[k] = a[i];
//            //        k++;
//            //    }
//            //}
//            //bool flag = true;
//            //for (int i = 0; i < symbols.Length-1; i++)
//            //{
//            //    if (Count(a, symbols[i])!= Count(a, symbols[i+1]))
//            //    {
//            //        flag = false;
//            //    }
//            //}
//            //if (flag)
//            //{
//            //    Console.WriteLine("Все символы в строке имеют равное количество");
//            //}
//            //else
//            //{
//            //    Console.WriteLine("Не все символы в строке имеют равное количество");
//            //}


//            //3 Теоре́ма о бесконе́чных обезья́нах

//            //string a = Console.ReadLine();//вводить число только маленькими английскими буква ми mira  lol
//            //long tryCount = 0;
//            //string monkeyWord="";

//            //while (monkeyWord != a)
//            //{
//            //    monkeyWord = GenerateRandomWord(a.Length);
//            //    tryCount++;
//            //}
//            //Console.WriteLine(tryCount);


//            //4 Необходимо написать программу, которая проверяет пользователя на знание таблицы умножения.
//            //Пользователь сам вводит два целых однозначных числа. Программа задает вопрос: результат
//            //умножения первого числа на второе. Пользователь должен ввести ответ
//            //и увидеть на экране правильно он ответил или нет. Решить задачу с использование метода.

//            //int number1 = 0;
//            //int number2 = 0;
//            //int res = 0;
//            //Console.Write("Введите первое число->");
//            //number1 = Convert.ToInt32(Console.ReadLine());
//            //Console.Write("Введите второе число->");
//            //number2 = Convert.ToInt32(Console.ReadLine());
//            //Console.Write("Результат умножения первого числа на второе->");
//            //res = Convert.ToInt32(Console.ReadLine());
//            //int trueRes = number1 * number2;
//            //Check(trueRes, res);

//            //7  	Создать метод, который 2 параметра: массив чисел и число.
//            //Метод должен найти ближайшее число к заданному из массива.

//            //int[] arr = { 1, 2, 17,29};
//            //int a = 15;
//            //Console.WriteLine(ClosestNumber(arr,a));
//        }

       


//        static int ClosestNumber(int[] arr,int a)
//        {
//            int[] arr2 = new int[arr.Length];
//            for(int i = 0; i < arr.Length; i++)
//            {
//                arr2[i] = Math.Abs(arr[i] - a);
//            }
//            int number = arr2.Min();
//            int index = Array.IndexOf(arr2,number);
//            return arr[index] ;

//        }



//        static void Check(int trueRes,int res)
//        {
//            if (trueRes == res)
//            {
//                Console.WriteLine("Да,это правильный ответ");
//            }
//            else
//            {
//                Console.WriteLine("Нет!Это не правильный ответ.Правильный-> " + trueRes);
//            }
//        }




//        static string GenerateRandomWord(int size)
//        {
//            Random r = new Random();

//            char[] arr = new char[size];
//            for(int i = 0; i < size; i++)
//            {
//                arr[i] = Convert.ToChar(r.Next(97, 122));
//            }
//            string res = new string(arr);
//            return res;
//        }




//        static int Count(string a,char b)//считает количесто символа в масиве
//        {
//            int count = 0;
//            for(int i = 0; i < a.Length; i++)
//            {
//                if (a[i] == b)
//                {
//                    count++;
//                }
//            }
//            return count;
//        }





//    }
//}
