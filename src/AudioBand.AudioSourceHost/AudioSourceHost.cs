using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AudioBand.AudioSourceHost
{
    class AudioSourceHost
    {
        static void Main(string[] args)
        {
            if (args.Length < 1)
            {
                Environment.Exit(1);
            }
        }
    }
}
