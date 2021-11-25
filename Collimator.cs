using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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

        public bool IsFoundOpt { get; set; }

        public Grid Grid1 { get; set; }
        public Grid Grid2 { get; set; }
        public Collimator(byte id, string name, string port, bool isFoundOpt, Grid grid1, Grid grid2)
        {
            ID = id;
            Name = name;
            Port = port;
            Type = (byte)(ID % 2);
            IsFoundOpt = isFoundOpt;
            Grid1 = grid1;
            Grid2 = grid2;            
        }

        
        public Collimator()
        {

        }

        public string getInfo()
        {
            string info = "---КОЛЛИМАТОР---" + "ID: " + ID.ToString("X") + "  НАЗВ.: " + Name;
            info += "\n     Сетка 1---" + "Скорость: " + Grid1.Speed + "       Яркость: " + Grid1.Bright + "\n                      Ст.двиг.: " + Grid1.isStarted + "    Вкл.подсв.: " + Grid1.isHeated;
            if (Grid2 != null) info += "\n     Сетка 2---" + "Скорость: " + Grid2.Speed + "       Яркость: " + Grid2.Bright + "\n                      Ст.двиг.: " + Grid2.isStarted + "    Вкл.подсв.: " + Grid2.isHeated + "\n\n";
            else info += "\n\n";
            return info;
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
