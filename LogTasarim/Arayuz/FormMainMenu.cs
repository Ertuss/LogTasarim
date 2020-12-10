using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using LogToplayıcı.Is_Katmani;
using LogToplayıcı.Uygulama_Katmani;
using LogToplayıcı.Veritabani_Katmani;
using MongoDB.Bson;
using MongoDB.Driver;

namespace LogTasarim
{
    public partial class FormMainMenu : Form
    {
        private Veritabani veritabani;
        private string server = "localhost";
        private string databaseName = "DENEME";
        private string userName = "ertus";
        private string password = "admin";

        private string prosesVerisiKoleksiyonu = "KOLEKSIYON";

        Thread _logThread;

        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildeForm;
        public FormMainMenu()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 75);
            panelMenu.Controls.Add(leftBorderBtn);
            //Form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        private void FormMainMenu_Load(object sender, EventArgs e)
        {
            // Formu full ekran başlatma ve tepedeki beyaz çizgiyi silme
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            log_toplama_panel.Height = 75;

            // Başlık ortalama
            int x = (panelTitleBar.Size.Width - AppName.Size.Width) / 2;
            AppName.Location = new Point(x, AppName.Location.Y);

            veritabani = new Veritabani(server, 27017, databaseName, userName, password);
            

            _logThread = new Thread(new ThreadStart(LogThread));
            _logThread.IsBackground = true;
            _logThread.Start();


        }

        //Structlar
        private struct RGBColors
        {

            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
        }

        //Metotlar
        private void ActivateButton(object senderBtn, Color color)
        {


            if (senderBtn != null)
            {
                //Buton ozellestirme
                DisableButton();//onceki butonu disable edip yeni butonla baslariz.

                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(220, 220, 220);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //
                // leftBorderBtn.BackColor = color;
                // leftBorderBtn.Location = new Point(0,currentBtn.Location.Y);
                //leftBorderBtn.Visible = true;
                // leftBorderBtn.BringToFront();
            }

            if (currentBtn != null && (currentBtn.Text == "Prosesör" || currentBtn.Text == "SNMP"
               || currentBtn.Text == "Event Diagnostic" || currentBtn.Text == "Syslog"))
            {
                DisableButton();

                currentBtn.BackColor = Color.FromArgb(113, 113, 220);
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
            }



        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                if (currentBtn.Text == "Prosesör" || currentBtn.Text == "SNMP"
               || currentBtn.Text == "Event Diagnostic" || currentBtn.Text == "Syslog")
                {
                    currentBtn.BackColor = Color.FromArgb(64, 64, 64);
                    currentBtn.ForeColor = Color.Gainsboro;
                    currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                }
                else
                {
                    currentBtn.BackColor = Color.FromArgb(64, 64, 64);
                    currentBtn.ForeColor = Color.Gainsboro;
                    currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                    currentBtn.IconColor = Color.Gainsboro;
                    currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                    currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
                }
            }
        }
        private void DisableLittleButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(64, 64, 64);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
            }
        }

        private void OpenChildForm(Form childForm)
        {
            if (currentChildeForm != null)
            {
                currentChildeForm.Close();
            }
            currentChildeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();


        }

        //Butonlarin Click Metotlari
        //LOG TOPLAMA
        private void log_toplama_button_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);

            if (log_toplama_panel.Height == 339)
                log_toplama_panel.Height = 75;
            else
                log_toplama_panel.Height = 339;
        }


        private void log_processer_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new FormProcessor());
        }

        private void log_syslog_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new FormSysLog());
        }

        private void log_eventdiagnostic_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new FormDiagnostic());
        }

        private void log_snmp_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new FormSnmp());
        }
        //Log Korelasyon
        private void log_korelasyon_button_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4);
            OpenChildForm(new FormLogKorelasyon());
        }
        //Log Arsiv
        private void log_arsiv_button_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color5);
            OpenChildForm(new FormLogArsiv());
        }
        //Log Alarm ve Rapor
        private void log_alarm_button_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color6);
            OpenChildForm(new FormAlarm());
        }

        //Acma kapatma kucultme
        private void minimize_button_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void maximize_button_Click_1(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void exit_button_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void home_button_Click(object sender, EventArgs e)
        {
            Reset();
        }
        public void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;

        }

        //Drag Form Paneli Tutup Surukleme
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void AppName_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        ////////////////////////////////////////////////////////////
        ///

        private void LogThread()
        {
            Beckhoff_Ethercat_Proses_OPC beckhoff = new Beckhoff_Ethercat_Proses_OPC();
            Beckhoff_Modbus_SNMP_OPC snmp = new Beckhoff_Modbus_SNMP_OPC();
            Siemens_Modbus_Proses_OPC siemens_ = new Siemens_Modbus_Proses_OPC();
            Schneider_Modbus_Process_OPC schneider = new Schneider_Modbus_Process_OPC();
            Schneider_SNMP_OPC schneider_SNMP = new Schneider_SNMP_OPC();
            Siemens_SNMP_OPC siemens_SNMP = new Siemens_SNMP_OPC();
            JsonKaydetme jsonKaydetme = new JsonKaydetme();
            SnmpClient snmpClient = new SnmpClient();
            Diagnostic diagnostic = new Diagnostic();
            Syslog syslog = new Syslog();

            //foreach (var i in syslog.IpStationPairs.Keys)
            //{
            //    syslog.SyslogCollector(i);
            //}
            //string komut = "wget --no-check-certificate --secure-protocol=auto --referer=http://192.168.41.10//Portal/Portal.mwsl?PriNav=Diag http://192.168.41.10/ClientArea/ASLog.csv --output-document=deneme1diagnostic";
            //diagnostic.KomutSatiriCalistir(komut);
            Diagnostic.SiemensDiagnostikVeriGetir();

            #region PLC'ler SNMP atamaları
            string beckhoffAritmaHost = "192.168.227.111";
            string beckhoffTerfi1Host = "192.168.227.131";
            string beckhoffTerfi2Host = "192.168.227.141";
            string beckhoffDepoHost = "192.168.227.101";
            string beckhoffSnmpCommunity = "public";


            string siemensTerfi1Host = "192.168.41.10";
            string siemensTerfi2Host = "192.168.42.10";
            string siemensAritmaHost = "192.168.43.10";
            string siemensSnmpCommunity = "public";
            #endregion

            while (true)
            {
                List<object> jsonItemList = new List<object>();

                #region Schneider İçmeSuyu Proses
                //string schneiderProsesDosyaYolu = @"C:\Users\Log Sunucu\Desktop\schneiderProses.json";

                //Arıtma
                for (int i = 0; i < schneider.treatment.Length; i++)
                {
                    // schneider RestClientten miras alır endpointi çekilir
                    schneider.endPoint = schneider.baseUrl_Treatment + schneider.treatment[i];
                    string strResponse_Treatment = string.Empty;
                    strResponse_Treatment = schneider.makeRequest();
                    Console.WriteLine("Treatment:" + " " + schneider.stringParsing(strResponse_Treatment));
                    var jobjTreatment = "\"" + schneider.treatment[i] + "\":\"" + schneider.stringParsing(strResponse_Treatment) + "\"";
                    jsonItemList.Add(jobjTreatment);
                    //aritmaKafka[i] = beckhoff_.stringParsing(strResponse_Treatment);
                }
                jsonItemList.Add("\"cihaz_tip\":\"Treatment\"");
                veritabani.InsertOne<db_Models.Proses>(prosesVerisiKoleksiyonu, jsonItemList);
                //jsonKaydetme.dosyayaYaz(jsonItemList, schneiderProsesDosyaYolu);
                jsonItemList.Clear();

                //Terfi1
                for (int i = 0; i < schneider.ereservoir.Length; i++)
                {
                    schneider.endPoint = schneider.baseUrl_EReservoir + schneider.ereservoir[i];
                    string strResponse_Ereservoir = string.Empty;
                    strResponse_Ereservoir = schneider.makeRequest();
                    Console.WriteLine("Ereservoir:" + " " + schneider.stringParsing(strResponse_Ereservoir));
                    var jobjEreservoir = "\"" + schneider.ereservoir[i] + "\":\"" + schneider.stringParsing(strResponse_Ereservoir) + "\"";
                    jsonItemList.Add(jobjEreservoir);
                    //aritmaKafka[i] = beckhoff_.stringParsing(strResponse_Treatment);
                }
                jsonItemList.Add("\"cihaz_tip\":\"Ereservoir\"");
                veritabani.InsertOne<db_Models.Proses>(prosesVerisiKoleksiyonu, jsonItemList);
                //jsonKaydetme.dosyayaYaz(jsonItemList, schneiderProsesDosyaYolu);
                jsonItemList.Clear();

                //Terfi2
                for (int i = 0; i < schneider.creservoir.Length; i++)
                {
                    schneider.endPoint = schneider.baseUrl_CReservoir + schneider.creservoir[i];
                    string strResponse_Creservoir = string.Empty;
                    strResponse_Creservoir = schneider.makeRequest();
                    Console.WriteLine("Creservoir:" + " " + schneider.stringParsing(strResponse_Creservoir));
                    var jobjCreservoir = "\"" + schneider.creservoir[i] + "\":\"" + schneider.stringParsing(strResponse_Creservoir) + "\"";
                    jsonItemList.Add(jobjCreservoir);
                    //aritmaKafka[i] = beckhoff_.stringParsing(strResponse_Treatment);
                }
                jsonItemList.Add("\"cihaz_tip\":\"Creservoir\"");
                //jsonKaydetme.dosyayaYaz(jsonItemList, schneiderProsesDosyaYolu);
                veritabani.InsertOne<db_Models.Proses>(prosesVerisiKoleksiyonu, jsonItemList);
                jsonItemList.Clear();

                //Tank
                for (int i = 0; i < schneider.tank.Length; i++)
                {
                    schneider.endPoint = schneider.baseUrl_Tank + schneider.tank[i];
                    string strResponse_Tank = string.Empty;
                    strResponse_Tank = schneider.makeRequest();
                    Console.WriteLine("Tank:" + " " + schneider.stringParsing(strResponse_Tank));
                    var jobjTank = "\"" + schneider.tank[i] + "\":\"" + schneider.stringParsing(strResponse_Tank) + "\"";
                    jsonItemList.Add(jobjTank);
                    //aritmaKafka[i] = beckhoff_.stringParsing(strResponse_Treatment);
                }
                jsonItemList.Add("\"cihaz_tip\":\"Tank\"");
                //jsonKaydetme.dosyayaYaz(jsonItemList, schneiderProsesDosyaYolu);
                veritabani.InsertOne<db_Models.Proses>(prosesVerisiKoleksiyonu, jsonItemList);
                jsonItemList.Clear();

                #endregion

                Thread.Sleep(1000);

            }

        }
    }
}
