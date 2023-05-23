using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace prKol_ind2_4_FI
{
    class Disk
    {
        Track track = new Track();
        Hashtable list_of_tracks = new Hashtable();
        string name_of_disk;
        int key = 0;
        public void showTracks()
        {
            ICollection values = list_of_tracks.Values;
           foreach(string s in values )
            {
                Console.WriteLine(s);
            }
        }
        public void addDisk(Hashtable disk)
        {
                int count_of_tracks = checkNumber();
                Console.WriteLine("Введите назвение диска");
                name_of_disk = Console.ReadLine();
                for(int i = 0; i < count_of_tracks; i++)
                {
                    track.addTrack();
                    list_of_tracks.Add(key,disk);
                    key++;
                }
            
        }
        public int checkNumber()
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Укажите количество треков на диске");
                    int number = int.Parse(Console.ReadLine());
                    if (number <= 0 || number > 200)
                    {
                        Console.WriteLine("Количество треков на диске должно быть больше 0 и меньше 200");
                    }
                    else
                        return number;
                }
                catch
                {
                    Console.WriteLine("Вы ввели не число");
                }
            }
            
        }
        public string getName ()
        {
            return name_of_disk;
        }
    }
}
