using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Filmi11a
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Kolko filma shte vkarash");
                int input = int.Parse(Console.ReadLine());
                StreamWriter writer = new StreamWriter("Filmi.txt");

                List<Filmi> filmsData = new List<Filmi>();

                for (int i = 0; i < input; i++)
                {
                    Console.WriteLine("Enter films data: (To enter data you need :Name,Price,DurationDay,Town,CinemaName,StartDay) ");

                    string[] data = Console.ReadLine().Split();
                    Filmi films = new Filmi(data[0], double.Parse(data[1]), int.Parse(data[2]), data[3], data[4], data[5]);
                    filmsData.Add(films);

                    using (writer)
                    {
                        writer.WriteLine(data[0]);
                        writer.WriteLine(data[1]);
                        writer.WriteLine(data[2]);
                        writer.WriteLine(data[3]);
                        writer.WriteLine(data[4]);
                        writer.WriteLine(data[5]);
                    }
                }

                ICompareFilmNames comparer = new ICompareFilmNames();
                filmsData.Sort(comparer);
                filmsData.ForEach(x => x.Print());

                Console.Write("Enter a film name to check if it is in the list: ");
                string filmName = Console.ReadLine();
                if (filmsData.Select(x => x.Name).Contains(filmName))
                {
                    Console.WriteLine("The film is in the list!");
                }
                else
                {
                    Console.WriteLine("The film is not in the list!");
                }

                var biggestDuration = filmsData.Select(x => x.DurationDay).Max();

                Console.WriteLine($"Film with the biggest duration {biggestDuration} hours!");


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            
        }
    }
}
