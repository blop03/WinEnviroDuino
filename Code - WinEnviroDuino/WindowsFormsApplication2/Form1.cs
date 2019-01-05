using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Windows.Forms.DataVisualization.Charting;
using System.Threading;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        //Déclaration des variables
        string RxString;
        string RxStringtemp;
        string Maildestinataire;
        string Mailexpediteur;
        string MailSSL ;
        int MailSMTP = 587;
        bool MailEtat;
        bool humiditeetat;
        int tempmax;
        int nombre_ligne_affichage_logs;
        string[] RxStringtemptabtronqué ;
        string[] Rxstringdatetime;
        int graph_nbr_colonne_afficher = 5;
        int z = 0;
        Random rnd = new Random();
        Thread simulation_lancement;

        //Thread




        string MailObjet = "Chaleur Salle Serveur";
        int i = 0; //Compteur pour Log
        int y = 0; //Compteur pour mail

        public Form1()
        {
            InitializeComponent();
            //Initialisation du serial port
            serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(serialPort1_DataReceived);

            label_vis_port.Text = serialPort1.PortName;
            textbox_conf_destinataire.Text = "test@gmail.com";
            textbox_conf_expediteur.Text = "test@gmail.com";
            label_date.Text = DateTime.Now.ToShortDateString();
            RxStringtemptabtronqué = new string[20];
            Rxstringdatetime = new string[20];
            
            //SerialPort Config
            serialPort1.ReceivedBytesThreshold = 6; // Trés important. Le nombre d'octets en mémoire

            //Configuration des logs
            nombre_ligne_affichage_logs = 25;

            //Lancement de l'heure
            Thread heure = new Thread(AfficherHeure);
            
            //Lancement de thread
            heure.Start();

        }

        private void buttondebut_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.Open();
                if (serialPort1.IsOpen)
                {
                    buttondebut.Enabled = false;
                    buttonStop.Enabled = true;
                    textBox_log.ReadOnly = false;
                    textBox_Etat_Connection.Text = "Connection ouverte";
                    panel_etat_connection.BackgroundImage = Station_environemental.Properties.Resources.button_green;
                }
            }
            catch (Exception ex)
            {
                //textBox2.Text = ex.ToString();
                MessageBox.Show(ex.ToString());
            }
        }

        private void buttonStop_Click_1(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
                buttondebut.Enabled = true;
                buttonStop.Enabled = false;
                textBox_log.ReadOnly = true;
                textBox_Etat_Connection.Text = "Connection fermé";
            }
        }



        private void DisplayText(object sender, EventArgs e)
        {
            
            //Affichage dans le dashboard
            textBox_log.Text = RxString;
            textBox_Etat_Connection.Text = "Données de l'arduino reçu";

            //Affichage dans le label de température principale
            if (RxString == "") { }
            else
            {
                string RxStringtemptronquer = RxStringtemp.Substring(0, 2);
                label_temp_princ.Text = RxStringtemptronquer;

                string RxStringtemptronquer_sec = RxStringtemp.Substring(2, 1);
                label_temp_sec.Text = RxStringtemptronquer_sec;

                string RxStringDatetimenow = DateTime.Now.ToString();

                //---Création du graphique---

                if (z < graph_nbr_colonne_afficher)
                {
                    RxStringtemptabtronqué[z] = RxStringtemptronquer;
                    Rxstringdatetime[z] = RxStringDatetimenow;
                    Graphique1.Series["temperature"].Points.AddXY(Rxstringdatetime[z], RxStringtemptabtronqué[z]);
                }
                else { 

                    //Décale toutes les valeurs vers la gauche
                    for (int i = 1; i < RxStringtemptabtronqué.Count(); i++)
                    { RxStringtemptabtronqué[i - 1] = RxStringtemptabtronqué[i];
                      Rxstringdatetime[i - 1] = Rxstringdatetime[i];
                    }
                    //tableau[length - 1] = tmp;
                    RxStringtemptabtronqué[graph_nbr_colonne_afficher-1] = RxStringtemptronquer;
                    Rxstringdatetime[graph_nbr_colonne_afficher - 1] = RxStringDatetimenow;
                    Graphique1.Series["temperature"].Points.Clear();

                    for (int i = 0; i < graph_nbr_colonne_afficher; i++)
                    {
                        Graphique1.Series["temperature"].Points.AddXY(Rxstringdatetime[i], RxStringtemptabtronqué[i]);
                    }

                }




                z++;

                //--réafficher tout le tableau---
               
                

            //int RxStringtempfloat = int.Parse(RxStringtemptronquer);

                //if (y < 1)
               // {
                //    if (RxStringtempfloat > tempmax)
                //    {
                //        Envoie_de_mail();
                //        y++;
                //    }
//
               // }
               // textBox2.Text = "Données de l'arduino reçu";
            }
        }
        private void serialPort1_DataReceived (object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            //Lecture du port . Sortie en 2400
            RxStringtemp = serialPort1.ReadExisting();

            //Vérification du bon format de la récupération
            if (RxStringtemp.Length == 6) { Port_serie_ajout_log(); }
          
            //Lancement de l'affichage
            this.Invoke(new EventHandler(DisplayText));
        }

        private void Envoie_de_mail()

        {
            if (checkBox_conf_mail.Checked == true)
            { 
            try
                {
                    MailMessage mail = new MailMessage();
                    SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
                    mail.From = new MailAddress(Mailexpediteur);
                    mail.To.Add(Maildestinataire);
                    mail.Subject = MailObjet;
                    mail.Body = "La température de la salle serveur a dépassé sa température de sécurité. Elle est de " + RxStringtemp;

                    //System.Net.Mail.Attachment attachment;
                    //attachment = new System.Net.Mail.Attachment("c:/textfile.txt");
                    //mail.Attachments.Add(attachment);

                    SmtpServer.Port = MailSMTP;
                    SmtpServer.Credentials = new System.Net.NetworkCredential("auth utilisateur", "mdp");
                    SmtpServer.EnableSsl = true;

                    SmtpServer.Send(mail);
                }
                catch (Exception ex)
                {
                    //textBox2.Text = ex.ToString();
                   MessageBox.Show(ex.ToString());
                }
            }

        }

        private void button_conf_valider_Click(object sender, EventArgs e)
        {

            // --- Configuration arduino ---

            //Port configuration
            serialPort1.PortName = "COM" + numeric_config_port.Value ;
            label_vis_port.Text = "COM" + numeric_config_port.Value ;

            //Mode simulation
            if (checkBox_config_simulation.Checked == true)
            {
                Thread simulation_lancement = new Thread(simulation);
                simulation_lancement.Start();
            }
            if (checkBox_config_simulation.Checked == false)
            {
                //if (simulation_lancement.IsAlive == true)
                //{
                 //   simulation_lancement.Abort();
                //}
            }


            //--- Configuration température

            //Température maximale
            tempmax = Convert.ToInt32(numeric_conf_temp_max.Value);
            label_tempmax.Text = numeric_conf_temp_max.Value.ToString() + "°";

            //Activation de l'humidité
            if (checkBox_conf_mail.Checked == true) { Activation_humidite(); };
            if (checkBox_conf_mail.Checked == false) { Desactivation_humidite(); };

            //Mail
            MailEtat = checkBox_conf_mail.Checked;
            Maildestinataire = textbox_conf_destinataire.Text;
            Mailexpediteur = textbox_conf_expediteur.Text;

            if (MailEtat == true) { label_mail_activation.Text = "Oui"; }
            if (MailEtat == false) { label_mail_activation.Text = "Non"; }

            label11.Text = textbox_conf_destinataire.Text;
            label12.Text = textbox_conf_destinataire.Text;

        }

        public void AfficherHeure()
        {
            label_heure.Text = DateTime.Now.Hour + ":" + DateTime.Now.Minute;
            Thread.Sleep(10);
        }

        public void Desactivation_humidite()
        {
            panel_humidite.Visible = false;
            panelLog.Location = new Point(697, 103);
            textBox_log.Size = new Size(365, 273);
        }

        public void Activation_humidite()
        {
            panel_humidite.Visible = false;
            panelLog.Location = new Point(255, 697);
            textBox_log.Size = new Size(365, 120);
        }

        public void Port_serie_ajout_log()
        {   
            if (i < nombre_ligne_affichage_logs)
            { RxString = RxString + DateTime.Now + " " + RxStringtemp; }
            else
            {
                RxString = "";
                i = 0;
            }
            i++;
        }

        public void simulation()
        {
            RxStringtemp = rnd.Next(2000, 2500).ToString();

            Port_serie_ajout_log();

            this.Invoke(new EventHandler(DisplayText));
            Thread.Sleep(200);
        }


        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Fermeture du port a l'extinction de l'application
            if (serialPort1.IsOpen) { serialPort1.Close(); }
        }




        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
        }
    
