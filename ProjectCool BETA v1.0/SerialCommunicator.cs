using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;

namespace ProjectCool_BETA_v1._0
{


    public class SerialCommunicator
    {
        SerialPort MainPort = new SerialPort();
        private string[] ports;
        private string receivedData;
        public void CreateSerial() {

        }

        public string[] AvailablePorts
            {
                
                get {
                ports = SerialPort.GetPortNames(); 
                return ports; }
            }

        public string CreateSerial(int BaudRates, string port_name)
        {
            try
            {
                MainPort.PortName = port_name;
                MainPort.BaudRate = BaudRates;
                MainPort.Open();
                return "OK";

            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }

        public int StopSerial() {
            if (MainPort.IsOpen)
            {
                MainPort.Close();
                return 0;
            }
            else
                return 1;
        }

        public void SendData(string data)
        {
            if (MainPort.IsOpen)
            {
                MainPort.Write(data);
            }
        }

        public bool IncomingData()
        {
            if (MainPort.BytesToRead > 0)
            {
                return true;
            }
            else
                return false;
        }

        public string ReceiveData()
        {
            try
            {
                receivedData = MainPort.ReadExisting();
                MainPort.DiscardInBuffer();
                return receivedData;
            }
            catch(Exception ex)
            {
                return ex.ToString();
            }
            }
    }
}
