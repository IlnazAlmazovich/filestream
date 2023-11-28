using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace filestream
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ЗАПИСЬ
           string text = "Теперь он пьяный по твоей вине\r\nЦарица, царица\r\nОдин лишь взгляд и лютый холод по спине\r\nОн просто не может в тебе не раствориться\r\nМальчик поплыл, мальчик попал\r\nА как он стесняется, а как он целуется\r\nМальчик поплыл, прям в центре зала\r\nПусть он танцует, пока танцуется";
            using (FileStream f = new FileStream("C:\\Users\\Пользователь\\Desktop\\filestream\\myfile.txt", FileMode.OpenOrCreate))
            {

                //преобразуем строки в байты
                byte[] buffer = System.Text.Encoding.Default.GetBytes(text); // обязвтельно нужен using System.Text;
                //запись массива байтов в файл
                f.Write(buffer, 0, buffer.Length);
                Console.WriteLine(text);
                Console.WriteLine("Текст записан");

            }
            Console.ReadKey();
        }
    }
}
