using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Runtime.InteropServices;

namespace LogToplayıcı.Is_Katmani
{
    class Data
    {
        public string IPAddress { get; set; }
        public string Message { get; set; }
        public string StationName { get; set; }
    }

    public class Syslog
    {
        int syslogPort = 514;

        public Dictionary<string, string> IpStationPairs = new Dictionary<string, string>()
            {
                // PLC Devices
                {"192.168.45.1", "Atık Su Terfi 1-FW" },
                {"192.168.45.110", "Atık Su Terfi 1-PLC" },
                {"192.168.45.120", "Atık Su Terfi 1-SW" },
                {"192.168.45.130", "Atık Su Terfi 1-HMI" },

                {"192.168.45.2", "Atık Su Terfi 2-FW" },
                {"192.168.45.111", "Atık Su Terfi 2-PLC" },
                {"192.168.45.121", "Atık Su Terfi 2-SW" },
                {"192.168.45.131", "Atık Su Terfi 2-HMI" },

                {"192.168.45.3", "Atık Su Arıtma-FW" },
                {"192.168.45.112", "Atık Su Artırma-PLC" },
                {"192.168.45.122", "Atık Arıtma-SW" },
                {"192.168.45.132", "Atık Su Arıtma-HMI" },

                // RTU Devices
                {"192.168.45.4", "İçme Suyu-Arıtma" },
                {"192.168.45.5", "İçme Suyu-Terfi 1" },
                {"192.168.45.6", "İçme Suyu-Terfi 2" },
                {"192.168.45.7", "İçme Suyu-Depo"},
            };
        
        public void SyslogCollector(string IPAddr)
        {            
            IPEndPoint anyIP = new IPEndPoint(IPAddress.Parse(IPAddr), syslogPort);
            UdpClient udpListener = new UdpClient(syslogPort);
            byte[] bReceive; string sReceive; string sourceIP;
            
            try
            {
                Console.WriteLine(anyIP.Address.ToString());
                bReceive = udpListener.Receive(ref anyIP);                    
                sReceive = Encoding.ASCII.GetString(bReceive);                    
                sourceIP = anyIP.Address.ToString();
                Console.WriteLine(sReceive);
                var dataJsonx = new Data { IPAddress = sourceIP, Message = sReceive, StationName = IpStationPairs[sourceIP] };                
                string jsonData = JsonConvert.SerializeObject(dataJsonx);
                System.IO.File.AppendAllText(@"C:\Users\Log Sunucu\Desktop\syslog100.json", jsonData);                    
            }
            catch (Exception ex) { Console.WriteLine(ex.ToString()); }
            udpListener.Close();
        }
        
    }
}
