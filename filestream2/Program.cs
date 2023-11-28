using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace filestream2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ЧТЕНИЕ
            using (FileStream k = new FileStream("C:\\Users\\Пользователь\\Desktop\\filestream\\myfile.txt", FileMode.OpenOrCreate, FileAccess.Read))
            {
                if (k.Length == 0)
                {

                    Console.WriteLine("ПУстой"); 
                }
                else {
                // преобразуем строки в байт
                byte[] a = new byte[k.Length];
                // считываем данные
                k.Read(a, 0, a.Length);
                //декодируем байты в строку
                string text = Encoding.Default.GetString(a);
                Console.WriteLine($"Текст из файла: \n{text}");
                }
            }
            Console.ReadKey();
        }
    }
}
