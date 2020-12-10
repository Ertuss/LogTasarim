using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogToplayıcı.Is_Katmani
{
    
    class Siemens_Modbus_Proses_OPC:RestClient
    {
        public string baseUrl_Treatment = "http://192.168.50.10:39342/iotgateway/read?ids=Siemens_TCPIP_PLC.S7_1500_Treatment.";
        public string baseUrl_Promotion1 = "http://192.168.50.10:39340/iotgateway/read?ids=Siemens_TCPIP_PLC.S7_1200_Promotion1.";
        public string baseUrl_Promotion2 = "http://192.168.50.10:39341/iotgateway/read?ids=Siemens_TCPIP_PLC.S7_1200_Promotion2.";

        public string[] treatment = { "treatment_circulation_scenario_start", "treatment_current_level", "treatment_current_volume", "treatment_distribution_scenario_start", "treatment_evacuation_scenario_start", "treatment_level_update2", "treatment_reset_sim", "treatment_set_flow_meter", "treatment_set_level", "treatment_set_level_0", "treatment_total_cm_evacuated", "treatment_total_vol_evacuated", "treatment_valf" };
        public string[] promotion1 = { "promotio1_set_level_0", "promotion1_circulation_scenario_start", "promotion1_current_level", "promotion1_current_volume", "promotion1_distribution_scenario_start", "promotion1_evacuation_scenario_start", "promotion1_level_update", "promotion1_motor1", "promotion1_motor2", "promotion1_motor3", "promotion1_reset_sim", "promotion1_set_flow_meter", "promotion1_set_level" };
        public string[] promotion2 = { "promotion2_circulation_scenario_start", "promotion2_current_level", "promotion2_current_volume", "promotion2_distribution_scenario_start", "promotion2_evacuation_scenario_start", "promotion2_level_update2", "promotion2_motor1", "promotion2_motor2", "promotion2_motor3", "promotion2_reset_sim", "promotion2_set_flow_meter", "promotion2_set_level", "promotion2_set_level_0" };

    }
}
