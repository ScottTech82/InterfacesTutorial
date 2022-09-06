using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesTutorial
{
    public class Boxer : ISpeakable  {

    
        public string Color { get; set; }
        public string AnimalType { get; set; } = "Boxer";

        public void Speak()
        {
            Console.WriteLine("Whoof");
        }

    }
}
