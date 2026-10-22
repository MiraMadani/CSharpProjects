//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CSharpHomework2
//{
//    internal class Hw9
//    {
//        static void Main()
//        {
//            //Main Task
//            //String str = new String("Hello world");
//            //Console.WriteLine($"String: {str}. Length: {str.Length}");
//            //String str2 = new String(str, 6);
//            //Console.WriteLine($"String: {str2}. Length: {str2.Length}");
//            //String str3 = new String(10);
//            //Console.WriteLine($"String: {str3}. Length: {str3.Length}");

//            //1
//            //Unit archer = new Archer(100,10,23);
//            //Unit fighter = new Fighter(80, 15, 30);
//            //Unit preast = new Preast(120, 0, 20);
//            //Unit[] arr= new Unit[3] { archer,fighter,preast};
//            //Team team1 = new Team(arr);
//            //team1.Attack();


//        }
//    }

//    class Team
//    {
//        private Unit[] arr;

//        public Team(Unit[] arr) {
//            this.arr = arr;
//        }
//        public void Attack()
//        {
//            foreach(var item in arr)
//            {
//                item.Attack();
//            }
//        }
//    }
//    class Unit
//    {
//        protected int health;
//        protected int uron;
//        protected int speed;

//        public Unit(int a,int b,int c)
//        {
//            health= a;
//            uron= b;
//            speed= c;
//        }
//        public int Health
//        {
//            get { return health; }
//        }
//        public int Uron
//        {
//            get { return uron; }
//        }
//        public int Speed
//        {
//            get { return speed; }
//        }
//        public void Attack()
//        {
//            Console.WriteLine("Attack");
//        }
        

//    }

//    class Archer : Unit
//    {
//        public int FiringRange { get;set; }
//        public Archer(int a, int b,int c):base(a ,b,c)
//        {
//            health = a;
//            uron = b;
//            speed = c;
//        }
//        public void Shot()
//        {
//            Random a = new Random();
//            int res = a.Next(-1, 1);
//            if (res == 1)
//            {
//                Console.WriteLine("Shot animation");

//            }
            
//        }
//    }

//    class Fighter : Unit
//    {
//        public int AttackPower { get; set; }
//        public void Attack()
//        {
//            AttackPower = 20;
//            Console.WriteLine("Attack animation");
//        }

//        public Fighter(int a, int b, int c) : base(a, b, c)
//        {
//            health = a;
//            uron = b;
//            speed = c;
//        }
//    }

//    class Preast : Unit
//    {
//        public int Mana { get; set; }
//        public void Heal()
//        {
//            Console.WriteLine("Heal animation");

//        }
//        public Preast(int a, int b, int c) : base(a, b, c)
//        {
//            health = a;
//            uron = b;
//            speed = c;
//        }
//    }









//    class String
//    {
//        char[] arr;
//        public String(int a) { 
//            arr = new char[a];
//        }
//        public String(string a)
//        {
//            arr = new char[a.Length];
//            for(int i = 0; i < arr.Length; i++)
//            {
//                arr[i] = a[i];
//            }
//        }
//        public String(String a,int n)
//        {
//            arr = new char[n];

//            for (int i = 0; i < n; i++)
//            {
//                arr[i] = a[i];
//            }
//        }
//        public int Length
//        {
//            get { return arr.Length; }
            
//        }
//        public char this[int a]
//        {
//            get
//            {
//                return arr[a];
//            }
//            set
//            {
//                arr[a] = value;
//            }
//        }
        
//    }
//}
