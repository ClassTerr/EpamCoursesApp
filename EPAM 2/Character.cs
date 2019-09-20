using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EPAM_2
{
    class Character: ISpeaker
    {
        public string Name { get; set; }
        public string Speech { get; set; }

        void ISpeaker.Say()
        {
            Console.WriteLine(Speech);
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
