using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Задание_1_г
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void DoProgramm_Click(object sender, EventArgs e)
        {
            Exlabel.Visible = false;
            InfoFiles.Clear();
            InfoFileDirectory.Clear();
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
            catch (Exception ex)
            {
                Exlabel.Text = "Ошибка: " + ex.Message;
                Exlabel.Visible = true;
                return;
            }
            StreamWriter sw = new StreamWriter(path + "\\K1" + "\\t1.txt", true);
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
            FileInfo fi = new FileInfo(path + "\\K1" + "\\t1.txt");
            InfoFiles.Text += " 1)Время создания - " + fi.CreationTime.ToString() + "\nПуть до каталога- " + fi.DirectoryName + 
                "\nРасширение - " + fi.Extension + "\n Полный путь - " + fi.FullName +
                "\nПоследная данта записи в файл - " + fi.LastWriteTime.ToString() + "\nРазмер файла - " + (fi.Length / 1024).ToString() + "KB\n";
            fi = new FileInfo(path + "\\K1" + "\\t2.txt");
            InfoFiles.Text += " 2)Время создания - " + fi.CreationTime.ToString() + "\nПуть до каталога- " + fi.DirectoryName +
                "\nРасширение - " + fi.Extension + "\nПолный путь - " + fi.FullName +
                "\nПоследная данта записи в файл - " + fi.LastWriteTime.ToString() + "\nРазмер файла - " + (fi.Length / 1024).ToString() + "KB\n";
            fi = new FileInfo(path + "\\K2" + "\\t3.txt");
            InfoFiles.Text += " 3)Время создания - " + fi.CreationTime.ToString() + "\nПуть до каталога- " + fi.DirectoryName +
                "\nРасширение - " + fi.Extension + "\nПолный путь - " + fi.FullName +
                "\nПоследная данта записи в файл - " + fi.LastWriteTime.ToString() + "\nРазмер файла - " + (fi.Length / 1024).ToString() + "KB\n";
            if (File.Exists(path + "\\K2" + "\\t2.txt"))
                File.Delete(path + "\\K2" + "\\t2.txt");
            File.Move(path + "\\K1" + "\\t2.txt", path + "\\K2" + "\\t2.txt");
            if (File.Exists(path + "\\K2" + "\\t1.txt"))
                File.Delete(path + "\\K2" + "\\t1.txt");
            File.Copy(path + "\\K1" + "\\t1.txt", path + "\\K2" + "\\t1.txt");
            dir = new DirectoryInfo(path + "\\K2");
            if (Directory.Exists(path + "\\ALL"))
                Directory.Delete(path + "\\ALL", true);
            dir.MoveTo(path + "\\ALL");
            dir = new DirectoryInfo(path + "\\K1");
            dir.Delete(true);
            dir = new DirectoryInfo(path + "\\ALL");
            FileInfo[] allFile = dir.GetFiles();
            foreach (FileInfo fileinfo in allFile)
            {
                InfoFileDirectory.Text += "Время создания - " + fileinfo.CreationTime.ToString() + "\nПуть до каталога- " + fileinfo.DirectoryName +
                    "\nРасширение - " + fileinfo.Extension + "\nПолный путь - " + fileinfo.FullName +
                    "\nПоследная данта записи в файл - " + fileinfo.LastWriteTime.ToString() +
                    "\nРазмер файла - " + (fileinfo.Length / 1024).ToString() + "KB" +
                    "\n-------------------------------------------------\n";
            }
        }
    }
}
