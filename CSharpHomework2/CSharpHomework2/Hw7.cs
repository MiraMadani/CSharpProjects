//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Security.Cryptography.X509Certificates;
//using System.Text;
//using System.Threading.Tasks;

//namespace CSharpHomework2
//{
//    internal class Hw7
//    {
//        static void Main()
//        {
//            //Main Task
//            Item item1 = new Item("Sword",12,100,5);
//            Item item2 = new Item("Stick", 1, 0, 1);
//            Item item3 = new Item("Shield", 10, 120, 7);
//            Item[] arr = new Item[] { item1, item2, item3 };

//            Player Mira = new Player("Mira", arr);
//            int res1 =Mira.GetAll();
//            Console.WriteLine(res1);
//            Mira.ChangeInventorySize(item1);
//            Item res=Mira.Search(120);

//        }
//    }
//    class Item
//    {
//        private string name;
//        private int level;
//        private int value;
//        private int weight;

//       public Item(string a, int b, int c, int d)
//        {

//            name = a;
//            level = b;
//            value = c;
//            weight = d;
//        }
//        public int Weight
//        {
//            get { return weight; }
//        }
//        public int Value
//        {
//            get { return value; }
//        }
//        public int Level
//        {
//            get { return level; }
//        }
//    }
//    class Player
//    {
//        private string name;
//        private Item[] inventory;
//        public Player(string a, Item[] b)
//        {
//            this.name = a;  
//            this.inventory = b;
//        }
      
//        public int GetAll()
//        {
//            Console.WriteLine("1-Get all weight\n2-Get all value");
//            int choice = Convert.ToInt32(Console.ReadLine());
//            int res = 0;
//            switch (choice)
//            {
//                case 1:
//                    foreach (Item item in inventory)
//                    {
//                        res += item.Weight;
//                    }
//                    return res;
//                    break;
//                case 2:

//                    foreach (Item item in inventory)
//                    {
//                        res += item.Value;
//                    }
//                    return res;
//                    break;
//            }
//            return res;


//        }
//        public void ChangeInventorySize(Item a)
//        {
//            Console.WriteLine("1-To add item\n2-To delete an item");
//            int choice=Convert.ToInt32(Console.ReadLine());
//            switch (choice)
//            {
//                case 1:
//                    Item[] arr2 = new Item[inventory.Length + 1];
//                    for(int i = 0; i < inventory.Length; i++)
//                    {
//                        arr2[i] = inventory[i];
//                    }
//                    arr2[arr2.Length - 1]=a;
//                    inventory= arr2;
//                    foreach(Item item in inventory)
//                    {
//                        Console.WriteLine(item.Value);
//                    }
//                    break;
//                case 2:
//                    Item[] arr3 = new Item[inventory.Length - 1];
//                    for (int i = 0,k=0; i < inventory.Length; i++)
//                    {
//                        if (i == Array.IndexOf(inventory,a))
//                        {
//                            continue;
//                        }
//                        arr3[k] = inventory[i];
//                        k++;
//                    }
//                    inventory = arr3;
//                    foreach (Item item in inventory)
//                    {
//                        Console.WriteLine(item.Value);
//                    }
//                        break;
//            }
        
//        }
//        public Item Search(int a)
//        {
//            Console.WriteLine("1-Search by level\n2-Search by value");
//            int choice = Convert.ToInt32(Console.ReadLine());
//            Item res=null;
//            switch(choice)
//            {
//                case 1:
//                    foreach(Item item in inventory)
//                    {
//                        if (item.Level == a)
//                        {
//                            res = item;
//                        }
//                    }
//                    break;
//                case 2:
//                    foreach (Item item in inventory)
//                    {
//                        if (item.Value == a)
//                        {
//                            res = item;
//                        }
//                    }
//                    break;
//            }
//            return res;
//        }
//    }
//}
