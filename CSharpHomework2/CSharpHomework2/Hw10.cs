//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CSharpHomework2
//{
//    internal class Hw10
//    {
//        static void Main()
//        {
//            //Main Task
//            //DateTime dateTime= new DateTime(2023,01,20);
//            //Deposit deposit1= new Deposit("12A5","Mira",20_000,2,40,dateTime);
//            //Credit credit1 = new Credit("123B","Kate",40_000,3,40,dateTime);

//            //deposit1.Info();
//            //credit1.Info();

//            //double res1=deposit1.StopDeposit();
//            //double res2=credit1.StopDeposit();

//            //Console.WriteLine(res1);
//            //Console.WriteLine(res2);


//            //1
//            //Time time = new Time(12,45,4);
//            //Time time2 = time.Clone();

//            //int a=time.Next();
//            //int b = time.Prev();
//            //string c = time.ToString();
//            //Console.WriteLine(a);
//            //Console.WriteLine( b);
//            //Console.WriteLine(c);


//        }
//    }

//    class Time
//    {
//        public int Hours { get; set; }
//        public int Minutes { get; set; }
//        public int Seconds { get; set; }

//        public Time(int hours, int minutes, int seconds)
//        {
//            if (hours > 0 && minutes > 0 && seconds > 0)
//            {
//                Hours = hours;
//                Minutes = minutes;
//                Seconds = seconds;
//            }
//            else
//            {
//                throw new Exception("Incorrect data");
//            }
//        }

//        public Time Clone()
//        {
//            Time b=new Time(Hours, Minutes, Seconds);
//            return b;
//        }
//        public int Next()
//        {
//            int a = 0;
//            if (Hours == 24)
//            {
//                a = 1;
//            }
//            else
//            {
//                a = Hours + 1;
//            }
//            return a;
//        }

//        public int Prev()
//        {
//            int a = 0;
//            if (Hours == 1)
//            {
//                a = 24;
//            }
//            else
//            {
//                a = Hours - 1;
//            }
//            return a;
//        }
//        public override string ToString() {
//            string res=Hours.ToString()+":"+Minutes.ToString()+":"+Seconds.ToString();

//            return res;
//        }
//    }




//    class Deposit
//    {
//        public virtual string Id { get; set; }
//        public virtual string Name { get; set; }
//        public virtual int Sum { get; set; }
//        public virtual int DepositDuration { get; set; }
//        public virtual int Percent { get; set; }
//        public virtual DateTime Date { get; set; }

//        public  Deposit(string a,string b,int c,int d,int p,DateTime e)
//        {
//            Id = a;
//            Name = b;
//            Sum = c;
//            DepositDuration = d;
//            Percent = p;
//            Date = e;
//        }

//        public virtual void Info()
//        {
//            Console.WriteLine("Name "+Name);
//            Console.WriteLine("ID " + Id);
//            Console.WriteLine("Sum  " + Sum);
//            Console.WriteLine("Deposit duration " + DepositDuration);
//            Console.WriteLine("Percent " + Percent);
//            Console.WriteLine("Date  " + Date);

//        }
//        public virtual double StopDeposit()
//        {
//            DateTime date2 = DateTime.Now;
//            int m = date2.Month - Date.Month;
//            double res = Sum*(Math.Pow(1+(Percent/100),m));
          
//            return res;
//        }
//    }




//    class Credit:Deposit
//    {

//        public Credit(string a, string b, int c, int d, int p, DateTime e):base(a,b,c,d,p,e)
//        {
//            Id = a;
//            Name = b;
//            Sum = c;
//            DepositDuration = d;
//            Percent = p;
//            Date = e;
//        }

//        public override void Info()
//        {
//            Console.WriteLine("Name " + Name);
//            Console.WriteLine("ID " + Id);
//            Console.WriteLine("Sum  " + Sum);
//            Console.WriteLine("Credit duration " + DepositDuration);
//            Console.WriteLine("Percent " + Percent);
//            Console.WriteLine("Date  " + Date);

//        }

//        public override double StopDeposit()
//        {
            
//            double res = Sum+(Sum*(Percent/100));

//            return res;
//        }
//    }
//}
