using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Technology
{
    public class SmartPhone : Computer
    {
        public bool HasCamera { get; set; } = true;
        public SmartPhone(double ram, double screenSize, string oS)
        {
            //HasCamera = hasCamera;
            
        }
        public void DropPhone()
        {
            HasCamera = false;
        }
    }
}
