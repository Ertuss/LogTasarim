using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using SnmpSharpNet;
using Oid = SnmpSharpNet.Oid;
using System.Runtime;
using System.Collections;
using System.Net.Sockets;

namespace LogToplayıcı.Is_Katmani
{
   
    public class SnmpClient
     {
        public static void SnmpV2Packet()
        {
            SnmpV2Packet packet = new SnmpV2Packet();
            // Set the community name
            packet.Community.Set("public");
            // Set the Pdu type
            packet.Pdu.Type = PduType.Get;
            // Set request id
            packet.Pdu.RequestId = 100;
            // Add an Oid for the SNMP-Get operation
            packet.Pdu.VbList.Add(".1.3.6.1.2.1.1.1.0");
            byte[] outBuffer = packet.encode();

            Socket soc = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            string server = null;
            
            System.Net.IPAddress ipAdd = System.Net.IPAddress.Parse(server);
            System.Net.IPEndPoint remoteEP = new IPEndPoint(ipAdd, 3456);
            soc.Connect(remoteEP);
            soc.Send(outBuffer);
        }

        #region SNMP Beckhoff PLC'ler
        public void SnmpVeriGetir(string host,string community)

        {
            //string host = "192.168.226.132";
            //string community = "public";
            SimpleSnmp snmp = new SimpleSnmp(host, community);
            if (!snmp.Valid)
            {
                Console.WriteLine("SNMP agent host name/ip address is invalid.");
                return;
            }
            //rfc1213 snmp oid
            Dictionary<Oid, AsnType> result = snmp.Get(SnmpVersion.Ver1,new string[] { "1.3.6.1.2.1.1.1.0", "1.3.6.1.2.1.1.2.0", "1.3.6.1.2.1.1.3.0", "1.3.6.1.2.1.1.4.0", "1.3.6.1.2.1.1.5.0", "1.3.6.1.2.1.1.6.0", "1.3.6.1.2.1.1.7.0",
            "1.3.6.1.2.1.2.1.0","1.3.6.1.2.1.2.2.1.1.1","1.3.6.1.2.1.2.2.1.2.1","1.3.6.1.2.1.2.2.1.3.1","1.3.6.1.2.1.2.2.1.4.1","1.3.6.1.2.1.2.2.1.5.1","1.3.6.1.2.1.2.2.1.6.1","1.3.6.1.2.1.2.2.1.7.1","1.3.6.1.2.1.2.2.1.8.1","1.3.6.1.2.1.2.2.1.9.1",
            "1.3.6.1.2.1.2.2.1.10.1","1.3.6.1.2.1.2.2.1.11.1","1.3.6.1.2.1.2.2.1.12.1","1.3.6.1.2.1.2.2.1.14.1","1.3.6.1.2.1.2.2.1.15.1","1.3.6.1.2.1.2.2.1.16.1","1.3.6.1.2.1.2.2.1.17.1","1.3.6.1.2.1.2.2.1.18.1","1.3.6.1.2.1.2.2.1.19.1","1.3.6.1.2.1.2.2.1.20.1",
            "1.3.6.1.2.1.4.1.0","1.3.6.1.2.1.4.2.0","1.3.6.1.2.1.4.3.0","1.3.6.1.2.1.4.4.0","1.3.6.1.2.1.4.5.0","1.3.6.1.2.1.4.6.0","1.3.6.1.2.1.4.7.0","1.3.6.1.2.1.4.8.0","1.3.6.1.2.1.4.9.0","1.3.6.1.2.1.4.10.0","1.3.6.1.2.1.4.11.0","1.3.6.1.2.1.4.12.0","1.3.6.1.2.1.4.13.0","1.3.6.1.2.1.4.14.0",
            "1.3.6.1.2.1.4.15.0","1.3.6.1.2.1.4.16.0","1.3.6.1.2.1.4.17.0","1.3.6.1.2.1.4.18.0","1.3.6.1.2.1.4.19.0","1.3.6.1.2.1.5.1.0","1.3.6.1.2.1.5.2.0","1.3.6.1.2.1.5.3.0","1.3.6.1.2.1.5.4.0","1.3.6.1.2.1.5.5.0","1.3.6.1.2.1.5.6.0","1.3.6.1.2.1.5.7.0","1.3.6.1.2.1.5.8.0","1.3.6.1.2.1.5.9.0",
            "1.3.6.1.2.1.5.10.0","1.3.6.1.2.1.5.11.0","1.3.6.1.2.1.5.12.0","1.3.6.1.2.1.5.13.0","1.3.6.1.2.1.5.14.0","1.3.6.1.2.1.5.15.0","1.3.6.1.2.1.5.16.0","1.3.6.1.2.1.5.17.0","1.3.6.1.2.1.5.18.0","1.3.6.1.2.1.5.19.0","1.3.6.1.2.1.5.20.0","1.3.6.1.2.1.5.21.0","1.3.6.1.2.1.5.22.0","1.3.6.1.2.1.5.23.0",
            "1.3.6.1.2.1.5.24.0","1.3.6.1.2.1.5.25.0","1.3.6.1.2.1.6.1.0","1.3.6.1.2.1.6.2.0","1.3.6.1.2.1.6.3.0","1.3.6.1.2.1.6.4.0","1.3.6.1.2.1.6.5.0","1.3.6.1.2.1.6.6.0","1.3.6.1.2.1.6.7.0","1.3.6.1.2.1.6.8.0","1.3.6.1.2.1.6.9.0","1.3.6.1.2.1.6.10.0","1.3.6.1.2.1.6.11.0","1.3.6.1.2.1.6.12.0",
            "1.3.6.1.2.1.7.1.0","1.3.6.1.2.1.7.2.0","1.3.6.1.2.1.7.3.0","1.3.6.1.2.1.7.4.0"


            });
            if (result == null)
            {
                Console.WriteLine("No results received.");
                return;
            }
            foreach (KeyValuePair<Oid, AsnType> kvp in result)
            {
                Console.WriteLine("{0}: {1} {2}", kvp.Key.ToString(),
                                      SnmpConstants.GetTypeName(kvp.Value.Type),
                                      kvp.Value.ToString());
            }

        }
        #endregion


    }
}
