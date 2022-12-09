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
        private string PortStatus = "DIS";
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
                this.connected();
                return "OK";

            }
            catch (Exception ex)
            {
                this.fail();
                return ex.ToString();   
            }
        }

        public int StopSerial() {
            if (MainPort.IsOpen)
            {
                this.ResetBuffer();
                MainPort.Close();
                this.disconnected();
                return 0;          
            }
            else
            {
                this.fail();
                return 1;   
            }
        }

        public void SendData(string data)
        {
            if (MainPort.IsOpen)
            {
                this.TX();
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

        public void ResetBuffer()
        {
            MainPort.DiscardInBuffer();
        }
        public string ReceiveData()
        {
            try
            {
                receivedData = MainPort.ReadExisting();
                MainPort.DiscardInBuffer();
                this.RX();
                return receivedData;
            }
            catch(Exception ex)
            {
                this.fail();
                return ex.ToString();
            }
        }

        private void TX()
        {
            PortStatus = "TX";
        }

        private void RX()
        {
            PortStatus = "RX";
        }

        private void connected()
        {
            PortStatus = "CON";
        }

        private void disconnected()
        {
            PortStatus = "DIS";
        }

        private void fail()
        {
            PortStatus = "F";
        }

        public string GetStatus()
        {
            return PortStatus;
        }
    }
}
