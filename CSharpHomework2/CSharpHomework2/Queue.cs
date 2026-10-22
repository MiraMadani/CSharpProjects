//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CSharpHomework2
//{

    
//    internal class Queue
//    {
       

//        public static void Main()
//        {
//            //Main Task

//            //Printer printer= new Printer();
//            //printer.CheckDocs();

//            //printer.Add(new Document() {Text="Document"}, Priority.High);
//            //printer.Add(new Document() { Text = "Photo" }, Priority.Low);
//            //printer.Add(new Document() { Text = "Presetnation" }, Priority.Middle);
//            //printer.Add(new Document() { Text = "Filelol" }, Priority.Middle);


//            //printer.ShowQueue();
//            //Console.WriteLine(); ;
//            //printer.CheckDocs();

//            //printer.Print();
//            //printer.ShowQueue();

//            //printer.Print();
//            //printer.ShowQueue();
//            //printer.Print();
//            //printer.ShowQueue();
//            //printer.Print();
//            //printer.ShowQueue();

//            //1

//            //ArrayList array= new ArrayList(50);
//            //Random random= new Random();
//            //for(int i = 0; i < 50; i++)
//            //{
//            //    array.Add(random.Next(-10,10));
//            //    Console.Write(array[i]+"|");
//            //}
//            //Console.WriteLine();
//            //array.Sort();
//            //Console.WriteLine(BinarySearch(array, 8));

            
            
//        }
//        public static object BinarySearch(ArrayList a, int key)
//        {
//            int min = 0;
//            int max = a.Count - 1;
//            while (min <= max)
//            {
//                int mid = (min + max) / 2;
//                if (key == Convert.ToInt32(a[mid]))
//                {
//                    return ++mid;
//                }
//                else if (key < Convert.ToInt32(a[mid]))
//                {
//                    max = mid - 1;
//                }
//                else
//                {
//                    min = mid + 1;
//                }
//            }
//            return "Nil";
//        }




//    }


//   public  enum Priority
//    {
//        Low,
//        Middle,
//        High
//    }


//    public class Document
//    {
//        public string Text { get; set; }
//        public override string ToString()
//        {
//            return "("+Text+")";
//        }
//    }
//    public class Printer
//    {
//        private Queue<Document> queueLow = new Queue<Document>();
//        private Queue<Document> queueMiddle  = new Queue<Document>();
//        private Queue<Document> queueHigh = new Queue<Document>();

//        public void Add(Document document, Priority a)
//        {
//            if (Priority.Low==a) { 
//                queueLow.Enqueue(document); 
//            }
//            if (Priority.Middle == a)
//            {
//                queueMiddle.Enqueue(document);
//            }
//            if (Priority.High == a)
//            {
//                queueHigh.Enqueue(document);
//            }
//        }
//        public void Print()
//        {
//            if (queueHigh.Count!=0)
//            {
//                queueHigh.Dequeue();
                
//            }
//            else if(queueMiddle.Count!=0 && queueHigh.Count==0) {
//                queueMiddle.Dequeue();

//            }
//            else if (queueMiddle.Count==0 && queueLow.Count!=0)
//            {
//                queueLow.Dequeue();

//            }
//        }
//        public void CheckDocs()
//        {
//            if(queueLow.Count==0 && queueMiddle.Count==0 && queueHigh.Count==0)
//            {
//                Console.WriteLine("Нет документов");
//            }
//            else
//            {
//                Console.WriteLine("Документы есть");
//            }
//        }
//        public void ShowQueue()
//        {
//            Console.WriteLine();
//            if(queueLow.Count!=0)
//            {
//                foreach (var item in queueLow)
//                {
//                    Console.Write(item + " ");
//                }
//                Console.Write("|");
//            }
//            if(queueMiddle.Count != 0)
//            {
//                foreach (var item in queueMiddle)
//                {
//                    Console.Write(item + " ");
//                }
//            }
//             if(queueHigh.Count!=0)
//            {
//                Console.Write("|");
//                foreach (var item in queueHigh)
//                {
//                    Console.Write(item + " ");
//                }
//            }
            
//           CheckDocs();
           
            
//        }
//    }
//}
