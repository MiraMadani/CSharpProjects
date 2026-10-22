//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CSharpHomework2
//{
//    internal class HW11
//    {
//        static void Main()
//        {
//            //main task
//            Vehicle a = new AirCraft(300, "white", 2);
//            Vehicle b= new Truck(70, "gray", 4,500);
//            a.Info();
//            Console.WriteLine(new string('-',20));
//            b.Info();

//        }


//        abstract class Vehicle
//        {
//            public Vehicle(int s,string c,int w)
//            {
//                Speed = s;
//                Color= c;
//                WheelCount = w;
//            }
//            public virtual int Speed { get; set;}
//            public virtual string Color { get; set; }
//            public virtual int WheelCount { get; set; }

//            public virtual void Info()
//            {
//                Console.WriteLine("Speed:"+Speed);
//                Console.WriteLine("Color:" + Color);
//                Console.WriteLine("WheelCount:" + WheelCount);

//            }

//        }



//        class AirCraft : Vehicle
//        { 
//            private int wheelCount;

//            public AirCraft(int s, string c, int w) : base(s, c, w)
//            {
//                wheelCount = s;
//                Color= c;
//                Speed = s;
//            }

//            public override int WheelCount { 
//                get { return wheelCount; }
//                set { if (value > 2) { throw new Exception("Too many wheels for aircraft"); } }
//            }
//        }



//        class Truck : Vehicle
//        {
//            public Truck(int s, string c, int w,int l) : base(s, c, w)
//            {
//                WheelCount = s;
//                Color = c;
//                Speed = s;
//                LiftingCapacity= l;
//            }

//            public int LiftingCapacity { get; set; }
//            public override void Info()
//            {
//                Console.WriteLine("Speed:" + Speed);
//                Console.WriteLine("Color:" + Color);
//                Console.WriteLine("WheelCount:" + WheelCount);
//                Console.WriteLine("Lifting capacity :" + LiftingCapacity);

//            }

//        }



//        class Helicopter : AirCraft
//        {
//            public Helicopter(int s, string c, int w) : base(s, c, w)
//            {
//            }
//        }
//        class Chaser : AirCraft
//        {
//            public Chaser(int s, string c, int w) : base(s, c, w)
//            {
//            }
//        }



//    }
//}
