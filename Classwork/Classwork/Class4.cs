using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Classwork
{
    internal class Class4
    {
        public static void Main()
        {
            FileInfo fileInfo = new FileInfo(@"C:\Test\1.txt");
            WriteFile(fileInfo, "Winter adcdv\ndsdsfdf\neeewewfe\nHgghhg\njjjhbj");
            string res=ToUpperCase(fileInfo);
            WriteFile(fileInfo,res);
            Console.WriteLine(res);
            
        }
        private static void WriteFile(FileInfo fileInfo, string text)
        {
            using(FileStream fs=fileInfo.OpenWrite())
            {
                byte[] buffer =Encoding.UTF8.GetBytes(text);
                fs.Write(buffer, 0, buffer.Length);
            }
        }
        private static string ToUpperCase(FileInfo fileInfo)
        {
            string res = ReadFile(fileInfo);
            string res2 = new string();
            for(int i = 0; i < res.Length; i++)
            {
                if (res[i]=='\n')
                {
                     =char.ToUpper(res[i + 1]);

                    //Convert.ToChar(res[i + 1]);
                }
            }
            return res;
        }
        private static string ReadFile(FileInfo fileInfo)
        {
            string text = String.Empty;

            using (FileStream fs = fileInfo.OpenRead())
            {
                byte[] buffer = new byte[fs.Length];
                int bytesRead=fs.Read(buffer, 0, buffer.Length);
                text=Encoding.UTF8.GetString(buffer);   
            }
            return text;
        }
    }
















    class Film :IDisposable
    {
        public string Name { get; set; }
        public string Studio { get; set; }
        public string Ganre { get; set; }
        public int Duration { get; set; }
        public int PublishYear { get; set; }

        public Film(string n,string s,string g,int d,int p)
        {
            Name = n;
            Studio=s;
            Ganre=g;
            Duration = d;
            PublishYear = p;
            Console.WriteLine("created");
            Dispose();
        }
        public void Dispose()
        {
            Console.WriteLine( "Disposed");
        }
    }
}
