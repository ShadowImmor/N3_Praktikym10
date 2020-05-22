using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_1_к
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\temp";
            DirectoryInfo dir = new DirectoryInfo(path);
            try
            {
                if (!dir.Exists)
                {
                    dir.Create();
                }
                dir.CreateSubdirectory("K1");
                dir.CreateSubdirectory("K2");
            }
            catch(Exception ex)
            {
                Console.WriteLine("Ошибка: " + ex.Message);
                Console.ReadLine();
                return;
            }
            StreamWriter sw = new StreamWriter(path+"\\K1"+ "\\t1.txt", true);
            sw.WriteLine("Иванов Иван Иванович, 1965 года рождения, место жительства г. Саратов");
            sw.Close();
            sw = new StreamWriter(path + "\\K1" + "\\t2.txt");
            sw.WriteLine("Петров Сергей Федорович, 1966 года рождения, место жительства г.Энгельс");
            sw.Close();
            sw = new StreamWriter(path + "\\K2" + "\\t3.txt");
            StreamReader sr = new StreamReader(path + "\\K1" + "\\t1.txt");
            sw.WriteLine(sr.ReadToEnd());
            sr.Close();
            sr = new StreamReader(path + "\\K1" + "\\t2.txt");
            sw.WriteLine(sr.ReadToEnd());
            sr.Close();
            sw.Close();
            Console.WriteLine("Информация о созданных папках:");
            FileInfo fi = new FileInfo(path + "\\K1" + "\\t1.txt");
            Console.WriteLine(" 1)Время создания - " + fi.CreationTime.ToString());
            Console.WriteLine(" Путь до каталога- " + fi.DirectoryName);
            Console.WriteLine(" Расширение - " + fi.Extension);
            Console.WriteLine(" Полный путь - " + fi.FullName);
            Console.WriteLine(" Последная данта записи в файл - " + fi.LastWriteTime.ToString());
            Console.WriteLine(" Размер файла - " + (fi.Length / 1024).ToString() + "KB");
            fi = new FileInfo(path + "\\K1" + "\\t2.txt");
            Console.WriteLine(" 2)Время создания - " + fi.CreationTime.ToString());
            Console.WriteLine(" Путь до каталога - " + fi.DirectoryName);
            Console.WriteLine(" Расширение - " + fi.Extension);
            Console.WriteLine(" Полный путь - " + fi.FullName);
            Console.WriteLine(" Последная данта записи в файл - " + fi.LastWriteTime.ToString());
            Console.WriteLine(" Размер файла - " + (fi.Length / 1024).ToString() + "KB");
            fi = new FileInfo(path + "\\K2" + "\\t3.txt");
            Console.WriteLine(" 3)Время создания - " + fi.CreationTime.ToString());
            Console.WriteLine(" Путь до каталога - " + fi.DirectoryName);
            Console.WriteLine(" Расширение - " + fi.Extension);
            Console.WriteLine(" Полный путь - " + fi.FullName);
            Console.WriteLine(" Последная данта записи в файл - " + fi.LastWriteTime.ToString());
            Console.WriteLine(" Размер файла - " + (fi.Length / 1024).ToString() + "KB");
            if (File.Exists(path + "\\K2" + "\\t2.txt"))
                File.Delete(path + "\\K2" + "\\t2.txt");
            File.Move(path + "\\K1" + "\\t2.txt", path + "\\K2" + "\\t2.txt");
            if (File.Exists(path + "\\K2" + "\\t1.txt"))
                File.Delete(path + "\\K2" + "\\t1.txt");
            File.Copy(path + "\\K1" + "\\t1.txt", path + "\\K2" + "\\t1.txt");
            dir = new DirectoryInfo(path + "\\K2");
            if (Directory.Exists(path + "\\ALL"))
                Directory.Delete(path + "\\ALL",true);
            dir.MoveTo(path + "\\ALL");
            dir = new DirectoryInfo(path + "\\K1");
            dir.Delete(true);
            dir = new DirectoryInfo(path + "\\ALL");
            FileInfo[] allFile = dir.GetFiles();
            Console.WriteLine("\n" + @"Файлы в каталоге C:\temp\ALL");
            foreach (FileInfo fileinfo in allFile)
            {
                Console.WriteLine("Время создания - " + fileinfo.CreationTime.ToString());
                Console.WriteLine("Путь до каталога- " + fileinfo.DirectoryName);
                Console.WriteLine("Расширение - " + fileinfo.Extension);
                Console.WriteLine("Полный путь - " + fileinfo.FullName);
                Console.WriteLine("Последная данта записи в файл - " + fileinfo.LastWriteTime.ToString());
                Console.WriteLine("Размер файла - " + (fileinfo.Length / 1024).ToString() + "KB");
                Console.WriteLine("-------------------------------------------------");
            }
            Console.ReadLine();
        }
    }
}
