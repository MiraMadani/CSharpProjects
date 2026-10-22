//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CSharpHomework2
//{
//    internal class Hw8
//    {
//        static void Main()
//        {
//            //Main Task 
//            //Построить класс квадратная матрица целых чисел. Конструктор - с параметром массив целых.Операторы
//            //1) Сложение матриц.
//            //2) Вычитание матриц.

//            //Matrix a = new Matrix(new int[,] { { 1, 2, 3 }, { 4, 5, 6 } });
//            //Matrix b = new Matrix(new int[,] { { 1, 1, 1 }, { 1, 1, 1 } });
//            //Matrix res = a + b;
//            //res.Show();


//            //1 Давайте создадим часть механики игры. Представим, у нас есть
//            //область и объект, который имеет 3 координатные точки. Всего у
//            //нас будет 2 объекта от одного класса, первый объект – игрок, второй
//            //объект – враг. Если хоть одна из трех координатных точек будут идентичны,
//            //произойдет наложение одного объекта на другой. При допущении такой ситуации,
//            //выводить сообщение о том, что одна из точек объекта – совпадает с точкой второго объекта.

//            //Object player = new Object(2, 5, 6);
//            //Object oponent = new Object(1, 5, 9);

//            //if (player == oponent)
//            //{
//            //    throw new Exception("одна из точек объекта – совпадает с точкой второго объекта");
//            //}

            
//        }
//    }



//    class Object
//    {
//        int x;
//        int y;
//        int z;

//        public Object(int x, int y, int z)
//        {
//            this.x = x;
//            this.y = y;
//            this.z = z;
//        }

//        public int getX() { return x; }
//        public int getY() { return y; }
//        public int getZ() { return z; }

//        public static bool operator ==(Object obj1, Object obj2)
//        {
//            if((obj1.getX==obj2.getX) || (obj1.getY == obj2.getY) || (obj1.getZ == obj2.getZ))
//            {
//                return true;
//            }
//            return false;
//        }
//        public static bool operator !=(Object x, Object y)
//        {
//            if (x.getX != y.getX && x.getY != y.getY && x.getZ != y.getZ)
//            {
//                return true;
//            }
//            return false; 
//        }

//    }




//    class Matrix
//    {
//        int[,] arr;
//        public Matrix(int[,] matrix)
//        {
//            this.arr = matrix;
//        }
//        public int[,] GetMatrix
//        {
//            get
//            {
//                return this.arr;
//            }

//        }
//        public void Show()
//        {
//            for (int i = 0; i < arr.GetLength(0); i++)
//            {
//                for (int j = 0; j < arr.GetLength(1); j++)
//                {
//                    Console.Write(arr[i,j]+" ");
//                }
//                Console.WriteLine();
//            }
//        }
//        public static Matrix operator +(Matrix a, Matrix b)
//        {
//            int[,] arr = new int[a.GetMatrix.GetLength(0), a.GetMatrix.GetLength(1)];
//            for(int i = 0; i < a.GetMatrix.GetLength(0); i++)
//            {
//                for(int j=0;j< a.GetMatrix.GetLength(1); j++)
//                {
//                    arr[i, j] = a.GetMatrix[i,j]+ b.GetMatrix[i, j] ;
//                }
//            }
//            return new Matrix(arr);
//        }

//        public static Matrix operator -(Matrix a, Matrix b)
//        {
//            int[,] arr = new int[a.GetMatrix.GetLength(0), a.GetMatrix.GetLength(1)];
//            for (int i = 0; i < a.GetMatrix.GetLength(0); i++)
//            {
//                for (int j = 0; j < a.GetMatrix.GetLength(1); j++)
//                {
//                    arr[i, j] = a.GetMatrix[i, j] - b.GetMatrix[i, j] ;
//                }
//            }
//            return new Matrix(arr);
//        }
//    }
//}
