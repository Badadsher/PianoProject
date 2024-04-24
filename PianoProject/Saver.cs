using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PianoProject
{
    public class Saver
    {
        public static int SaveLog { get; set; }


        public void Update(int number)
        {
            SaveLog = number;
        }

    }
}
