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
        public static byte[] bufTx = new byte[15];
        public static byte[] bufRx = new byte[14];
        List<Collimator> connectedCollimators = new List<Collimator>();
        List<Collimator> readedFromXMLCollimators = new List<Collimator>();
        Collimator selectedCollimator;
        string[] ports;
       

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ports = SerialPort.GetPortNames();
            for (int i = 0; i < ports.Length; i++)
                Console.WriteLine(ports[i]);
        }

        private void buttonInit_Click(object sender, EventArgs e)
        {
            isInit = true;
            connectedCollimators.Clear();
            comboBoxCollimators.Items.Clear();

            progressBar1.Value = 0;
            labelInit.Visible = true;

            checkBoxBright1.Checked = checkBoxBright2.Checked = checkBoxMotor1.Checked = checkBoxMotor2.Checked = false;
            numericUpDownBright1.Value = numericUpDownBright2.Value = numericUpDownSpeed1.Value = numericUpDownSpeed2.Value = 0;
            textBoxPort.Text = "";
            numericUpDownBright1.Enabled = numericUpDownBright2.Enabled = numericUpDownSpeed1.Enabled = numericUpDownSpeed2.Enabled = false;
            checkBoxBright1.Enabled = checkBoxBright2.Enabled = checkBoxMotor1.Enabled = checkBoxMotor2.Enabled = false;
            buttonChangeName.Enabled = false;
            buttonStart.Enabled = false;

            for (byte i = 16; i < 65; i += 16)  
            {
                initCollimators(i);
                progressBar1.Increment(1);
                initCollimators((byte)(i + 1));
                progressBar1.Increment(1);
            }
            labelInit.Visible = false;
            buttonStartAll.Enabled = true;

            isInit = false;

            if (connectedCollimators.Count > 0)
            {
                foreach (Collimator collimator in connectedCollimators)
                {
                    comboBoxCollimators.Items.Add(collimator);
                    if (!collimator.IsFoundOpt) sendData(collimator.Port, createPacketToSend(collimator));
                }
                
                comboBoxCollimators.Enabled = true;
                buttonLoad.Enabled = true;
                buttonShowAllSettings.Enabled = true;

                comboBoxCollimators.SelectedIndex = 0;
            }
            else MessageBox.Show("Коллиматоры не обнаружены!");

            
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
                    bufTx[13] = 0;
                    bufTx[14] = calcSumXOR(bufTx, 14);
                    serialPort1.Write(bufTx, 0, 15);

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

        public byte[] createPacketToSend (Collimator collimator)
        {
            byte[] packToSend = new byte[bufTx.Length];
            packToSend[0] = Form1.STARTBYTE;
            packToSend[1] = collimator.ID;

            packToSend[2] = getFlags(collimator);
            for (byte i = 3; i < 9; i++)
                packToSend[i] = 0;

            packToSend[9] = (byte)(collimator.Grid1.Bright * 2);

            short sp1 = collimator.Grid1.Speed;
            short sp2 = 0;
            if (sp1 < 0)
            {
                sp1 = (sbyte)(sp1 * (-1));
                sp2 = 0;
            }

            if (collimator.Grid2 != null)
            {
                packToSend[10] = (byte)(collimator.Grid2.Bright * 2);
                sp2 = collimator.Grid2.Speed;
                if (sp2 < 0) sp2 = (sbyte)(sp2 * (-1));
            }

            //int speedByte = sp1 + ((sp2 << 4) & 0xF0);
            packToSend[11] = (byte)sp1;
            packToSend[12] = (byte)sp2;

            packToSend[13] =  (collimator.IsFoundOpt == true) ? (byte) 0 : (byte) 1;

            packToSend[14] = Form1.calcSumXOR(packToSend, 14);

            return packToSend;
        }

        public byte getFlags(Collimator collimator)
        {
            int bt = 0;

            if (collimator.Grid1.isStarted) bt |= 0x01;
            else bt &= ~(1 << 0);

            if (collimator.Grid1.Direct == 1) bt |= 0x02;
            else bt &= ~(1 << 1);

            if (collimator.Grid1.isHeated) bt |= 0x40;
            else bt &= ~(1 << 6);

            if(collimator.Grid2 != null)
            {
                if (collimator.Grid2.isStarted) bt |= 0x04;
                else bt &= ~(1 << 2);

                if (collimator.Grid2.Direct == 1) bt |= 0x08;
                else bt &= ~(1 << 3);

                if (collimator.Grid2.isHeated) bt |= 0x80;
                else bt &= ~(1 << 7);
            }            

            return (byte)bt;
        }
        public void sendData(string serialPort, byte[] pack)
        {
            serialPort1.PortName = serialPort;
            serialPort1.Open();
            if (serialPort1.IsOpen)
            {
                serialPort1.Write(pack, 0, pack.Length);
                Console.WriteLine("TX: " + BitConverter.ToString(pack));
                Thread.Sleep(200);
                serialPort1.Close();
            }
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
                                    bool isFoundOpt = false;
                                    if (bufRx[1] % 2 == 0)
                                    {
                                        name = "ТВ";
                                        name = name + (int)(bufRx[1] >> 4);
                                        if (((tmp >> 2) & 0x03) == 0x03) isFoundOpt = true;
                                        else isFoundOpt = false;
                                        connectedCollimators.Add(new Collimator(bufRx[1], name, serialPort1.PortName, isFoundOpt, new Grid(0, 0, 0, false, false), new Grid(0, 0, 0, false, false)));                                        

                                    }
                                    else
                                    {
                                        name = "ТПВ";
                                        name = name + (int)(bufRx[1] >> 4);
                                        if (((tmp >> 2) & 0x01) == 0x01) isFoundOpt = true;
                                        else isFoundOpt = false;
                                        connectedCollimators.Add(new Collimator(bufRx[1], name, serialPort1.PortName, isFoundOpt, new Grid(0, 0, 0, false, false), null));                                        
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
            if(readedFromXMLCollimators != null) readedFromXMLCollimators.Clear();
            readedFromXMLCollimators = DeserializeXML(fileName);

            labelFile.Text = new FileInfo(fileName).Name;
            
            foreach (Collimator readCol in readedFromXMLCollimators)
            {
                Console.WriteLine("SPEED" + readCol.Grid1.Speed);

            }               

            for(int i = 0; i < connectedCollimators.Count; i++)
            {
                for(int j = 0; j < readedFromXMLCollimators.Count; j++)
                {
                    if(connectedCollimators[i].ID == readedFromXMLCollimators[j].ID)
                    {
                        string port = connectedCollimators[i].Port;
                        connectedCollimators[i] = readedFromXMLCollimators[j];
                        connectedCollimators[i].Port = port;
                        readedFromXMLCollimators.RemoveAt(j);
                        break;
                    }
                }
            }

            comboBoxCollimators.Items.Clear();
            foreach (Collimator collimator in connectedCollimators)
            {
                comboBoxCollimators.Items.Add(collimator);
            }
            comboBoxCollimators.SelectedIndex = 0;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Text files(*.xml)|*.xml|All files(*.*)|*.*";
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = saveFileDialog1.FileName;
            Console.WriteLine(filename);
            SerializeXML(connectedCollimators, filename);
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
                try
                {
                    selectedCollimator.Grid1.Speed = (short)numericUpDownSpeed1.Value;
                }
                catch
                {
                    MessageBox.Show("Недопустимое значение!");
                    numericUpDownSpeed1.Value = 0;
                }
                
                if (selectedCollimator.Grid1.Speed >= 0) selectedCollimator.Grid1.Direct = 0;
                else selectedCollimator.Grid1.Direct = 1;
            }                             
        }

        private void numericUpDownBright1_ValueChanged(object sender, EventArgs e)
        {
            if (selectedCollimator != null)
            {
                try
                {
                    selectedCollimator.Grid1.Bright = (byte)numericUpDownBright1.Value;
                }
                catch
                {
                    MessageBox.Show("Недопустимое значение!");
                    numericUpDownBright1.Value = 0;
                }
            }           
                
            
        }
        //-----------------------------Grid 2-----------------------------------
        private void numericUpDownSpeed2_ValueChanged(object sender, EventArgs e)
        {
            if (selectedCollimator != null && selectedCollimator.Grid2 != null)
            {
                try
                {
                    selectedCollimator.Grid2.Speed = (short)numericUpDownSpeed2.Value;
                }
                catch
                {
                    MessageBox.Show("Недопустимое значение!");
                    numericUpDownSpeed2.Value = 0;
                }
                if (selectedCollimator.Grid2.Speed >= 0) selectedCollimator.Grid2.Direct = 0;
                else selectedCollimator.Grid2.Direct = 1;
            }
                
        }

        private void numericUpDownBright2_ValueChanged(object sender, EventArgs e)
        {
            if (selectedCollimator != null && selectedCollimator.Grid2 != null)
            {                
                try
                {
                    selectedCollimator.Grid2.Bright = (byte)numericUpDownBright2.Value;
                }
                catch
                {
                    MessageBox.Show("Недопустимое значение!");
                    numericUpDownBright2.Value = 0;
                }
            }
                
        }
        
       
        private void buttonStartAll_Click(object sender, EventArgs e)
        {
            foreach(Collimator collimator in connectedCollimators)
            {
                sendData(collimator.Port, createPacketToSend(collimator));
            }
            
        }

        private void comboBoxCollimators_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*string selectedName = comboBoxCollimators.SelectedItem.ToString();
            selectedCollimator = null;
            foreach (Collimator collimator in connectedCollimators)
            {
                if(selectedName.Equals(collimator.Name))
                {
                    selectedCollimator = collimator;
                    Console.WriteLine("SelectedCollimator: " + selectedCollimator);
                    
                    break;
                }
            }*/

            selectedCollimator = (Collimator)comboBoxCollimators.SelectedItem;
            Console.WriteLine("SELECTED COLLIMATOR: " + selectedCollimator);

            textBoxPort.Text = selectedCollimator.Port;

            buttonChangeName.Enabled = true;
            textBoxUserName.Enabled = false;
            buttonApplyName.Enabled = false;

            checkBoxMotor1.Enabled = true;
            checkBoxBright1.Enabled = true;

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
            else
            {
                numericUpDownSpeed2.Value = 0;
                numericUpDownBright2.Value = 0;

                checkBoxMotor2.Checked = false;
                checkBoxBright2.Checked = false;
            }

            buttonStart.Enabled = true;
            buttonStartAll.Enabled = true;

            numericUpDownSpeed1.Enabled = true;
            numericUpDownBright1.Enabled = true;

            


            if (selectedCollimator.Grid2 != null)
            {
                numericUpDownSpeed2.Enabled = true;
                numericUpDownBright2.Enabled = true;

                checkBoxMotor2.Enabled = true;
                checkBoxBright2.Enabled = true;
            }
            else
            {
                numericUpDownSpeed2.Enabled = false;
                numericUpDownBright2.Enabled = false;

                checkBoxMotor2.Enabled = false;
                checkBoxBright2.Enabled = false;
            }

            buttonSave.Enabled = true;


        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            sendData(selectedCollimator.Port, createPacketToSend(selectedCollimator));
        }
        //-------------------------Checkboxex----------------------------------
        private void checkBoxStart1Events(object sender, EventArgs e)
        {
            selectedCollimator.Grid1.isStarted = checkBoxMotor1.Checked;            
        }

        private void checkBoxBright1Events(object sender, EventArgs e)
        {           
            selectedCollimator.Grid1.isHeated = checkBoxBright1.Checked;
        }

        private void checkBoxStart2Events(object sender, EventArgs e)
        {            
            if(selectedCollimator.Grid2 != null) selectedCollimator.Grid2.isStarted = checkBoxMotor2.Checked;              
        }

        private void checkBoxBright2Events(object sender, EventArgs e)
        {
            if (selectedCollimator.Grid2 != null) selectedCollimator.Grid2.isHeated = checkBoxBright2.Checked;            
        }

        private void buttonChangeName_Click(object sender, EventArgs e)
        {            
            textBoxUserName.Enabled = true;
            buttonApplyName.Enabled = true;
            buttonChangeName.Enabled = false;
        }

        private void buttonApplyName_Click(object sender, EventArgs e)
        {
            textBoxUserName.Enabled = false;
            selectedCollimator.Name = textBoxUserName.Text;
            textBoxUserName.Clear();
            buttonApplyName.Enabled = false;
            comboBoxCollimators.Items[comboBoxCollimators.SelectedIndex] = selectedCollimator;
            buttonChangeName.Enabled = true;
        }

        private void buttonShowAllSettings_Click(object sender, EventArgs e)
        {
            StringBuilder builder = new StringBuilder();
            foreach(Collimator collimator in connectedCollimators)
            {
                builder.Append(collimator.getInfo());
            }
            
            MessageBox.Show(builder.ToString(), "Settings", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
    }
}
