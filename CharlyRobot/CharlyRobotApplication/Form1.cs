using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CharlyRobotApplication
{
    public partial class MainWindow : Form
    {

        // private CharlyRobot app;
        private SerialPort portCharlyRobot;
        private SerialPort portArduino;
        private bool isConnectingCharlyRobot = false;
        private bool isConnectingArduino = false;
        private bool isAskPosition = false;
        private bool second = false;
        float x;
        float y;
        float z;

        public MainWindow(/*CharlyRobot app*/)
        {
            //this.app = app;
            InitializeComponent();
            
            //on commence par lister les voies séries présentes
            String[] ports = SerialPort.GetPortNames(); //fonction statique
            //on ajoute les ports au combo box
            foreach (String s in ports)
            {
                comboBoxPortCharlyRobot.Items.Add(s);
                comboBoxPortArduino.Items.Add(s);
            }

            updatePosition();
        }

        private void enableButtons()
        {
            this.buttonDown.Enabled = true;
            this.buttonUp.Enabled = true;
            this.buttonLeft.Enabled = true;
            this.buttonRight.Enabled = true;
            this.buttonZDown.Enabled = true;
            this.buttonZUp.Enabled = true;
            this.buttonInit.Enabled = true;
        }
        private void disableButtons()
        {
            this.buttonDown.Enabled = false;
            this.buttonUp.Enabled = false;
            this.buttonLeft.Enabled = false;
            this.buttonRight.Enabled = false;
            this.buttonZDown.Enabled = false;
            this.buttonZUp.Enabled = false;
            this.buttonInit.Enabled = false;
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {    //on gère la connexion/déconnexion
            if (!isConnectingCharlyRobot) //alors on connecte
            {
                if (comboBoxPortCharlyRobot.SelectedItem == null)
                    return;

                //crée un nouvel objet voie série
                portCharlyRobot = new SerialPort();
                //règle la voie série
                portCharlyRobot.BaudRate = 9600; //parse en int le combo des vitesses
                portCharlyRobot.DataBits = 8;
                portCharlyRobot.StopBits = StopBits.One;
                portCharlyRobot.Parity = Parity.None;
                portCharlyRobot.PortName = comboBoxPortCharlyRobot.SelectedItem.ToString(); //récupère le nom sélectionné

                //ajoute un gestionnaire de réception pour la réception de donnée sur la voie série
                portCharlyRobot.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandlerCharlyRobot);

                portCharlyRobot.Open(); //ouvre la voie série
                portCharlyRobot.Write("@07\n\r");
                portCharlyRobot.Write("@0d4000,4000,2000\n\r");

                buttonConnectCharlyRobot.Text = "Deconnecter";
                isConnectingCharlyRobot = true;
                if (portArduino != null && portArduino.IsOpen)
                    this.enableButtons();
            }
            else //sinon on déconnecte
            {
                portCharlyRobot.Close(); //ferme la voie série
                buttonConnectCharlyRobot.Text = "Connecter";
                this.disableButtons();
                isConnectingCharlyRobot = false;
            }
        }

        //gestionnaire de la réception de caractère
        private void DataReceivedHandlerCharlyRobot(object sender, SerialDataReceivedEventArgs e)
        {
            String texte = portCharlyRobot.ReadExisting();
            if (isAskPosition)
            {
                if (second) {
                    this.calculatePosition(texte);
                    second =false;
                } else
                    second = true;
            }
        }

        private void buttonConnectArduino_Click(object sender, EventArgs e)
        {
            //on gère la connexion/déconnexion
            if (!isConnectingArduino) //alors on connecte
            {
                if (comboBoxPortArduino.SelectedItem == null)
                    return;

                //crée un nouvel objet voie série
                portArduino = new SerialPort();
                //règle la voie série
                portArduino.BaudRate = 9600; //parse en int le combo des vitesses
                portArduino.DataBits = 8;
                portArduino.StopBits = StopBits.One;
                portArduino.Parity = Parity.None;
                portArduino.PortName = comboBoxPortArduino.SelectedItem.ToString(); //récupère le nom sélectionné

                //ajoute un gestionnaire de réception pour la réception de donnée sur la voie série
                portArduino.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);

                portArduino.Open(); //ouvre la voie série

                buttonConnectArduino.Text = "Deconnecter";
                isConnectingArduino = true;
                LEDButton.BackColor = Color.Red;
                if (portCharlyRobot != null && portCharlyRobot.IsOpen)
                    this.enableButtons();
            }
            else //sinon on déconnecte
            {
                portArduino.Close(); //ferme la voie série
                buttonConnectArduino.Text = "Connecter";
                isConnectingArduino = false;
            }
        }

        //gestionnaire de la réception de caractère
        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            String texte = portArduino.ReadExisting();
            SetText(texte);
            if (texte.Equals("1"))
            {
                LEDButton.BackColor = Color.Green;
                stop();
            }
            else
                LEDButton.BackColor = Color.Red;
        }


        delegate void SetTextCallback(string text);

        private void SetText(string text)
        {
            if (label3.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                label3.Invoke(d, new object[] { text });
            }
            else
                label3.Text += text;
        }

        private void stop()
        {
            // Commande Stop
            byte[] STOP = { 255 };
            portCharlyRobot.Write(STOP, 0, 1);
            askPosition();
        }

        private void buttonUp_Click(object sender, EventArgs e)
        {
            if (y > 0)
            {
                portCharlyRobot.Write("@0a0,2000,-400,2000,0,2000,0,400\n\r");
                y -= 5;
                updatePosition();
            }
        }

        private void buttonDown_Click(object sender, EventArgs e)
        {
            portCharlyRobot.Write("@0a0,2000,400,2000,0,2000,0,400\n\r");
            y += 5;
            updatePosition();
        }

        private void buttonRight_Click(object sender, EventArgs e)
        {
            portCharlyRobot.Write("@0a400,2000,0,2000,0,2000,0,400\n\r");
            x += 5;
            updatePosition();
        }

        private void buttonLeft_Click(object sender, EventArgs e)
        {
            if (x > 0)
            {
                portCharlyRobot.Write("@0a-400,2000,0,2000,0,2000,0,400\n\r");
                x -= 5;
                updatePosition();
            }
        }

        private void buttonZDown_Click(object sender, EventArgs e)
        {
                portCharlyRobot.Write("@0a0,2000,0,2000,400,2000,0,400\n\r");
                z += 5;
                updatePosition();
        }

        private void buttonZUp_Click(object sender, EventArgs e)
        {
            if (z > 0)
            {
                portCharlyRobot.Write("@0a0,2000,0,2000,-400,2000,0,400\n\r");
                z -= 5;
                updatePosition();
            }
        }

        private void buttonInit_Click(object sender, EventArgs e)
        {
            portCharlyRobot.Write("@0r7\n\r");
            portCharlyRobot.Write("@0a0,2000,0,2000,11500,400,0,400\n\r");
            // descendre a vitesse constante
            x = y = z = 0;
            updatePosition();
        }

        private void askPosition()
        {
            portCharlyRobot.Write("@0P\n\r");
            portCharlyRobot.Write("@0P\n\r");
            isAskPosition = true;
        }

        private void calculatePosition(String s)
        {
            x = int.Parse(s.Substring(1, 6), System.Globalization.NumberStyles.HexNumber);
            y = int.Parse(s.Substring(7, 6), System.Globalization.NumberStyles.HexNumber);
            z = int.Parse(s.Substring(13, 6), System.Globalization.NumberStyles.HexNumber);
            SetText("x:" + x + " y:" + y + " z:" + z);
            //updatePosition();
        }

        private void updatePosition()
        {
            textBoxX.Text = x + "0 um";
            textBoxY.Text = y + "0 um";
            textBoxZ.Text = z + "0 um";
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            stop();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
