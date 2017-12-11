using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1
{
    class Game : CrntProgress
    {
        public void Enter()
        {
            string fullPath = filePath + "\\" + "Adventurer.txt";
            var charecter = new CrntProgress();
            string[] alllines = File.ReadAllLines(fullPath);
            alllines[2 - 1] = Convert.ToString(charecter.Health);
            alllines[3 - 1] = Convert.ToString(charecter.Stamina);
            Console.WriteLine(charecter.Stamina);


            Console.ReadLine();
        }
    }
}
