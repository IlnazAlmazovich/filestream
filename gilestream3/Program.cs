using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace gilestream3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Дан файл целых чисел. Создать новый файл, содержащий те же эле-менты, что и исходный файл, но в обратном порядке
            // Указываем путь к исходному файлу и файлу для записи обратного порядка
            string inputFile = "C:\\Users\\Пользователь\\Desktop\\filestream\\input.txt";
            string outputFile = "C:\\Users\\Пользователь\\Desktop\\filestream\\output.txt";

            // Создаем FileStream для чтения исходного файла
            using (FileStream inFile = new FileStream(inputFile, FileMode.OpenOrCreate))
            {
                // Создаем FileStream для записи в новый файл
                using (FileStream outFile = new FileStream(outputFile, FileMode.OpenOrCreate))
                {
                    // Создаем буфер для чтения и записи данных
                    byte[] buffer = new byte[1024];
                    int bytesRead;

                    // Читаем данные из исходного файла и записываем в новый файл в обратном порядке
                    while ((bytesRead = inFile.Read(buffer, 0, buffer.Length)) > 0)
                    {
                        for (int i = 0; i < bytesRead / 2; i++)
                        {
                            byte temp = buffer[i];
                            buffer[i] = buffer[bytesRead - i - 1];
                            buffer[bytesRead - i - 1] = temp;
                        }

                        outFile.Write(buffer, 0, bytesRead);
                    }
                }
            }

            Console.WriteLine("Файл успешно записан в обратном порядке.");
            Console.ReadKey();
        }
    }
}
