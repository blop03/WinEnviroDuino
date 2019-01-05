namespace WindowsFormsApplication2
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.textBox_Etat_Connection = new System.Windows.Forms.TextBox();
            this.textBox_log = new System.Windows.Forms.RichTextBox();
            this.label_temp_princ = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label_mail_expediteur = new System.Windows.Forms.Label();
            this.label_mail_destinataire = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label_tempmax = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label_mail_activation = new System.Windows.Forms.Label();
            this.panel_header = new System.Windows.Forms.Panel();
            this.label_date = new System.Windows.Forms.Label();
            this.label_heure = new System.Windows.Forms.Label();
            this.panel_temperature = new System.Windows.Forms.Panel();
            this.label_temp_degre = new System.Windows.Forms.Label();
            this.label_temp_sec = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label_temp_titre = new System.Windows.Forms.Label();
            this.panel_temp_logo = new System.Windows.Forms.Panel();
            this.panel_humidite = new System.Windows.Forms.Panel();
            this.label_humi_princ = new System.Windows.Forms.Label();
            this.label_titre_humi = new System.Windows.Forms.Label();
            this.panel_humi_logo = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel_information = new System.Windows.Forms.Panel();
            this.panel_etat_connection = new System.Windows.Forms.Panel();
            this.label_vis_port = new System.Windows.Forms.Label();
            this.Label_port_affichage = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.buttonStop = new System.Windows.Forms.Button();
            this.buttondebut = new System.Windows.Forms.Button();
            this.panelLog = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.TabDashboard = new System.Windows.Forms.TabPage();
            this.TabConfiguration = new System.Windows.Forms.TabPage();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.checkBox_config_simulation = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.checkBox_humidité = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.check_conf_ssl = new System.Windows.Forms.CheckBox();
            this.label_smtp_port = new System.Windows.Forms.Label();
            this.button_conf_valider = new System.Windows.Forms.Button();
            this.textbox_conf_destinataire = new System.Windows.Forms.TextBox();
            this.textbox_conf_expediteur = new System.Windows.Forms.TextBox();
            this.checkBox_conf_mail = new System.Windows.Forms.CheckBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.numeric_conf_temp_max = new System.Windows.Forms.NumericUpDown();
            this.label21 = new System.Windows.Forms.Label();
            this.textBox_Config_Info = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelConfigPortCom = new System.Windows.Forms.Label();
            this.numeric_config_port = new System.Windows.Forms.NumericUpDown();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TabGraphique = new System.Windows.Forms.TabPage();
            this.Graphique1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel_header.SuspendLayout();
            this.panel_temperature.SuspendLayout();
            this.panel_humidite.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel_information.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panelLog.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.TabDashboard.SuspendLayout();
            this.TabConfiguration.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_conf_temp_max)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_config_port)).BeginInit();
            this.TabGraphique.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Graphique1)).BeginInit();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM3";
            this.serialPort1.ReceivedBytesThreshold = 6;
            this.serialPort1.WriteBufferSize = 4096;
            // 
            // textBox_Etat_Connection
            // 
            resources.ApplyResources(this.textBox_Etat_Connection, "textBox_Etat_Connection");
            this.textBox_Etat_Connection.Name = "textBox_Etat_Connection";
            this.textBox_Etat_Connection.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox_log
            // 
            resources.ApplyResources(this.textBox_log, "textBox_log");
            this.textBox_log.Name = "textBox_log";
            // 
            // label_temp_princ
            // 
            resources.ApplyResources(this.label_temp_princ, "label_temp_princ");
            this.label_temp_princ.BackColor = System.Drawing.Color.Transparent;
            this.label_temp_princ.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label_temp_princ.Name = "label_temp_princ";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Name = "label4";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Name = "label5";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // label_mail_expediteur
            // 
            resources.ApplyResources(this.label_mail_expediteur, "label_mail_expediteur");
            this.label_mail_expediteur.ForeColor = System.Drawing.SystemColors.Window;
            this.label_mail_expediteur.Name = "label_mail_expediteur";
            this.label_mail_expediteur.Click += new System.EventHandler(this.label7_Click);
            // 
            // label_mail_destinataire
            // 
            resources.ApplyResources(this.label_mail_destinataire, "label_mail_destinataire");
            this.label_mail_destinataire.ForeColor = System.Drawing.SystemColors.Window;
            this.label_mail_destinataire.Name = "label_mail_destinataire";
            this.label_mail_destinataire.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Name = "label9";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.ForeColor = System.Drawing.SystemColors.Window;
            this.label11.Name = "label11";
            // 
            // label12
            // 
            resources.ApplyResources(this.label12, "label12");
            this.label12.ForeColor = System.Drawing.SystemColors.Window;
            this.label12.Name = "label12";
            // 
            // label_tempmax
            // 
            resources.ApplyResources(this.label_tempmax, "label_tempmax");
            this.label_tempmax.ForeColor = System.Drawing.Color.DarkGreen;
            this.label_tempmax.Name = "label_tempmax";
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.ForeColor = System.Drawing.SystemColors.Window;
            this.label10.Name = "label10";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label_mail_activation
            // 
            resources.ApplyResources(this.label_mail_activation, "label_mail_activation");
            this.label_mail_activation.ForeColor = System.Drawing.Color.SandyBrown;
            this.label_mail_activation.Name = "label_mail_activation";
            this.label_mail_activation.Click += new System.EventHandler(this.label13_Click);
            // 
            // panel_header
            // 
            this.panel_header.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel_header.Controls.Add(this.label_date);
            this.panel_header.Controls.Add(this.label_heure);
            resources.ApplyResources(this.panel_header, "panel_header");
            this.panel_header.Name = "panel_header";
            // 
            // label_date
            // 
            resources.ApplyResources(this.label_date, "label_date");
            this.label_date.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label_date.Name = "label_date";
            // 
            // label_heure
            // 
            resources.ApplyResources(this.label_heure, "label_heure");
            this.label_heure.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label_heure.Name = "label_heure";
            // 
            // panel_temperature
            // 
            this.panel_temperature.BackColor = System.Drawing.SystemColors.WindowText;
            this.panel_temperature.Controls.Add(this.label_temp_degre);
            this.panel_temperature.Controls.Add(this.label_temp_sec);
            this.panel_temperature.Controls.Add(this.label1);
            this.panel_temperature.Controls.Add(this.label_temp_princ);
            this.panel_temperature.Controls.Add(this.label_temp_titre);
            this.panel_temperature.Controls.Add(this.panel_temp_logo);
            resources.ApplyResources(this.panel_temperature, "panel_temperature");
            this.panel_temperature.Name = "panel_temperature";
            // 
            // label_temp_degre
            // 
            resources.ApplyResources(this.label_temp_degre, "label_temp_degre");
            this.label_temp_degre.BackColor = System.Drawing.Color.Transparent;
            this.label_temp_degre.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label_temp_degre.Name = "label_temp_degre";
            // 
            // label_temp_sec
            // 
            resources.ApplyResources(this.label_temp_sec, "label_temp_sec");
            this.label_temp_sec.BackColor = System.Drawing.Color.Transparent;
            this.label_temp_sec.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label_temp_sec.Name = "label_temp_sec";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Name = "label1";
            // 
            // label_temp_titre
            // 
            resources.ApplyResources(this.label_temp_titre, "label_temp_titre");
            this.label_temp_titre.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_temp_titre.Name = "label_temp_titre";
            // 
            // panel_temp_logo
            // 
            resources.ApplyResources(this.panel_temp_logo, "panel_temp_logo");
            this.panel_temp_logo.Name = "panel_temp_logo";
            // 
            // panel_humidite
            // 
            this.panel_humidite.BackColor = System.Drawing.SystemColors.MenuText;
            resources.ApplyResources(this.panel_humidite, "panel_humidite");
            this.panel_humidite.Controls.Add(this.label_humi_princ);
            this.panel_humidite.Controls.Add(this.label_titre_humi);
            this.panel_humidite.Controls.Add(this.panel_humi_logo);
            this.panel_humidite.Name = "panel_humidite";
            // 
            // label_humi_princ
            // 
            resources.ApplyResources(this.label_humi_princ, "label_humi_princ");
            this.label_humi_princ.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label_humi_princ.Name = "label_humi_princ";
            // 
            // label_titre_humi
            // 
            resources.ApplyResources(this.label_titre_humi, "label_titre_humi");
            this.label_titre_humi.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_titre_humi.Name = "label_titre_humi";
            // 
            // panel_humi_logo
            // 
            resources.ApplyResources(this.panel_humi_logo, "panel_humi_logo");
            this.panel_humi_logo.Name = "panel_humi_logo";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.WindowFrame;
            resources.ApplyResources(this.panel5, "panel5");
            this.panel5.Controls.Add(this.label9);
            this.panel5.Controls.Add(this.label_mail_expediteur);
            this.panel5.Controls.Add(this.label_mail_destinataire);
            this.panel5.Controls.Add(this.label11);
            this.panel5.Controls.Add(this.label12);
            this.panel5.Controls.Add(this.label10);
            this.panel5.Controls.Add(this.label_mail_activation);
            this.panel5.Name = "panel5";
            // 
            // panel_information
            // 
            this.panel_information.BackColor = System.Drawing.SystemColors.MenuText;
            resources.ApplyResources(this.panel_information, "panel_information");
            this.panel_information.Controls.Add(this.panel_etat_connection);
            this.panel_information.Controls.Add(this.label_vis_port);
            this.panel_information.Controls.Add(this.Label_port_affichage);
            this.panel_information.Controls.Add(this.label17);
            this.panel_information.Controls.Add(this.label4);
            this.panel_information.Controls.Add(this.textBox_Etat_Connection);
            this.panel_information.Controls.Add(this.label5);
            this.panel_information.Controls.Add(this.label_tempmax);
            this.panel_information.Name = "panel_information";
            // 
            // panel_etat_connection
            // 
            this.panel_etat_connection.BackgroundImage = global::Station_environemental.Properties.Resources.button_red;
            resources.ApplyResources(this.panel_etat_connection, "panel_etat_connection");
            this.panel_etat_connection.Name = "panel_etat_connection";
            // 
            // label_vis_port
            // 
            resources.ApplyResources(this.label_vis_port, "label_vis_port");
            this.label_vis_port.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label_vis_port.Name = "label_vis_port";
            // 
            // Label_port_affichage
            // 
            resources.ApplyResources(this.Label_port_affichage, "Label_port_affichage");
            this.Label_port_affichage.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Label_port_affichage.Name = "Label_port_affichage";
            // 
            // label17
            // 
            resources.ApplyResources(this.label17, "label17");
            this.label17.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label17.Name = "label17";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel8.Controls.Add(this.buttonStop);
            this.panel8.Controls.Add(this.buttondebut);
            resources.ApplyResources(this.panel8, "panel8");
            this.panel8.Name = "panel8";
            // 
            // buttonStop
            // 
            this.buttonStop.BackgroundImage = global::Station_environemental.Properties.Resources.arréter1;
            resources.ApplyResources(this.buttonStop, "buttonStop");
            this.buttonStop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click_1);
            // 
            // buttondebut
            // 
            this.buttondebut.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.buttondebut.BackgroundImage = global::Station_environemental.Properties.Resources.fléches_bleu_sans_fond1;
            resources.ApplyResources(this.buttondebut, "buttondebut");
            this.buttondebut.Name = "buttondebut";
            this.buttondebut.UseVisualStyleBackColor = false;
            this.buttondebut.Click += new System.EventHandler(this.buttondebut_Click);
            // 
            // panelLog
            // 
            this.panelLog.BackColor = System.Drawing.SystemColors.WindowFrame;
            resources.ApplyResources(this.panelLog, "panelLog");
            this.panelLog.Controls.Add(this.label6);
            this.panelLog.Controls.Add(this.textBox_log);
            this.panelLog.Name = "panelLog";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.TabDashboard);
            this.tabControl1.Controls.Add(this.TabConfiguration);
            this.tabControl1.Controls.Add(this.TabGraphique);
            this.tabControl1.ImageList = this.imageList1;
            resources.ApplyResources(this.tabControl1, "tabControl1");
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            // 
            // TabDashboard
            // 
            this.TabDashboard.Controls.Add(this.panel_temperature);
            this.TabDashboard.Controls.Add(this.panel5);
            this.TabDashboard.Controls.Add(this.panel_humidite);
            this.TabDashboard.Controls.Add(this.panel8);
            this.TabDashboard.Controls.Add(this.panelLog);
            this.TabDashboard.Controls.Add(this.panel_information);
            this.TabDashboard.Controls.Add(this.panel_header);
            resources.ApplyResources(this.TabDashboard, "TabDashboard");
            this.TabDashboard.Name = "TabDashboard";
            this.TabDashboard.UseVisualStyleBackColor = true;
            // 
            // TabConfiguration
            // 
            this.TabConfiguration.Controls.Add(this.numericUpDown1);
            this.TabConfiguration.Controls.Add(this.label13);
            this.TabConfiguration.Controls.Add(this.checkBox_config_simulation);
            this.TabConfiguration.Controls.Add(this.label8);
            this.TabConfiguration.Controls.Add(this.checkBox_humidité);
            this.TabConfiguration.Controls.Add(this.label7);
            this.TabConfiguration.Controls.Add(this.label2);
            this.TabConfiguration.Controls.Add(this.check_conf_ssl);
            this.TabConfiguration.Controls.Add(this.label_smtp_port);
            this.TabConfiguration.Controls.Add(this.button_conf_valider);
            this.TabConfiguration.Controls.Add(this.textbox_conf_destinataire);
            this.TabConfiguration.Controls.Add(this.textbox_conf_expediteur);
            this.TabConfiguration.Controls.Add(this.checkBox_conf_mail);
            this.TabConfiguration.Controls.Add(this.label24);
            this.TabConfiguration.Controls.Add(this.label23);
            this.TabConfiguration.Controls.Add(this.label22);
            this.TabConfiguration.Controls.Add(this.numeric_conf_temp_max);
            this.TabConfiguration.Controls.Add(this.label21);
            this.TabConfiguration.Controls.Add(this.textBox_Config_Info);
            this.TabConfiguration.Controls.Add(this.label15);
            this.TabConfiguration.Controls.Add(this.label14);
            this.TabConfiguration.Controls.Add(this.label3);
            this.TabConfiguration.Controls.Add(this.labelConfigPortCom);
            this.TabConfiguration.Controls.Add(this.numeric_config_port);
            this.TabConfiguration.Controls.Add(this.panel11);
            this.TabConfiguration.Controls.Add(this.panel10);
            this.TabConfiguration.Controls.Add(this.panel1);
            resources.ApplyResources(this.TabConfiguration, "TabConfiguration");
            this.TabConfiguration.Name = "TabConfiguration";
            this.TabConfiguration.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            resources.ApplyResources(this.numericUpDown1, "numericUpDown1");
            this.numericUpDown1.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Value = new decimal(new int[] {
            587,
            0,
            0,
            0});
            // 
            // label13
            // 
            resources.ApplyResources(this.label13, "label13");
            this.label13.Name = "label13";
            // 
            // checkBox_config_simulation
            // 
            resources.ApplyResources(this.checkBox_config_simulation, "checkBox_config_simulation");
            this.checkBox_config_simulation.Name = "checkBox_config_simulation";
            this.checkBox_config_simulation.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // checkBox_humidité
            // 
            resources.ApplyResources(this.checkBox_humidité, "checkBox_humidité");
            this.checkBox_humidité.Checked = true;
            this.checkBox_humidité.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_humidité.Name = "checkBox_humidité";
            this.checkBox_humidité.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // check_conf_ssl
            // 
            resources.ApplyResources(this.check_conf_ssl, "check_conf_ssl");
            this.check_conf_ssl.Name = "check_conf_ssl";
            this.check_conf_ssl.UseVisualStyleBackColor = true;
            // 
            // label_smtp_port
            // 
            resources.ApplyResources(this.label_smtp_port, "label_smtp_port");
            this.label_smtp_port.Name = "label_smtp_port";
            // 
            // button_conf_valider
            // 
            resources.ApplyResources(this.button_conf_valider, "button_conf_valider");
            this.button_conf_valider.Name = "button_conf_valider";
            this.button_conf_valider.UseVisualStyleBackColor = true;
            this.button_conf_valider.Click += new System.EventHandler(this.button_conf_valider_Click);
            // 
            // textbox_conf_destinataire
            // 
            resources.ApplyResources(this.textbox_conf_destinataire, "textbox_conf_destinataire");
            this.textbox_conf_destinataire.Name = "textbox_conf_destinataire";
            // 
            // textbox_conf_expediteur
            // 
            resources.ApplyResources(this.textbox_conf_expediteur, "textbox_conf_expediteur");
            this.textbox_conf_expediteur.Name = "textbox_conf_expediteur";
            // 
            // checkBox_conf_mail
            // 
            resources.ApplyResources(this.checkBox_conf_mail, "checkBox_conf_mail");
            this.checkBox_conf_mail.Name = "checkBox_conf_mail";
            this.checkBox_conf_mail.UseVisualStyleBackColor = true;
            // 
            // label24
            // 
            resources.ApplyResources(this.label24, "label24");
            this.label24.Name = "label24";
            // 
            // label23
            // 
            resources.ApplyResources(this.label23, "label23");
            this.label23.Name = "label23";
            // 
            // label22
            // 
            resources.ApplyResources(this.label22, "label22");
            this.label22.Name = "label22";
            // 
            // numeric_conf_temp_max
            // 
            resources.ApplyResources(this.numeric_conf_temp_max, "numeric_conf_temp_max");
            this.numeric_conf_temp_max.Name = "numeric_conf_temp_max";
            this.numeric_conf_temp_max.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // label21
            // 
            resources.ApplyResources(this.label21, "label21");
            this.label21.Name = "label21";
            // 
            // textBox_Config_Info
            // 
            resources.ApplyResources(this.textBox_Config_Info, "textBox_Config_Info");
            this.textBox_Config_Info.Name = "textBox_Config_Info";
            // 
            // label15
            // 
            resources.ApplyResources(this.label15, "label15");
            this.label15.Name = "label15";
            // 
            // label14
            // 
            resources.ApplyResources(this.label14, "label14");
            this.label14.Name = "label14";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // labelConfigPortCom
            // 
            resources.ApplyResources(this.labelConfigPortCom, "labelConfigPortCom");
            this.labelConfigPortCom.Name = "labelConfigPortCom";
            // 
            // numeric_config_port
            // 
            resources.ApplyResources(this.numeric_config_port, "numeric_config_port");
            this.numeric_config_port.Name = "numeric_config_port";
            this.numeric_config_port.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // panel11
            // 
            this.panel11.BackgroundImage = global::Station_environemental.Properties.Resources.Message_50;
            resources.ApplyResources(this.panel11, "panel11");
            this.panel11.Name = "panel11";
            // 
            // panel10
            // 
            this.panel10.BackgroundImage = global::Station_environemental.Properties.Resources.Temperature_Filled_50;
            resources.ApplyResources(this.panel10, "panel10");
            this.panel10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel10.Name = "panel10";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Station_environemental.Properties.Resources.stickers_logo_text;
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // TabGraphique
            // 
            this.TabGraphique.Controls.Add(this.Graphique1);
            resources.ApplyResources(this.TabGraphique, "TabGraphique");
            this.TabGraphique.Name = "TabGraphique";
            this.TabGraphique.UseVisualStyleBackColor = true;
            // 
            // Graphique1
            // 
            chartArea1.Name = "ChartArea1";
            this.Graphique1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.Graphique1.Legends.Add(legend1);
            resources.ApplyResources(this.Graphique1, "Graphique1");
            this.Graphique1.Name = "Graphique1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "temperature";
            this.Graphique1.Series.Add(series1);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Dashboard Filled-50.png");
            this.imageList1.Images.SetKeyName(1, "Settings-48.png");
            this.imageList1.Images.SetKeyName(2, "High Connection Filled-50.png");
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.panel_header.ResumeLayout(false);
            this.panel_header.PerformLayout();
            this.panel_temperature.ResumeLayout(false);
            this.panel_temperature.PerformLayout();
            this.panel_humidite.ResumeLayout(false);
            this.panel_humidite.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel_information.ResumeLayout(false);
            this.panel_information.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panelLog.ResumeLayout(false);
            this.panelLog.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.TabDashboard.ResumeLayout(false);
            this.TabConfiguration.ResumeLayout(false);
            this.TabConfiguration.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_conf_temp_max)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_config_port)).EndInit();
            this.TabGraphique.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Graphique1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Button buttondebut;
        private System.Windows.Forms.TextBox textBox_Etat_Connection;
        private System.Windows.Forms.RichTextBox textBox_log;
        private System.Windows.Forms.Label label_temp_princ;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label_mail_expediteur;
        private System.Windows.Forms.Label label_mail_destinataire;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label_tempmax;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label_mail_activation;
        private System.Windows.Forms.Panel panel_header;
        private System.Windows.Forms.Panel panel_temperature;
        private System.Windows.Forms.Panel panel_temp_logo;
        private System.Windows.Forms.Panel panel_humidite;
        private System.Windows.Forms.Label label_heure;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label_temp_titre;
        private System.Windows.Forms.Panel panel_information;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label_humi_princ;
        private System.Windows.Forms.Label label_titre_humi;
        private System.Windows.Forms.Panel panel_humi_logo;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panelLog;
        private System.Windows.Forms.Label Label_port_affichage;
        private System.Windows.Forms.Label label_vis_port;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage TabDashboard;
        private System.Windows.Forms.TabPage TabConfiguration;
        private System.Windows.Forms.Label labelConfigPortCom;
        private System.Windows.Forms.NumericUpDown numeric_config_port;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_Config_Info;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.NumericUpDown numeric_conf_temp_max;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox textbox_conf_expediteur;
        private System.Windows.Forms.CheckBox checkBox_conf_mail;
        private System.Windows.Forms.TextBox textbox_conf_destinataire;
        private System.Windows.Forms.Button button_conf_valider;
        private System.Windows.Forms.Label label_smtp_port;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox check_conf_ssl;
        private System.Windows.Forms.Label label_date;
        private System.Windows.Forms.TabPage TabGraphique;
        private System.Windows.Forms.DataVisualization.Charting.Chart Graphique1;
        private System.Windows.Forms.Label label_temp_degre;
        private System.Windows.Forms.Label label_temp_sec;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel_etat_connection;
        private System.Windows.Forms.CheckBox checkBox_humidité;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox checkBox_config_simulation;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}

