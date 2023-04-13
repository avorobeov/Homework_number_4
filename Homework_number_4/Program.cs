using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_number_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int picturesPerRow = 3;
            int totalPictures = 52;
            int fullRows;
            int remainingPictures;

            fullRows = totalPictures / picturesPerRow;
            remainingPictures = totalPictures % picturesPerRow;

            Console.WriteLine($"Количество полных рядов: {fullRows}\nОстаток картинок: {remainingPictures}");
            Console.ReadKey();
        }
    }
}
