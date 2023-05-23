using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prKol_ind2_4_FI
{
    class Track
    {
        string artist;
        string name_of_track;
        public void addTrack()
        {
            bool track_added = false;
            while (track_added == false)
            {
                Console.WriteLine("Введите исполнителя");
                artist = Console.ReadLine();
                Console.WriteLine("Введите название трека");
                name_of_track = Console.ReadLine();
                if (checkNames(artist, "артист") && checkNames(name_of_track, "название трека"))
                    track_added = true;                
            }
        }
        public bool checkNames(string name,string field)
        {
            if (name.Length == 0)
            {
                Console.WriteLine($"Поле {field} пустое");
                return false;
            }
            return true;
        }
    }
}
