//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Classwork
//{
//    internal class Classwork4
//    {
//        static void Main()
//        {
//            //Data data1= new Data();
//            //Data data2 = new Data();
//            //Data data3 = new Data();
//            //Data data4 = new Data();
//            //Data data5 = new Data();
//            //Data data6 = new Data();

//            //Data[] arr = { data1, data2, data3, data4, data5, data6 };
//            //int group = 3;
//            //char letter= 'A';
//            //int size = 0;
//            //for(int i = 0; i < arr.Length; i++)
//            //{
//            //    if (arr[i].Surname==letter && arr[i].Group == group)
//            //    {
//            //        size++;
//            //    }
//            //}
//            //string[] res= new string[size];
//            //for (int i = 0,k=0; i < arr.Length; i++)
//            //{
//            //    if (arr[i].Surname == letter && arr[i].Group == group)
//            //    {
//            //        res[k] = arr[i].FullSurname;
//            //        k++;
//            //        Console.WriteLine(arr[i].FullSurname);
//            //    }
//            //}

//       DayCollection a= new DayCollection();
//            Console.WriteLine(a["Monday"]);

//            Animal dog = new Dog("Jo", "Huski");
//            dog.Info();
//        }
//    }

//    class Animal
//    {
//        public string Name { get; set; }
//        public Animal(string name)
//        {
//            Name = name;
//        }
//        public void Info()
//        {
//            Console.WriteLine(Name);
//        }
//    }
//    class Dog : Animal
//    {
//        public Dog(string name,string breed) : base(name)
//        {
//            Name = name;
//            Breed = breed;
//        }

//        public string Breed { get; set; }
      

//    }

//    class DayCollection
//    {
//        private string[] weekdays;

//        public DayCollection()
//        {
//            weekdays = new string[] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
//        }
//        public int this[string a]
//        {
//            get
//            {

//                switch (a)
//                {
//                    case "Monday":
//                        return 1;
//                    case "Tuesday":
//                        return 2;
//                    case "Wednesday":
//                        return 3;
//                    case "Thursday":
//                        return 4;
//                    case "Friday":
//                        return 5;
//                        break;
//                    case "Sunday":
//                        return 7;
//                    default:
//                        return 0;

//                }
//            }
//        }
//    }
//    class Celsium
//    {
//        public double Value { get; set; } = 0;
       
//    }
//    class Faranheits
//    {
//        public static implicit operator Celsium(Faranheits a)
//        {
//            return new Celsium { Value = (a.Value-32 )*(5/9)};
//        }
//        public double Value { get; set; } = 0;

//    }
//    struct Data
//    {
//        private  readonly string surname;
//        private readonly int group;

//        public Data()
//        {
//            surname = Console.ReadLine();
//            group =Convert.ToInt32( Console.ReadLine());

//        }
//        public char Surname
//        {
//            get
//            {
//                return surname[0];
//            } 
//        }
//        public string FullSurname
//        {
//            get
//            {
//                return surname;
//            }
//        }
//        public int Group
//        {
//            get
//            {
//                return group;
//            }
//        }
//    }
//}
