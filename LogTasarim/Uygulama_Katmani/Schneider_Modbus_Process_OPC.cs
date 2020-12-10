using LogToplayıcı.Is_Katmani;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogToplayıcı.Uygulama_Katmani
{
    class Schneider_Modbus_Process_OPC:RestClient
    {
        public string baseUrl_Treatment = "http://192.168.50.10:39330/iotgateway/read?ids=Schneider_ModbusTCP_RTU.Treatment_RTU.";
        public string baseUrl_EReservoir = "http://192.168.50.10:39331/iotgateway/read?ids=Schneider_ModbusTCP_RTU.Elevator_Reservoir_RTU.";
        public string baseUrl_CReservoir = "http://192.168.50.10:39332/iotgateway/read?ids=Schneider_ModbusTCP_RTU.Consumer_Reservoir.RTU.";
        public string baseUrl_Tank = "http://192.168.50.10:39333/iotgateway/read?ids=Schneider_ModbusTCP_RTU.Tank_RTU.";


        public string[] treatment = { "Treat_ScenarioID", "Treat_PumpFlowLiterMin", "Treat_Pump3", "Treat_Pump2", "Treat_Pump1", "Treat_LocalRemote", "Treat_LimitSwitch1", "Treat_Level2", "Treat_Level1", "Treat_CurrentVolume", "Treat_CabinLock", "Dam_Pump3","Dam_Pump2","Dam_Pump1","Dam_LimitSwitch" };
        public string[] ereservoir= { "EReservoir_ScenarioID", "EReservoir_PumpFlowLiterMin", "EReservoir_Pump3", "EReservoir_Pump2", "EReservoir_Pump1", "EReservoir_LocalRemote", "EReservoir_LimitSwitch", "EReservoir_Level2", "EReservoir_Level1", "EReservoir_CabinLock" };
        public string[] creservoir = { "CReservoir_ScenarioID", "CReservoir_PumpFlowLiterMin","CReservoir_DrainFlowLiterMin", "CReservoir_LocalRemote", "CReservoir_Level2", "CReservoir_Level1", "CReservoir_CabinLock", "CReservoir_Pump3", "CReservoir_Pump2", "CReservoir_Pump1", "CReservoir_LimitSwitch", "CReservoir_DrainValve" };
        public string[] tank = { "Tank_ScenarioID", "Tank_LocalRemote", "Tank_Level2", "Tank_Level1", "Tank_DrainFlowLiterMin", "Tank_CabinLock", "Tank_LimitSwitch", "Tank_DrainValve" };
    }
}
