using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace _1706x_Spectrometre
{
    public partial class Form2 : Form
    {
        // Pointeur / référence pour la Form1 active
        public Form1 _spectrometre;
        public Form2(Form1 formSpectrometre)
        {
            InitializeComponent();
            // Référence pour la Forme1 active passée en paramètre
            this._spectrometre = formSpectrometre;
            // Ajout des ports disponibles dans le comobox "Port"
            UpdateAvailablePorts();
            // Sélection du premier port disponible
            cboPortTxt.SelectedIndex = 0;
            // Fixer la baudrate par défaut à 9600 bds
            nudBaudRate.Value = 9600;
            // Fixer le nombre de bits par défaut à 8 bits
            nudNbBits.Value = 8;
            // Ajout des valeurs de parité dans le combobox "Bit de parité"
            cboParity.Items.AddRange(Enum.GetNames(typeof(Parity)));
            cboParity.SelectedIndex = 0;
            // Ajout des valeurs de bits de stop dans el combobox "Bit de stop"
            cboStopBit.Items.AddRange(Enum.GetNames(typeof(StopBits)));
            cboStopBit.Items.Remove("None");
            cboStopBit.SelectedIndex = 0;
            // Ajout des valeurs de handshake dans el combobox "handshake"
            cboHandShake.Items.AddRange(Enum.GetNames(typeof(Handshake)));
            cboHandShake.SelectedIndex = 0;
        }
        //***************************************************************************
        //                      Application des paramètres choisi
        //***************************************************************************
        private void BtnApplyPortSettings_Click(object sender, EventArgs e)
        {
            // Application des paramètres choisis dans serialPort1
            // ====================================================
            // Port
            this._spectrometre.serialPort1.PortName = cboPortTxt.Text;
            // Baudrate
            this._spectrometre.serialPort1.BaudRate = Convert.ToInt32(nudBaudRate.Value);
            // Nombre de bits
            this._spectrometre.serialPort1.DataBits = Convert.ToInt32(nudNbBits.Value);
            // Bit de parité
            this._spectrometre.serialPort1.Parity = (Parity)Enum.Parse(typeof(Parity), cboParity.SelectedItem.ToString());
            // Bit de stop
            this._spectrometre.serialPort1.StopBits = (StopBits)Enum.Parse(typeof(StopBits), cboStopBit.SelectedItem.ToString());
            // contrôle de flux (handshake)
            this._spectrometre.serialPort1.Handshake = (Handshake)Enum.Parse(typeof(Handshake), cboHandShake.SelectedItem.ToString());
            // Affichage des paramètres choisis dans les labels de la Form1
            this._spectrometre.UpdatePortValues();
        }
        //***************************************************************************
        //        Annuler les paramètres choisis et fermeture de la Form2
        //***************************************************************************
        private void BtnCancelPortSettings_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //***************************************************************************
        //                    Mise à jour des ports disponibles
        //***************************************************************************
        private void BtnUpdatePort_Click(object sender, EventArgs e)
        { 
            // Mise à jour des ports disponibles dans le comobox "Port"
            UpdateAvailablePorts();
        }
        //***************************************************************************
        //        Fonction pour récupérer la liste de ports disponibles
        //        et  mettre à jour son combobox
        //***************************************************************************
        void UpdateAvailablePorts()
        {
            // Effacer les anciens ports du combobox
            cboPortTxt.Items.Clear();
            // Lecture et récupération des ports disponibles
            this._spectrometre.GetPortComList();    
            // Ajouter les nouveaux ports dans le combobox
            cboPortTxt.Items.AddRange(this._spectrometre.availablePorts);
        }
    }
}
