using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogToplayıcı.Is_Katmani
{
    class Beckhoff_Ethercat_Proses_OPC:RestClient
    {

        public string baseUrl_Aritma = "http://192.168.50.10:39320/iotgateway/read?ids=Beckhoff_Ethercat_PLC.CX-447958(Arıtma).MAIN.";
        public string baseUrl_Terfi1 = "http://192.168.50.10:39321/iotgateway/read?ids=Beckhoff_Ethercat_PLC.CX-447955(Terfi1).MAIN.";
        public string baseUrl_Terfi2 = "http://192.168.50.10:39322/iotgateway/read?ids=Beckhoff_Ethercat_PLC.CX-3C4E39(Terfi2).MAIN.";
        public string baseUrl_Depo = "http://192.168.50.10:39323/iotgateway/read?ids=Beckhoff_Ethercat_PLC.CX-3C4E15(Depo).MAIN.";

        public string[] aritma = { "plc_bilgisi.Bolge", "plc_bilgisi.Ad", "plc_bilgisi.Numara","seviye_bilgisi.seviye2", "seviye_bilgisi.seviye1","aritma_veri.su_seviyesi", "aritma_veri.debi2", "aritma_veri.debi","panel_start.main_start","panel_start.local_start","aritma_veri.valf", "aritma_veri.samandira", "aritma_veri.motor3", "aritma_veri.motor2","motor1" };
        public string[] terfi1 = { "plc_bilgisi.Bolge", "plc_bilgisi.Ad", "plc_bilgisi.Numara", "seviye_bilgisi.seviye2", "seviye_bilgisi.seviye1", "aritma_veri.su_seviyesi", "aritma_veri.debi2", "aritma_veri.debi","plc_pano.reserve2", "plc_pano.reserve1", "plc_pano.kumanda", "plc_pano.kapak", "panel_start.main_start", "panel_start.local_start", "aritma_veri.valf", "aritma_veri.samandira", "aritma_veri.motor3", "aritma_veri.motor2", "motor1" };
        public string[] terfi2 = { "PLC_BILGISI.BOLGE","PLC_BILGISI.AD", "PLC_BILGISI.NUMARA","SEVIYE_BILGISI.SEVIYE2", "SEVIYE_BILGISI.SEVIYE","ARITMA_VERI.SU_SEVIYESI", "ARITMA_VERI.DEBI2", "ARITMA_VERI.DEBI","PLC_PANO.RESERVE2", "PLC_PANO.RESERVE","PLC_PANO.KUMANDA","PLC_PANO.KAPAK","PANEL_START.MAIN_START", "PANEL_START.LOCAL_START", "ARITMA_VERI.VALF", "ARITMA_VERI.SAMANDIRA", "ARITMA_VERI.MOTOR3", "ARITMA_VERI.MOTOR2", "ARITMA_VERI.MOTOR1" };
        public string[] depo = { "PLC_BILGISI.BOLGE", "PLC_BILGISI.AD", "PLC_BILGISI.NUMARA", "SEVIYE_BILGISI.SEVIYE2", "SEVIYE_BILGISI.SEVIYE", "ARITMA_VERI.SU_SEVIYESI", "ARITMA_VERI.DEBI2", "ARITMA_VERI.DEBI", "PLC_PANO.RESERVE2", "PLC_PANO.RESERVE", "PLC_PANO.KUMANDA", "PLC_PANO.KAPAK", "PANEL_START.MAIN_START", "PANEL_START.LOCAL_START", "ARITMA_VERI.VALF", "ARITMA_VERI.SAMANDIRA", "ARITMA_VERI.MOTOR3", "ARITMA_VERI.MOTOR2", "ARITMA_VERI.MOTOR1" };

    }
}
