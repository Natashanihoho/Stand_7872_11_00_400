using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Stand_7872_11_00_400
{
    [Serializable]
    public class Grid
    {
        [XmlElement("GRID")]
        public short Speed { get; set; }

        public byte Bright { get; set; }

        public byte Direct { get; set; }

        public bool isStarted { get; set; }

        public bool isHeated { get; set; }

        public Grid()
        {

        }
        public Grid(short speed, byte direct, byte bright, bool isStarted, bool isHeated)
        {
            Speed = speed;
            Direct = direct;
            Bright = bright;            
            this.isStarted = isStarted;
            this.isHeated = isHeated;
        }
    }
}
