using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace prKol_ind2_4_FI
{
    class Program
    {
        static Disk disks = new Disk();
        static Hashtable list_of_disks = new Hashtable();
        static void Main(string[] args)
        {
            disks.addDisk(list_of_disks);
            list_of_disks.Add(disks.getName( ), disks);
            foreach(Disk i in list_of_disks)
            {
                i.showTracks();
            }
            Console.ReadKey();
        }
    }
}
