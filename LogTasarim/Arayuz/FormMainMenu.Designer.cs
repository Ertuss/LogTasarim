using System.Drawing;


namespace LogTasarim
{
    partial class FormMainMenu
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMainMenu));
            this.minimize_button = new FontAwesome.Sharp.IconButton();
            this.maximize_button = new FontAwesome.Sharp.IconButton();
            this.exit_button = new FontAwesome.Sharp.IconButton();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.AppName = new System.Windows.Forms.Label();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.home_button = new System.Windows.Forms.PictureBox();
            this.log_korelasyon_button = new FontAwesome.Sharp.IconButton();
            this.log_arsiv_button = new FontAwesome.Sharp.IconButton();
            this.log_alarm_button = new FontAwesome.Sharp.IconButton();
            this.log_toplama_panel = new System.Windows.Forms.Panel();
            this.log_syslog = new FontAwesome.Sharp.IconButton();
            this.log_eventdiagnostic = new FontAwesome.Sharp.IconButton();
            this.log_snmp = new FontAwesome.Sharp.IconButton();
            this.log_processer = new FontAwesome.Sharp.IconButton();
            this.log_toplama_button = new FontAwesome.Sharp.IconButton();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelDesktop.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.home_button)).BeginInit();
            this.log_toplama_panel.SuspendLayout();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // minimize_button
            // 
            this.minimize_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimize_button.FlatAppearance.BorderSize = 0;
            this.minimize_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimize_button.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.minimize_button.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.minimize_button.IconColor = System.Drawing.Color.Black;
            this.minimize_button.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.minimize_button.IconSize = 20;
            this.minimize_button.Location = new System.Drawing.Point(1221, 4);
            this.minimize_button.Margin = new System.Windows.Forms.Padding(4);
            this.minimize_button.Name = "minimize_button";
            this.minimize_button.Rotation = 0D;
            this.minimize_button.Size = new System.Drawing.Size(43, 33);
            this.minimize_button.TabIndex = 4;
            this.minimize_button.UseVisualStyleBackColor = true;
            this.minimize_button.Click += new System.EventHandler(this.minimize_button_Click_1);
            // 
            // maximize_button
            // 
            this.maximize_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maximize_button.FlatAppearance.BorderSize = 0;
            this.maximize_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.maximize_button.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.maximize_button.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.maximize_button.IconColor = System.Drawing.Color.Black;
            this.maximize_button.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.maximize_button.IconSize = 20;
            this.maximize_button.Location = new System.Drawing.Point(1272, 9);
            this.maximize_button.Margin = new System.Windows.Forms.Padding(4);
            this.maximize_button.Name = "maximize_button";
            this.maximize_button.Rotation = 0D;
            this.maximize_button.Size = new System.Drawing.Size(43, 27);
            this.maximize_button.TabIndex = 3;
            this.maximize_button.UseVisualStyleBackColor = true;
            this.maximize_button.Click += new System.EventHandler(this.maximize_button_Click_1);
            // 
            // exit_button
            // 
            this.exit_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exit_button.FlatAppearance.BorderSize = 0;
            this.exit_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit_button.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.exit_button.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.exit_button.IconColor = System.Drawing.Color.Black;
            this.exit_button.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.exit_button.IconSize = 20;
            this.exit_button.Location = new System.Drawing.Point(1323, 4);
            this.exit_button.Margin = new System.Windows.Forms.Padding(4);
            this.exit_button.Name = "exit_button";
            this.exit_button.Rotation = 0D;
            this.exit_button.Size = new System.Drawing.Size(35, 37);
            this.exit_button.TabIndex = 2;
            this.exit_button.UseVisualStyleBackColor = true;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click_1);
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.Gray;
            this.panelDesktop.Controls.Add(this.dataGridView1);
            this.panelDesktop.Controls.Add(this.panelTitleBar);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(293, 0);
            this.panelDesktop.Margin = new System.Windows.Forms.Padding(4);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(1392, 1055);
            this.panelDesktop.TabIndex = 3;
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.DimGray;
            this.panelTitleBar.Controls.Add(this.AppName);
            this.panelTitleBar.Controls.Add(this.minimize_button);
            this.panelTitleBar.Controls.Add(this.maximize_button);
            this.panelTitleBar.Controls.Add(this.exit_button);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(0, 0);
            this.panelTitleBar.Margin = new System.Windows.Forms.Padding(4);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(1392, 123);
            this.panelTitleBar.TabIndex = 4;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // AppName
            // 
            this.AppName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.AppName.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold);
            this.AppName.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.AppName.Location = new System.Drawing.Point(325, 42);
            this.AppName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AppName.Name = "AppName";
            this.AppName.Size = new System.Drawing.Size(609, 47);
            this.AppName.TabIndex = 5;
            this.AppName.Text = "SAU TYM LOG YONETİMİ (SIEM)";
            this.AppName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AppName.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AppName_MouseDown);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelLogo.Controls.Add(this.home_button);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Margin = new System.Windows.Forms.Padding(4);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(293, 123);
            this.panelLogo.TabIndex = 0;
            // 
            // home_button
            // 
            this.home_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.home_button.Image = ((System.Drawing.Image)(resources.GetObject("home_button.Image")));
            this.home_button.Location = new System.Drawing.Point(0, 0);
            this.home_button.Margin = new System.Windows.Forms.Padding(4);
            this.home_button.Name = "home_button";
            this.home_button.Size = new System.Drawing.Size(293, 123);
            this.home_button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.home_button.TabIndex = 0;
            this.home_button.TabStop = false;
            this.home_button.Click += new System.EventHandler(this.home_button_Click);
            // 
            // log_korelasyon_button
            // 
            this.log_korelasyon_button.Dock = System.Windows.Forms.DockStyle.Top;
            this.log_korelasyon_button.FlatAppearance.BorderSize = 0;
            this.log_korelasyon_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.log_korelasyon_button.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.log_korelasyon_button.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.log_korelasyon_button.ForeColor = System.Drawing.Color.Gainsboro;
            this.log_korelasyon_button.IconChar = FontAwesome.Sharp.IconChar.Cut;
            this.log_korelasyon_button.IconColor = System.Drawing.Color.Gainsboro;
            this.log_korelasyon_button.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.log_korelasyon_button.IconSize = 24;
            this.log_korelasyon_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.log_korelasyon_button.Location = new System.Drawing.Point(0, 123);
            this.log_korelasyon_button.Margin = new System.Windows.Forms.Padding(4);
            this.log_korelasyon_button.Name = "log_korelasyon_button";
            this.log_korelasyon_button.Padding = new System.Windows.Forms.Padding(13, 0, 27, 0);
            this.log_korelasyon_button.Rotation = 0D;
            this.log_korelasyon_button.Size = new System.Drawing.Size(293, 92);
            this.log_korelasyon_button.TabIndex = 2;
            this.log_korelasyon_button.Text = "Korelasyon";
            this.log_korelasyon_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.log_korelasyon_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.log_korelasyon_button.UseVisualStyleBackColor = true;
            this.log_korelasyon_button.Click += new System.EventHandler(this.log_korelasyon_button_Click);
            // 
            // log_arsiv_button
            // 
            this.log_arsiv_button.Dock = System.Windows.Forms.DockStyle.Top;
            this.log_arsiv_button.FlatAppearance.BorderSize = 0;
            this.log_arsiv_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.log_arsiv_button.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.log_arsiv_button.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.log_arsiv_button.ForeColor = System.Drawing.Color.Gainsboro;
            this.log_arsiv_button.IconChar = FontAwesome.Sharp.IconChar.Cubes;
            this.log_arsiv_button.IconColor = System.Drawing.Color.Gainsboro;
            this.log_arsiv_button.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.log_arsiv_button.IconSize = 24;
            this.log_arsiv_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.log_arsiv_button.Location = new System.Drawing.Point(0, 215);
            this.log_arsiv_button.Margin = new System.Windows.Forms.Padding(4);
            this.log_arsiv_button.Name = "log_arsiv_button";
            this.log_arsiv_button.Padding = new System.Windows.Forms.Padding(13, 0, 27, 0);
            this.log_arsiv_button.Rotation = 0D;
            this.log_arsiv_button.Size = new System.Drawing.Size(293, 92);
            this.log_arsiv_button.TabIndex = 3;
            this.log_arsiv_button.Text = "Log Arşiv";
            this.log_arsiv_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.log_arsiv_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.log_arsiv_button.UseVisualStyleBackColor = true;
            this.log_arsiv_button.Click += new System.EventHandler(this.log_arsiv_button_Click);
            // 
            // log_alarm_button
            // 
            this.log_alarm_button.Dock = System.Windows.Forms.DockStyle.Top;
            this.log_alarm_button.FlatAppearance.BorderSize = 0;
            this.log_alarm_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.log_alarm_button.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.log_alarm_button.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.log_alarm_button.ForeColor = System.Drawing.Color.Gainsboro;
            this.log_alarm_button.IconChar = FontAwesome.Sharp.IconChar.Adn;
            this.log_alarm_button.IconColor = System.Drawing.Color.Gainsboro;
            this.log_alarm_button.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.log_alarm_button.IconSize = 24;
            this.log_alarm_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.log_alarm_button.Location = new System.Drawing.Point(0, 307);
            this.log_alarm_button.Margin = new System.Windows.Forms.Padding(4);
            this.log_alarm_button.Name = "log_alarm_button";
            this.log_alarm_button.Padding = new System.Windows.Forms.Padding(13, 0, 27, 0);
            this.log_alarm_button.Rotation = 0D;
            this.log_alarm_button.Size = new System.Drawing.Size(293, 92);
            this.log_alarm_button.TabIndex = 4;
            this.log_alarm_button.Text = "Alarm Ve Raporlar";
            this.log_alarm_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.log_alarm_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.log_alarm_button.UseVisualStyleBackColor = true;
            this.log_alarm_button.Click += new System.EventHandler(this.log_alarm_button_Click);
            // 
            // log_toplama_panel
            // 
            this.log_toplama_panel.Controls.Add(this.log_syslog);
            this.log_toplama_panel.Controls.Add(this.log_eventdiagnostic);
            this.log_toplama_panel.Controls.Add(this.log_snmp);
            this.log_toplama_panel.Controls.Add(this.log_processer);
            this.log_toplama_panel.Controls.Add(this.log_toplama_button);
            this.log_toplama_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.log_toplama_panel.Location = new System.Drawing.Point(0, 399);
            this.log_toplama_panel.Margin = new System.Windows.Forms.Padding(4);
            this.log_toplama_panel.Name = "log_toplama_panel";
            this.log_toplama_panel.Size = new System.Drawing.Size(293, 339);
            this.log_toplama_panel.TabIndex = 5;
            // 
            // log_syslog
            // 
            this.log_syslog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.log_syslog.Dock = System.Windows.Forms.DockStyle.Top;
            this.log_syslog.FlatAppearance.BorderSize = 0;
            this.log_syslog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.log_syslog.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.log_syslog.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.log_syslog.ForeColor = System.Drawing.Color.Gainsboro;
            this.log_syslog.IconChar = FontAwesome.Sharp.IconChar.None;
            this.log_syslog.IconColor = System.Drawing.Color.Black;
            this.log_syslog.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.log_syslog.IconSize = 48;
            this.log_syslog.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.log_syslog.Location = new System.Drawing.Point(0, 257);
            this.log_syslog.Margin = new System.Windows.Forms.Padding(4);
            this.log_syslog.Name = "log_syslog";
            this.log_syslog.Rotation = 0D;
            this.log_syslog.Size = new System.Drawing.Size(293, 55);
            this.log_syslog.TabIndex = 4;
            this.log_syslog.Text = "Syslog";
            this.log_syslog.UseVisualStyleBackColor = false;
            this.log_syslog.Click += new System.EventHandler(this.log_syslog_Click);
            // 
            // log_eventdiagnostic
            // 
            this.log_eventdiagnostic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.log_eventdiagnostic.Dock = System.Windows.Forms.DockStyle.Top;
            this.log_eventdiagnostic.FlatAppearance.BorderSize = 0;
            this.log_eventdiagnostic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.log_eventdiagnostic.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.log_eventdiagnostic.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.log_eventdiagnostic.ForeColor = System.Drawing.Color.Gainsboro;
            this.log_eventdiagnostic.IconChar = FontAwesome.Sharp.IconChar.None;
            this.log_eventdiagnostic.IconColor = System.Drawing.Color.Black;
            this.log_eventdiagnostic.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.log_eventdiagnostic.IconSize = 48;
            this.log_eventdiagnostic.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.log_eventdiagnostic.Location = new System.Drawing.Point(0, 202);
            this.log_eventdiagnostic.Margin = new System.Windows.Forms.Padding(4);
            this.log_eventdiagnostic.Name = "log_eventdiagnostic";
            this.log_eventdiagnostic.Rotation = 0D;
            this.log_eventdiagnostic.Size = new System.Drawing.Size(293, 55);
            this.log_eventdiagnostic.TabIndex = 4;
            this.log_eventdiagnostic.Text = "Event Diagnostic";
            this.log_eventdiagnostic.UseVisualStyleBackColor = false;
            this.log_eventdiagnostic.Click += new System.EventHandler(this.log_eventdiagnostic_Click);
            // 
            // log_snmp
            // 
            this.log_snmp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.log_snmp.Dock = System.Windows.Forms.DockStyle.Top;
            this.log_snmp.FlatAppearance.BorderSize = 0;
            this.log_snmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.log_snmp.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.log_snmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.log_snmp.ForeColor = System.Drawing.Color.Gainsboro;
            this.log_snmp.IconChar = FontAwesome.Sharp.IconChar.None;
            this.log_snmp.IconColor = System.Drawing.Color.Black;
            this.log_snmp.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.log_snmp.IconSize = 48;
            this.log_snmp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.log_snmp.Location = new System.Drawing.Point(0, 147);
            this.log_snmp.Margin = new System.Windows.Forms.Padding(4);
            this.log_snmp.Name = "log_snmp";
            this.log_snmp.Rotation = 0D;
            this.log_snmp.Size = new System.Drawing.Size(293, 55);
            this.log_snmp.TabIndex = 4;
            this.log_snmp.Text = "SNMP";
            this.log_snmp.UseVisualStyleBackColor = false;
            this.log_snmp.Click += new System.EventHandler(this.log_snmp_Click);
            // 
            // log_processer
            // 
            this.log_processer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.log_processer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.log_processer.Dock = System.Windows.Forms.DockStyle.Top;
            this.log_processer.FlatAppearance.BorderSize = 0;
            this.log_processer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.log_processer.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.log_processer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.log_processer.ForeColor = System.Drawing.Color.Gainsboro;
            this.log_processer.IconChar = FontAwesome.Sharp.IconChar.None;
            this.log_processer.IconColor = System.Drawing.Color.Black;
            this.log_processer.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.log_processer.IconSize = 48;
            this.log_processer.Location = new System.Drawing.Point(0, 92);
            this.log_processer.Margin = new System.Windows.Forms.Padding(4);
            this.log_processer.Name = "log_processer";
            this.log_processer.Rotation = 0D;
            this.log_processer.Size = new System.Drawing.Size(293, 55);
            this.log_processer.TabIndex = 4;
            this.log_processer.Text = "Prosesör";
            this.log_processer.UseVisualStyleBackColor = false;
            this.log_processer.Click += new System.EventHandler(this.log_processer_Click);
            // 
            // log_toplama_button
            // 
            this.log_toplama_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.log_toplama_button.Dock = System.Windows.Forms.DockStyle.Top;
            this.log_toplama_button.FlatAppearance.BorderSize = 0;
            this.log_toplama_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.log_toplama_button.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.log_toplama_button.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.log_toplama_button.ForeColor = System.Drawing.Color.Gainsboro;
            this.log_toplama_button.IconChar = FontAwesome.Sharp.IconChar.ChartBar;
            this.log_toplama_button.IconColor = System.Drawing.Color.Gainsboro;
            this.log_toplama_button.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.log_toplama_button.IconSize = 24;
            this.log_toplama_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.log_toplama_button.Location = new System.Drawing.Point(0, 0);
            this.log_toplama_button.Margin = new System.Windows.Forms.Padding(4);
            this.log_toplama_button.Name = "log_toplama_button";
            this.log_toplama_button.Padding = new System.Windows.Forms.Padding(13, 0, 27, 0);
            this.log_toplama_button.Rotation = 0D;
            this.log_toplama_button.Size = new System.Drawing.Size(293, 92);
            this.log_toplama_button.TabIndex = 0;
            this.log_toplama_button.Text = "Log Toplama";
            this.log_toplama_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.log_toplama_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.log_toplama_button.UseVisualStyleBackColor = true;
            this.log_toplama_button.Click += new System.EventHandler(this.log_toplama_button_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelMenu.Controls.Add(this.log_toplama_panel);
            this.panelMenu.Controls.Add(this.log_alarm_button);
            this.panelMenu.Controls.Add(this.log_arsiv_button);
            this.panelMenu.Controls.Add(this.log_korelasyon_button);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(4);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(293, 1055);
            this.panelMenu.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView1.Location = new System.Drawing.Point(57, 170);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1088, 321);
            this.dataGridView1.TabIndex = 5;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 200;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Column3";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Column4";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // FormMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1685, 1055);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMainMenu";
            this.Text = "Log Yönetimi";
            this.Load += new System.EventHandler(this.FormMainMenu_Load);
            this.panelDesktop.ResumeLayout(false);
            this.panelTitleBar.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.home_button)).EndInit();
            this.log_toplama_panel.ResumeLayout(false);
            this.panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelDesktop;
        private FontAwesome.Sharp.IconButton exit_button;
        private FontAwesome.Sharp.IconButton minimize_button;
        private FontAwesome.Sharp.IconButton maximize_button;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label AppName;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox home_button;
        private FontAwesome.Sharp.IconButton log_korelasyon_button;
        private FontAwesome.Sharp.IconButton log_arsiv_button;
        private FontAwesome.Sharp.IconButton log_alarm_button;
        private System.Windows.Forms.Panel log_toplama_panel;
        private FontAwesome.Sharp.IconButton log_syslog;
        private FontAwesome.Sharp.IconButton log_eventdiagnostic;
        private FontAwesome.Sharp.IconButton log_snmp;
        private FontAwesome.Sharp.IconButton log_processer;
        private FontAwesome.Sharp.IconButton log_toplama_button;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}

