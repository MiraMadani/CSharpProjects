//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CSharpHomework2
//{
//    internal class Hw5
//    {
//        static void Main()
//        {
//            //Main Task Описать класс «Домашняя библиотека». Предусмотреть
//            //возможность работы с произвольным числом книг, поиска книги по
//            //какому-либо признаку (например, по автору или по году издания),
//            //добавления книг в библиотеку, удаления книг из нее, сортировки
//            //книг по разным полям.
//            Book book1 = new Book("Kobsar",1820, "Taras Shevchenko");
//            Book book2 = new Book("1984", 1948, "Joarge Orwell");
//            Book book3 = new Book("Romeo an Juliet", 1600, "William Shakespear");

//            Book[] arr = {book1,book2, book3};
//            HomeLibrary library = new HomeLibrary(arr);

//            library.Show();
//            library.AddBook(new Book("Book", 1000, "Mira"));
//            library.Show();

//            Console.WriteLine();
//            library.SortByYear();
//            library.Show();

//            library.SearchByTitle("1984");
            
//        }
//        class HomeLibrary
//        {
//            public Book[] Arr;

//            public HomeLibrary(Book[] arr)
//            {
//                Arr = arr;
//            }
//            public void SortByAutor()
//            {
//                var n=Arr.Length;
//                for(int i = 0; i < n - 1; i++)
//                {
//                    for(int j = 0; j < n - i - 1; j++)
//                    {
//                        if (Arr[i].Autor.CompareTo(Arr[j + 1].Autor) < 1)
//                        {
//                            (Arr[j], Arr[j + 1]) = (Arr[j+1], Arr[j]);
//                        }
//                    }
//                }

//            }
//            public void SortByTitle()
//            {
//                var n = Arr.Length;
//                for (int i = 0; i < n - 1; i++)
//                {
//                    for (int j = 0; j < n - i - 1; j++)
//                    {
//                        if (Arr[i].Title.CompareTo(Arr[j + 1].Title) < 1)
//                        {
//                            (Arr[j], Arr[j + 1]) = (Arr[j + 1], Arr[j]);
//                        }
//                    }
//                }
//            }
//            public void SortByYear()
//            {
//                var n = Arr.Length;
//                for (int i = 0; i < n - 1; i++)
//                {
//                    for (int j = 0; j < n - i - 1; j++)
//                    {
//                        if (Arr[i].PublishYear.CompareTo(Arr[j + 1].PublishYear) < 1)
//                        {
//                            (Arr[j], Arr[j + 1]) = (Arr[j + 1], Arr[j]);
//                        }
//                    }
//                }
//            }
//            public void SearchByAutor(string a)
//            {
//                foreach (var item in Arr)
//                {
//                    if (item.Autor==a)
//                    {
//                        item.Info();
//                    }
//                }
//            }
//            public void SearchByTitle(string a)
//            {
//                foreach (var item in Arr)
//                {
//                    if (item.Title == a)
//                    {
//                        item.Info();
//                    }
//                }
//            }
//            public void SearchByYear(int a)
//            {
//                foreach (var item in Arr)
//                {
//                    if (item.PublishYear == a)
//                    {
//                        item.Info();
//                    }
//                }
//            }
//            public void AddBook(Book a)
//            {
//                Book[] arr2 = new Book[Arr.Length + 1];

//                for (int i = 0; i < Arr.Length; i++)
//                {
//                    arr2[i] = Arr[i];
                   
//                }
//                arr2[Arr.Length] = a;
//                Arr = arr2;
//            }
//            public void DeleteBook(Book a)
//            {
//                Book[] arr2= new Book[Arr.Length-1];
               
//                for(int i = 0,k=0; i < Arr.Length; i++)
//                {
//                    if (a.Title == Arr[i].Title)
//                    {
//                        continue;
//                    }
//                    else
//                    {
//                        arr2[k] = Arr[i];
//                        k++;
//                    }
//                }
//                Arr= arr2;
//            }
//            public void Show()
//            {
//                foreach (var item in Arr)
//                {
//                    item.Info();
//                }

//            }

//        }
//        class Book
//        {
//            public string Title;
//            public int PublishYear;
//            public string Autor;

//            public Book(string a, int b, string c)
//            {
//                Title = a;
//                PublishYear = b;
//                Autor = c;
//            }
//            public void Info()
//            {
//                Console.WriteLine(Title +" "+Autor+" "+PublishYear);
//            }
//        }
//    }
//}
