using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;
using System.Globalization;

 

namespace _1706x_Spectrometre
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        //**********************************
        // Pour test avec le TP2 de MINF
        //**********************************
        //public delegate void ReceiverD();
        //public ReceiverD myDelegate;
        //**********************************

        Point m_DownPos;
        Point m_UpPos;
        Graphics m_Graphic;
        int cnt = 0;
        
        double[] Tab_Spectrum = new double[401];


        // Ajout de la version D
        //***********************************************************
        // ====================================================
        //                      Port série
        // ====================================================
        // Pour le form de la configuration du port
        Form2 frm2;
        // Pour la liste de ports série disponibles
        public string[] availablePorts;
        // Pour le stockage de la trame
        string strMess;
        // Pour indiquer si une trame a été reçue
        bool DataAvailable = false;
        // Pour le nombre total de caractères dans un trame
        int MessageSize = 94;
        // ====================================================
        //              Filtrage des données
        // ====================================================
        // Pour la savuegarde des valeures après filtrage
        double[] Tab_SpectrumAverage = new double[401];
        //***********************************************************


        public Form1()
        {
            var culture = CultureInfo.GetCultureInfo("en-US");
          
            
            //Culture for any thread
            CultureInfo.DefaultThreadCurrentCulture = culture;

            InitializeComponent();

            // Set the read/write timeouts
            serialPort1.ReadTimeout = 500;
            serialPort1.WriteTimeout = 500;

            // Récupération des ports série disponibles
            GetPortComList();

            //**********************************
            // Pour test avec le TP2 de MINF
            //**********************************
            //myDelegate = new ReceiverD(GetRxData);
            //**********************************
        }
        //***************************************************************************
        //                      Lecture du fichier texte
        //***************************************************************************
        public void Lecture_fichier()
        {
            String[] line = new string[999];
            string Fichier = "./LedVal.txt";
            Int16 compteur = 0;
            
            try
            {
                //Pass the file path and file name to the StreamReader constructor
                StreamReader sr = new StreamReader(Fichier);
                tbCCT.Text = sr.ReadLine();
                tblongueurdonde.Text = sr.ReadLine();
                tbCRI.Text = sr.ReadLine();
                tbLUX.Text = sr.ReadLine();
                tbITime.Text = sr.ReadLine();
                //Read the first line of text
                line[0] = sr.ReadLine();
                //Continue to read until you reach end of file
                while (line[compteur] != null)
                {
                    compteur++;
                    //write the lie to console window
                    Console.WriteLine(line);
                    //Read the next line
                    line[compteur] = sr.ReadLine();

                }

                //close the file
                sr.Close();
                Console.ReadLine();
                for (compteur = 0; compteur < 400; compteur++)
                {
                    //lire les 400 valeurs
                    Tab_Spectrum[compteur] = Convert.ToDouble(line[compteur]);
                }
                

            }
            catch (Exception e)
            {
                MessageBox.Show("Exception: " + e.Message);
            }

            

        }
        //***************************************************************************
        //                    Affichage avec le bouton affiche Val
        //***************************************************************************
        private void BtAffiche_Click(object sender, EventArgs e)
        {
           //lire le fichier 
            Lecture_fichier();
            // Si données disponibles
            if(DataAvailable == true)
            {
                // Récupération les informations sur la mesure
                GetAndPrintMesureData(strMess);
                // Récupértion des valeurs mesurés
                GetSpectrumDatas(strMess, 4);
            }

            // Filtrage des données (lissage)
            MovingAverage(Convert.ToInt32(nudMovingAverageValue.Value));
            //afficher les valeur en graphique 
            Affiche_Val();
        }
        //***************************************************************************
        //                          Affichage des valeus mesurés
        //***************************************************************************
        private void Affiche_Val()
        {
            //init des variables 
            UInt16 Compteur_Affiche;
            //creation d'un PEN
            Pen ThePen;
            //creation de mon objet couleur
            Color Color_Affiche;
            //vriable pour l'affichage
            UInt16 Val_Compt = 0;

            //variable pour la couleur
            double Rouge = 255;
            double Vert = 0;
            double Bleu = 255;
            const double Val_Saut_Color = 2.4;

            //lier l'objet avec le panel 
            m_Graphic = plSpectrum.CreateGraphics();
            
            //mettre la position du trais a 0
            m_DownPos.Y = plSpectrum.Height;
            //remetre a 0 l'affichage
            m_Graphic.Clear(Color.WhiteSmoke);

            for (Compteur_Affiche = 0; Compteur_Affiche < 400; Compteur_Affiche++)
            {
                //changer la couleur du pen pour avoir la couleur de la lumiere
                Color_Affiche = Color.FromArgb(255, (int)Rouge, (int)Vert, (int)Bleu);
                ThePen = new Pen(Color_Affiche, (plSpectrum.Width / 400));

                //mettre la position du trais a faire
                m_DownPos.X = Compteur_Affiche;
                m_UpPos.X = Compteur_Affiche;
                m_UpPos.Y = (int)(plSpectrum.Height - (Tab_SpectrumAverage[Compteur_Affiche] * plSpectrum.Height));
                //dessiner le trais
                m_Graphic.DrawLine(ThePen, m_DownPos, m_UpPos);

                //faire une gestion de la couleur du trais
                if (Val_Compt == 0)
                {
                    Rouge -= Val_Saut_Color;
                    Vert += Val_Saut_Color;
                    if (Rouge <= 0|| Vert >=255)
                    {
                        Vert = 255;
                        Rouge = 0;
                        Val_Compt = 1;
                    }
                }
                else if (Val_Compt == 1)
                {
                    Bleu -= Val_Saut_Color;
                    Rouge += Val_Saut_Color;
                    if (Bleu <= 0 || Rouge >= 255)
                    {
                        Rouge = 255;
                        Bleu = 0;
                        Val_Compt = 2;
                    }
                }
                else if (Val_Compt == 2)
                {
                    Vert -= Val_Saut_Color;
                    if (Vert <= 0)
                    {
                        Vert = 0;
                    }
                }
            }
        }
        //***************************************************************************
        // Ouverture de la fenêtre de configuratio du port série en cliquant dans
        // la barre de menus sur : <<Port Série / Configuration du port>>
        //***************************************************************************
        private void ConfigurationDuPortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Contrôler si la fenêtre pour la configuration de port est ouverte
            // Si elle n'est pas ouverte => créer la fenêtre et l'afficher
            if (!(Application.OpenForms.OfType<Form2>().Any()))
            {
                frm2 = new Form2(this);
                frm2.Show();
            }
            // Si elle est ouverte => mettre en premier plan la fenêtre
            else
            {
                frm2.Activate();
            }
        }
        //***************************************************************************
        // Ouverture du port série en cliquant dans la barre de menus sur : 
        //                  <<Port Série / Open Port>>
        //***************************************************************************
        private void InitialiserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Ouvrir le port
            try
            {
                serialPort1.Open();
                lblPortStatus.Text = "OPEN";
            }
            catch (Exception Portserie)
            {
                MessageBox.Show("Exception: " + Portserie.Message);
            }

        }
        //***************************************************************************
        // Fermeture du port série en cliquant dans la barre de menus sur : 
        //                  <<Port Série / Close Port>>
        //***************************************************************************
        private void ArreterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.Close();
                lblPortStatus.Text = "CLOSED";
            }
            catch (Exception Portserie)
            {
                MessageBox.Show("Exception: " + Portserie.Message);
            }
        }
        //***************************************************************************
        // Fonction pour mettre à jour les labels d'information du port (dans Form1)
        // avec les paramètres choisis dans la Form2
        //***************************************************************************
        public void UpdatePortValues()
        {
            this.lblPort.Text = serialPort1.PortName.ToString();
            this.lblBd.Text = serialPort1.BaudRate.ToString();
            this.lblNbBits.Text = serialPort1.DataBits.ToString();
            this.lblParityBit.Text = serialPort1.Parity.ToString();
            this.lblStopBits.Text = serialPort1.StopBits.ToString();
            this.lblHandshake.Text = serialPort1.Handshake.ToString();
        }
        //***************************************************************************
        //             Fonction pour la lecture de données du port série
        //***************************************************************************
        public void GetRxData()
        {
            // Buffer pour enregistres la trame reçue
            byte[] RxMess = new byte[MessageSize];

            //***************************************************************************
            //                      Pour test avec le TP2 de MINF (PWM RS232)
            //***************************************************************************
            //do
            //{
            //    RxMess[0] = (byte)serialPort1.ReadByte();
            //} while (RxMess[0] != 0xAA);
            //
            //if (serialPort1.BytesToRead >= 4)
            //{
            //    for (i = 1; i < 5; i++)
            //    {
            //        RxMess[i] = (byte)serialPort1.ReadByte();
            //    }
            //
            //    tblongueurdonde.Text = ConvUsignedToSignedString(RxMess[1]);
            //    tbITime.Text = ConvUsignedToSignedString(RxMess[2]);
            //}
            //***************************************************************************

            // Attendre que le nombre de bytes disponibles est égal ou supérieur à la taille de la trame à recevoir (MessageSize)
            // A changer la valeur de Message Size dans la prochaine  version
            if (serialPort1.BytesToRead >= MessageSize)
            {
                cnt = (cnt + 1) % 10;
                //tbCCT.Text = cnt.ToString();
                // Attendre le début du message => '!'
                do
                {
                    RxMess[0] = (byte)serialPort1.ReadByte();
                } while (RxMess[0] != '!');
            
                for (int i = 1; i < MessageSize; i++)
                {
                    RxMess[i] = (byte)serialPort1.ReadByte();
                }

                // Contrôle si le dernier byte de la trame est un '#'
                if(RxMess[MessageSize-1] == '#')
                {
                    // Conversion des caractères reçus en string
                    // pour la recherche des informations avec du texte
                    strMess = Encoding.ASCII.GetString(RxMess);
                    // Indiquer qu'il y a une trame réçue
                    DataAvailable = true;
                } 
            }
        }
        //***************************************************************************
        //        Fonction pour chercher un string dans la trame et récupérer 
        //        sa valeur 
        //***************************************************************************
        string SearchTextandGetValue(string Message, string TextToFind, int NbValue)
        {
            int idx;

            try
            {
                // Recherche de l'index du début du string à trouver
                idx = Message.IndexOf(TextToFind);
                // si le string est dans Message
                if (idx != -1)
                {
                    // Récupération de la valeur
                    return Message.Substring(idx + TextToFind.Length, NbValue);
                }
                // si le string n'est pas dans Message
                else
                {
                    return "ERROR";
                }
            }
            catch (Exception index)
            {
                MessageBox.Show("Exception: " + "pas de trame réçue." + index.Message);
                return "ERROR";
            }            
        }
        //***************************************************************************
        //   Fonction pour chercher et récupérer les information sur la mesure 
        //   afin de les afficher dans leurs textbox : 
        //         CCT / CRI / LUX / LO (longueur d'onde) / ITIme
        //===========================================================================
        //                Message = String où chercher les données
        //***************************************************************************
        void GetAndPrintMesureData(string Message)
        {
            // Récupération de la valeur de CCT et affichage dans son textbox
            tbCCT.Text = SearchTextandGetValue(Message, "CCT=", 4);
            // Récupération de la valeur de la longueur d'onde et affichage dans son textbox
            tblongueurdonde.Text = SearchTextandGetValue(Message, "LO=", 4);
            // Récupération de la valeur de l'indice de rendu de couleur(CRI) et affichage dans son textbox
            tbCRI.Text = SearchTextandGetValue(Message, "CRI=", 3);
            // Récupération des la valeur de LUX et affichage dans son textbox
            tbLUX.Text = SearchTextandGetValue(Message, "LUX=", 4);
            // Récupération de la valeur de ITime et affichage dans son textbox
            tbITime.Text = SearchTextandGetValue(Message, "ITime=", 4);
        }
        //***************************************************************************
        //        Fonction pour chercher et récupérer les valeurs mesurées
        //        par le spectromètre
        //===========================================================================
        //                Message = String où chercher les données
        //                NbDatas = Nombre de valeurs à récupérer
        //***************************************************************************
        void GetSpectrumDatas(string Message, int NbDatas)
        {
            // Récupération des valeurs
            for (int i = 0; i < NbDatas; i++)
            {
                // Recherche de du string "@XXXX=" pour la recherche des valeurs mesurées dans la trame
                // parametre ('@' + (i + 1).ToString().PadLeft(3, '0') + '=') pour avoir les strings
                // dépuis "@001=" jusqu'à la valeur NbDatas
                // Exemple:
                // NbDatas = 100      max = "@100=" 
                Tab_Spectrum[i] = Convert.ToDouble(SearchTextandGetValue(Message, '@' + (i + 1).ToString().PadLeft(3, '0') + '=', 8));
            }
        }
        //***************************************************************************
        //        Lors de la réception de données par le port série
        //***************************************************************************
        private void SerialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            // Pour test avec le TP2 de MINF afin de pouvoir afficher les valeurs dans les textbox avec le delegate
            //this.Invoke(myDelegate);
            // ----------------------------------------
            // Récupération d'une trame à partir des données reçues
            GetRxData();
        }
        //***************************************************************************
        //        Fonction pour récupérer la liste de ports disponibles
        //***************************************************************************
        public void GetPortComList()
        {
            availablePorts = SerialPort.GetPortNames();
        }
        //***************************************************************************
        //        Fonction pour le filtrage des données mesurés
        //        avec un moyenne glissante
        //===========================================================================
        //   NbDatas = nombre de valeurs pour le calcul de la moyenne glissante
        //***************************************************************************
        void MovingAverage(int NbDatas)
        {
            // 
            double TempAverage = 0;
            // Si Valeur de filtrage > que 1 => filtrage des données 
            if (NbDatas > 1)
            {
                // Reset tableau avec les valeurs filtrés
                for (int i = 0; i < 400; i++)
                {
                    Tab_SpectrumAverage[i] = 0;
                }
                
                // filtrage des valeurs avec moyenne glissante
                for (int i = NbDatas; i < 400; i++)
                {
                    for (int j = 0; j < NbDatas; j++)
                    {
                        TempAverage = TempAverage + Tab_Spectrum[i - j];
                    }
                    Tab_SpectrumAverage[i] = TempAverage / (double)NbDatas;
                    TempAverage = 0;
                }
            }
            // pas de filtrage des données
            else
            {
                for (int i = 0; i < 400; i++)
                {
                    Tab_SpectrumAverage[i] = Tab_Spectrum[i];
                }
            }
            
        }
        //***************************************************************************
        //                  Pour test avec le TP2 de MINF (PWM RS232)
        //***************************************************************************
        //string ConvUsignedToSignedString(byte val)
        //{
        //    string Res = "";
        //    short tmp;
        //    if (val < 128)
        //    {
        //        tmp = val;
        //    }
        //    else
        //    {
        //        tmp = val;
        //        tmp -= 256;
        //    }
        //    Res = tmp.ToString();
        //    return Res;
        //}
        //***************************************************************************
    }
}
