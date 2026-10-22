//using System;
//using System.Collections.Generic;
//using System.Data;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CSharpHomework2
//{
//    internal class Hw6
//    {

//        static void Main()
//        {
//            //Main task
//            //DateTime a = new DateTime(2007,2, 16);
//            //Birthday myBirthday = new Birthday();
//            //myBirthday.SetDate(a);
//            //string res = myBirthday.WeekDayOfBirth();
//            //Console.WriteLine(res);
//            //res = myBirthday.WeekDayOfBirth(2025);
//            //Console.WriteLine(res);
//            //int res2 = myBirthday.DaysUntilBirthday();
//            //Console.WriteLine(res2);

//            //1 Создать программу, которая анализирует введенный пользователем текст и выделяет самые
//            //часто встречающиеся слова в нем. Для решения задачи, использовать минимум 2 класса,
//            //массивы и методы. Продумать эффективный и удобный алгоритм. Так, что бы ваше приложение
//            //могло работать в виде отдельной библиотеки.

//            //Text text = new Text("I ss cc lll ss cc kk kk ss lll lll lll");
//            //TextAnalis textAnalis= new TextAnalis(text);
//            //textAnalis.FrequentWords();

         
           

//        }
//    }

//    class Text
//        {
//            public string Words;

//            public Text(string a)
//            {
//                Words = a;
//            }
//        }
//        class TextAnalis
//        {
//            Text a;
//            public TextAnalis(Text a)
//            {
//                this.a = a;
//            }
//            public void FrequentWords()
//            {

//                string[] arr = a.Words.Split(' ');
//                int[] counts = new int[arr.Length];
//                string[] strings = new string[arr.Length];

//                for (int i = 0, k = 0; i < arr.Length; i++)
//                {
//                    string Word = arr[i];
//                    int count = 0;
//                    foreach (string word in arr)
//                    {
//                        if (word.Contains(Word))
//                        {
//                            count++;
//                        }
//                    }
//                    if (count > 1 && !strings.Contains(Word))
//                    {
//                        counts[k] = count;
//                        strings[k] = Word;
//                        k++;
//                    }

//                    count = 0;
//                }
//                for (int i = 0; i < counts.Length; i++)
//                {
//                    if (counts[i] != 0)
//                    {
//                        Console.WriteLine(strings[i] + " - " + counts[i]);
//                    }
//                }
//            }
//        }
//        struct Birthday
//        {
//            DateTime Date;
//            int GiftCount;
//            string Name;

//            public Birthday(DateTime a, int b, string c)
//            {
//                Date = a;
//                GiftCount = b;
//                Name = c;
//            }
//            public void SetDate(DateTime a)
//            {
//                Date = a;
//            }
//            public string WeekDayOfBirth()
//            {
//                DayOfWeek a;
//                a = Date.DayOfWeek;
//                return a.ToString();
//            }

//            public string WeekDayOfBirth(int b)
//            {
//                DateTime date2 = Date.AddYears(b - Date.Year);
//                DayOfWeek a;
//                a = date2.DayOfWeek;
//                return a.ToString();
//            }
//            public int DaysUntilBirthday()
//            {
//                // 27 01 2007 //  16 04 2005 
//                TimeSpan days;

//                DateTime date2 = DateTime.Now;//11 02 2024
//                DateTime date3 = Date.AddYears(date2.Year - Date.Year);//27 01 2024 //16 04 2024
//                if (date3 < date2)
//                {
//                    date3 = date3.AddYears(1);
//                    days = date3 - date2;
//                }
//                else
//                {
//                    days = date3 - date2;

//                }
//                return Convert.ToInt32(days.TotalDays);
//            }

//        }





//    }


