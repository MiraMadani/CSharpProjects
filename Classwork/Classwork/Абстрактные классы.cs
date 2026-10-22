//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Classwork
//{
//    internal class Абстрактные_классы
//    {
//        static void Main()
//        {
//            //1
//            //Vehicle a = new Plane("White","Plane",300,"mira");
//            //Vehicle b = new Car("White", "Car", 300, 4);
//            //a.Info();
//            //b.Info();

//            //2
//            Console.WriteLine("Выберите тип транспорта");
//            int choice1 =Convert.ToInt32( Console.ReadLine());
//            Console.WriteLine("1.Авто");
//            Console.WriteLine("2.Поезд");
//            Console.WriteLine("3.Самолет");

//            Console.WriteLine("");
//            int choice2 = Convert.ToInt32(Console.ReadLine());

//        }
//    }
//}

//   abstract class CargoCarrier
//    {
//        public  int Speed { get; set; }
//    public CargoCarrier(int a) {
//        Speed = a;
//    }

//    }



//class Train : CargoCarrier
//{
//    public Train(int a) : base(a)
//    {
//    }
//}

//class Plane : CargoCarrier
//{
//    public Plane(int a) : base(a)
//    {
//    }
//}

//class Car: CargoCarrier
//{
//    public Car(int a) : base(a)
//    {
//    }
//}

//abstract class Vehicle
//    {
//        public  string Color { get; set; }
//        public string Name { get; set; }
//        public  int Speed{ get; set; }

//        public abstract void Info();
        

//        public  Vehicle(string c,string n,int s)
//        {
//            this.Name = c;
//            this.Speed = s;
//            this.Color = n;

//        }
//    }

//    //class Plane : Vehicle
//    //{
//    //    public string Pilot { get; set; }
//    //    public Plane(string c, string n, int s, string pilot) : base(c, n, s)
//    //    {
//    //        Pilot = pilot;
//    //    }

//    //    public override void Info()
//    //    {
//    //        Console.WriteLine(Color);
//    //        Console.WriteLine(Name);
//    //        Console.WriteLine(Speed);
//    //        Console.WriteLine(Pilot);

//    //    }
//    //}

//    //class Car : Vehicle
//    //{
//    //    public int Clearence { get; set; }
//    //    public Car(string c, string n, int s, int cl) : base(c, n, s)
//    //    {
//    //        Clearence= cl;
//    //    }

//    //    public override void Info()
//    //    {
//    //        Console.WriteLine(Color);
//    //        Console.WriteLine(Name);
//    //        Console.WriteLine(Speed);
//    //        Console.WriteLine(Clearence);

//    //    }
//    //}

