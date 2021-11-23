using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Stand_7872_11_00_400
{
    [Serializable]
    public class Collimator
    {
        [XmlElement("COLLIMATOR")]
        public byte ID { get; set; }

        public string Name { get; set; }

        public string Port { get; set; }

        public byte Type { get; set; }

        public Grid Grid1 { get; set; }
        public Grid Grid2 { get; set; }
        public Collimator(byte id, string name, string port, Grid grid1, Grid grid2)
        {
            ID = id;
            Name = name;
            Port = port;
            Type = (byte)(ID % 2);
            Grid1 = grid1;
            Grid2 = grid2;
        }

        
        public Collimator()
        {

        }

        public override string ToString()
        {
            string print = "COLLIMATOR---" + "ID: {X}" + ID + "  TYPE: " + Type + "  NAME: " + Name + "  PORT: " + Port;
            print += "\n            Grid1---" + "Speed: " + Grid1.Speed + "  Direction: " + Grid1.Direct + "  Bright: " + Grid1.Bright + "  isStarted: " + Grid1.isStarted + "  isHeated: " + Grid1.isHeated;
            if (Grid2 != null) print += "\n            Grid2---" + "Speed: " + Grid2.Speed + "  Direction: " + Grid2.Direct + "  Bright: " + Grid2.Bright + "  isStarted: " + Grid2.isStarted + "  isHeated: " + Grid2.isHeated;
            return print;
        }
    }
}
