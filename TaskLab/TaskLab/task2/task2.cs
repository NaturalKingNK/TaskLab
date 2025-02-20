using System;
using System.IO;

namespace TaskLab
{
    public class Task2
    {
        public static void Main2()
        {
            

            string file1Path = @"C:\circle.txt";  // Путь к файлу с данными окружности
            string file2Path = @"C:\points.txt";  // Путь к файлу с точками

            try
            {
                // Читаем первый файл с координатами и радиусом окружности
                string[] file1Lines = File.ReadAllLines(file1Path);
                string[] centerCoordinates = file1Lines[0].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                float centerX = float.Parse(centerCoordinates[0]);
                float centerY = float.Parse(centerCoordinates[1]);
                float radius = float.Parse(file1Lines[1]);

                // Читаем второй файл с координатами точек
                foreach (string line in File.ReadLines(file2Path))
                {
                    string[] pointCoordinates = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    float pointX = float.Parse(pointCoordinates[0]);
                    float pointY = float.Parse(pointCoordinates[1]);

                    // Вычисляем расстояние от точки до центра окружности
                    float deltaX = pointX - centerX;
                    float deltaY = pointY - centerY;
                    double distance = Math.Sqrt(deltaX * deltaX + deltaY * deltaY);

                    // Сравниваем расстояние с радиусом
                    if (distance < radius)
                    {
                        Console.WriteLine("1");  // Точка внутри окружности
                    }
                    else if (distance == radius)
                    {
                        Console.WriteLine("0");  // Точка на окружности
                    }
                    else
                    {
                        Console.WriteLine("2");  // Точка снаружи окружности
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
        }
    }
}