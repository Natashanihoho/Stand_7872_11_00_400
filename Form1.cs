using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;
using System.IO;
using System.Xml.Serialization;

namespace Stand_7872_11_00_400
{
    public partial class Form1 : Form
    {
        public static bool isInit = false;
        public const byte STARTBYTE = 170;
        public static bool endRX = false;
        public static byte[] bufTx = new byte[14];
        public static byte[] bufRx = new byte[14];
        List<Collimator> connectedCollimators = new List<Collimator>();
        List<Collimator> readedFromXMLCollimators = new List<Collimator>();
        Collimator selectedCollimator;
        string[] ports;
        bool isFoundOpt = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ports = SerialPort.GetPortNames();
            for (int i = 0; i < ports.Length; i++)
                Console.WriteLine(ports[i]);

            //selectedCollimator = new Collimator(16, "Collimator 1", "COM8", new Grid(), null) ;
        }
        public void initCollimators(byte id)
        {
            for (int i = 0; i < ports.Length; i++)
            {
                serialPort1.PortName = ports[i];
                serialPort1.Open();

                if (serialPort1.IsOpen)
                {
                    bufTx[0] = STARTBYTE;
                    bufTx[1] = id;
                    //if (isFoundOpt == true) bufRx[12] = 0;
                    //else bufRx[12] = 1;
                    bufTx[13] = calcSumXOR(bufTx, 13);
                    serialPort1.Write(bufTx, 0, 14);

                    Console.WriteLine("Send to " + ports[i]);

                    Thread.Sleep(200);
                    Console.WriteLine("TX: " + BitConverter.ToString(bufTx));
                    serialPort1.Close();

                    if (endRX)
                    {
                        endRX = false;
                        break;
                    }
                    
                }
            }

        }
        private void buttonInit_Click(object sender, EventArgs e)
        {
            isInit = true;
            comboBoxCollimators.Items.Clear();

            string[] array;
            progressBar1.Value = 0;
            //progressBar1.Maximum = 7;
            for (byte i = 16; i < 65; i += 16)
            {
                initCollimators(i);
                progressBar1.Increment(1);
                initCollimators((byte)(i + 1));
                progressBar1.Increment(1);
            }

            array = new string[connectedCollimators.Count];
            int k = 0;
            foreach(Collimator collimator in connectedCollimators)
            {
                array[k++] = collimator.Name;
                //Console.WriteLine(connectedCollimators);
            }
            if (array.Length == 1) comboBoxCollimators.Items.Add(array[0]);
            else if (array.Length > 1) comboBoxCollimators.Items.AddRange(array);
            else MessageBox.Show("Коллиматоры не обнаружены!");

            isInit = false;            
        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            int count_bytes = 0;
            endRX = false;
            Array.Clear(bufRx, 0, bufRx.Length);
            
            while (serialPort1.BytesToRead > 0)
            {
                try
                {
                    bufRx[count_bytes] = (byte)serialPort1.ReadByte();
                    count_bytes++;

                    switch (count_bytes)
                    {
                        case 1: if (bufRx[0] != 170) count_bytes = 0; break;
                        case 14:
                            count_bytes = 0;
                            if (calcSumXOR(bufRx, 14) == 0)
                            {
                                Console.WriteLine("RX: " + BitConverter.ToString(bufRx));                                
                                endRX = true;

                                if (isInit)
                                {
                                    int tmp = bufRx[3];
                                    string name = "";
                                    if (bufRx[1] % 2 == 0)
                                    {
                                        name = "ТВ";
                                        name = name + (int)(bufRx[1] >> 4);
                                        connectedCollimators.Add(new Collimator(bufRx[1], name, serialPort1.PortName, new Grid(), new Grid()));
                                        if (((tmp >> 2) & 0x03) == 0x03) isFoundOpt = true;
                                        else isFoundOpt = false;

                                    }
                                    else
                                    {
                                        name = "ТПВ";
                                        name = name + (int)(bufRx[1] >> 4);
                                        connectedCollimators.Add(new Collimator(bufRx[1], name, serialPort1.PortName, new Grid(), null));
                                        if (((tmp >> 2) & 0x01) == 0x01) isFoundOpt = true;
                                        else isFoundOpt = false;
                                    }
                                    Console.WriteLine("IS FOUND OPTOCOUPLER: " + isFoundOpt);
                                    
                                }                   
                            }
                            break;
                    }
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }

                if (endRX == true) break;

            }
            count_bytes = 0;

        }

        public static byte calcSumXOR(byte[] bytes, byte length)
        {
            byte sum = 0;
            for (int i = 0; i < length; i++)
                sum ^= bytes[i];
            return sum;
        }
        //-------------------------------Save and Load-------------------------------
        private void buttonLoad_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Text files(*.xml)|*.xml|All files(*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string fileName = openFileDialog1.FileName;

            readedFromXMLCollimators = DeserializeXML(fileName);
            foreach (Collimator readCol in readedFromXMLCollimators)
                Console.WriteLine(readCol);
           /* for(int i = 0; i < readedFromXMLCollimators.Count; i++)
            {
                Console.WriteLine(readedFromXMLCollimators[i]);
            }*/
            //string fileText = File.ReadAllText(fileName);
            //Console.WriteLine(fileText);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Text files(*.xml)|*.xml|All files(*.*)|*.*";
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = saveFileDialog1.FileName;
            Console.WriteLine(filename);
            //connectedCollimators.Add(new Collimator(11, "Collimator 11", "COM9", new Grid(1, 0, 7, true, false), null));
           // connectedCollimators.Add(new Collimator(17, "Collimator 17", "COM10", new Grid(5, 1, 4, true, true), new Grid(4, 8, 2, true, false)));
            SerializeXML(connectedCollimators, filename);
            //File.WriteAllText(filename, fileText);
        }
        private void SerializeXML(List<Collimator> collimator, string fileName)
        {
            XmlSerializer xml = new XmlSerializer(typeof(List<Collimator>));

            using (FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate))
            {
                xml.Serialize(fs, collimator);
            }
        }

        private List<Collimator> DeserializeXML(string fileName)
        {
            XmlSerializer xml = new XmlSerializer(typeof(List<Collimator>));

            using (FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate))
            {
                return (List<Collimator>)xml.Deserialize(fs);
            }
        }
        //-----------------------------Grid 1-----------------------------------
        private void numericUpDownSpeed1_ValueChanged(object sender, EventArgs e)
        {
            if(selectedCollimator != null)
            {
                selectedCollimator.Grid1.Speed = (sbyte)numericUpDownSpeed1.Value;
                if (selectedCollimator.Grid1.Speed >= 0) selectedCollimator.Grid1.Direct = 0;
                else selectedCollimator.Grid1.Direct = 1;
            }                             
        }

        private void numericUpDownBright1_ValueChanged(object sender, EventArgs e)
        {
            if (selectedCollimator != null)            
                selectedCollimator.Grid1.Bright = (byte) numericUpDownBright1.Value;
            
        }
        //-----------------------------Grid 2-----------------------------------
        private void numericUpDownSpeed2_ValueChanged(object sender, EventArgs e)
        {
            if (selectedCollimator != null && selectedCollimator.Grid2 != null)
            {
                selectedCollimator.Grid2.Speed = (sbyte) numericUpDownSpeed2.Value;
                if (selectedCollimator.Grid2.Speed >= 0) selectedCollimator.Grid2.Direct = 0;
                else selectedCollimator.Grid2.Direct = 1;
            }
                
        }

        private void numericUpDownBright2_ValueChanged(object sender, EventArgs e)
        {
            if (selectedCollimator != null && selectedCollimator.Grid2 != null)
                selectedCollimator.Grid2.Bright = (byte) numericUpDownBright2.Value;
        }
        //-------------------------Checkboxex----------------------------------
        private void checkBoxEvents(object sender, EventArgs e)
        {
            if(selectedCollimator != null)
            {
                selectedCollimator.Grid1.isStarted = checkBoxMotor1.Checked;
                selectedCollimator.Grid1.isHeated = checkBoxBright1.Checked;

                if (selectedCollimator.Grid2 != null)
                {
                    selectedCollimator.Grid2.isStarted = checkBoxMotor2.Checked;
                    selectedCollimator.Grid2.isHeated = checkBoxBright2.Checked;
                }
            }            
        }

        private void buttonStartAll_Click(object sender, EventArgs e)
        {
            
            Console.WriteLine(selectedCollimator);
        }

        private void comboBoxCollimators_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedName = comboBoxCollimators.SelectedItem.ToString();
            foreach(Collimator collimator in connectedCollimators)
            {
                if(selectedName.Equals(collimator.Name))
                {
                    selectedCollimator = collimator;
                    Console.WriteLine("SelectedCollimator: " + selectedCollimator);
                    break;
                }
            }

            numericUpDownSpeed1.Value = selectedCollimator.Grid1.Speed;
            numericUpDownBright1.Value = selectedCollimator.Grid1.Bright;

            checkBoxMotor1.Checked = selectedCollimator.Grid1.isStarted;
            checkBoxBright1.Checked = selectedCollimator.Grid1.isHeated;

            if (selectedCollimator.Grid2 != null)
            {
                numericUpDownSpeed2.Value = selectedCollimator.Grid2.Speed;
                numericUpDownBright2.Value = selectedCollimator.Grid2.Bright;

                checkBoxMotor2.Checked = selectedCollimator.Grid2.isStarted;
                checkBoxBright2.Checked = selectedCollimator.Grid2.isHeated;
            }

            
        }
    }
}
