using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1
{
    class CrntProgress
    {
        public string filePath = Directory.GetCurrentDirectory();
        public int Health { get; set; }
        public int Stamina { get; set; }
        public int Hunger { get; set; }
        public int CrntChptr { get; set; }
        public int ChrctrClass { get; set; }

        public void Save()
        {



        }
    }
}
