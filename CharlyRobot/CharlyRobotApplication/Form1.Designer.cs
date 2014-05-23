namespace CharlyRobotApplication
{
    partial class MainWindow
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
            this.buttonUp = new System.Windows.Forms.Button();
            this.buttonDown = new System.Windows.Forms.Button();
            this.buttonLeft = new System.Windows.Forms.Button();
            this.buttonRight = new System.Windows.Forms.Button();
            this.buttonZDown = new System.Windows.Forms.Button();
            this.buttonZUp = new System.Windows.Forms.Button();
            this.textBoxX = new System.Windows.Forms.TextBox();
            this.textBoxZ = new System.Windows.Forms.TextBox();
            this.textBoxY = new System.Windows.Forms.TextBox();
            this.labelX = new System.Windows.Forms.Label();
            this.labelZ = new System.Windows.Forms.Label();
            this.labelY = new System.Windows.Forms.Label();
            this.comboBoxPortCharlyRobot = new System.Windows.Forms.ComboBox();
            this.buttonConnectCharlyRobot = new System.Windows.Forms.Button();
            this.buttonInit = new System.Windows.Forms.Button();
            this.comboBoxPortArduino = new System.Windows.Forms.ComboBox();
            this.buttonConnectArduino = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonStop = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.LEDButton = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // buttonUp
            // 
            this.buttonUp.Enabled = false;
            this.buttonUp.Location = new System.Drawing.Point(420, 69);
            this.buttonUp.Name = "buttonUp";
            this.buttonUp.Size = new System.Drawing.Size(75, 23);
            this.buttonUp.TabIndex = 0;
            this.buttonUp.Text = "▲";
            this.buttonUp.UseVisualStyleBackColor = true;
            this.buttonUp.Click += new System.EventHandler(this.buttonUp_Click);
            // 
            // buttonDown
            // 
            this.buttonDown.Enabled = false;
            this.buttonDown.Location = new System.Drawing.Point(420, 127);
            this.buttonDown.Name = "buttonDown";
            this.buttonDown.Size = new System.Drawing.Size(75, 23);
            this.buttonDown.TabIndex = 1;
            this.buttonDown.Text = "▼";
            this.buttonDown.UseVisualStyleBackColor = true;
            this.buttonDown.Click += new System.EventHandler(this.buttonDown_Click);
            // 
            // buttonLeft
            // 
            this.buttonLeft.Enabled = false;
            this.buttonLeft.Location = new System.Drawing.Point(346, 98);
            this.buttonLeft.Name = "buttonLeft";
            this.buttonLeft.Size = new System.Drawing.Size(75, 23);
            this.buttonLeft.TabIndex = 2;
            this.buttonLeft.Text = "◄";
            this.buttonLeft.UseVisualStyleBackColor = true;
            this.buttonLeft.Click += new System.EventHandler(this.buttonLeft_Click);
            // 
            // buttonRight
            // 
            this.buttonRight.Enabled = false;
            this.buttonRight.Location = new System.Drawing.Point(491, 98);
            this.buttonRight.Name = "buttonRight";
            this.buttonRight.Size = new System.Drawing.Size(75, 23);
            this.buttonRight.TabIndex = 3;
            this.buttonRight.Text = "►";
            this.buttonRight.UseVisualStyleBackColor = true;
            this.buttonRight.Click += new System.EventHandler(this.buttonRight_Click);
            // 
            // buttonZDown
            // 
            this.buttonZDown.Enabled = false;
            this.buttonZDown.Location = new System.Drawing.Point(662, 127);
            this.buttonZDown.Name = "buttonZDown";
            this.buttonZDown.Size = new System.Drawing.Size(75, 23);
            this.buttonZDown.TabIndex = 5;
            this.buttonZDown.Text = "▼";
            this.buttonZDown.UseVisualStyleBackColor = true;
            this.buttonZDown.Click += new System.EventHandler(this.buttonZDown_Click);
            // 
            // buttonZUp
            // 
            this.buttonZUp.Enabled = false;
            this.buttonZUp.Location = new System.Drawing.Point(662, 69);
            this.buttonZUp.Name = "buttonZUp";
            this.buttonZUp.Size = new System.Drawing.Size(75, 23);
            this.buttonZUp.TabIndex = 4;
            this.buttonZUp.Text = "▲";
            this.buttonZUp.UseVisualStyleBackColor = true;
            this.buttonZUp.Click += new System.EventHandler(this.buttonZUp_Click);
            // 
            // textBoxX
            // 
            this.textBoxX.Enabled = false;
            this.textBoxX.Location = new System.Drawing.Point(346, 177);
            this.textBoxX.Name = "textBoxX";
            this.textBoxX.Size = new System.Drawing.Size(100, 20);
            this.textBoxX.TabIndex = 6;
            // 
            // textBoxZ
            // 
            this.textBoxZ.Enabled = false;
            this.textBoxZ.Location = new System.Drawing.Point(662, 177);
            this.textBoxZ.Name = "textBoxZ";
            this.textBoxZ.Size = new System.Drawing.Size(100, 20);
            this.textBoxZ.TabIndex = 7;
            // 
            // textBoxY
            // 
            this.textBoxY.Enabled = false;
            this.textBoxY.Location = new System.Drawing.Point(505, 177);
            this.textBoxY.Name = "textBoxY";
            this.textBoxY.Size = new System.Drawing.Size(100, 20);
            this.textBoxY.TabIndex = 8;
            // 
            // labelX
            // 
            this.labelX.AutoSize = true;
            this.labelX.Location = new System.Drawing.Point(324, 180);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(20, 13);
            this.labelX.TabIndex = 9;
            this.labelX.Text = "X :";
            this.labelX.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelZ
            // 
            this.labelZ.AutoSize = true;
            this.labelZ.Location = new System.Drawing.Point(640, 180);
            this.labelZ.Name = "labelZ";
            this.labelZ.Size = new System.Drawing.Size(20, 13);
            this.labelZ.TabIndex = 10;
            this.labelZ.Text = "Z :";
            this.labelZ.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelY
            // 
            this.labelY.AutoSize = true;
            this.labelY.Location = new System.Drawing.Point(482, 180);
            this.labelY.Name = "labelY";
            this.labelY.Size = new System.Drawing.Size(20, 13);
            this.labelY.TabIndex = 11;
            this.labelY.Text = "Y :";
            this.labelY.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBoxPortCharlyRobot
            // 
            this.comboBoxPortCharlyRobot.FormattingEnabled = true;
            this.comboBoxPortCharlyRobot.Location = new System.Drawing.Point(12, 24);
            this.comboBoxPortCharlyRobot.Name = "comboBoxPortCharlyRobot";
            this.comboBoxPortCharlyRobot.Size = new System.Drawing.Size(121, 21);
            this.comboBoxPortCharlyRobot.TabIndex = 12;
            // 
            // buttonConnectCharlyRobot
            // 
            this.buttonConnectCharlyRobot.Location = new System.Drawing.Point(12, 60);
            this.buttonConnectCharlyRobot.Name = "buttonConnectCharlyRobot";
            this.buttonConnectCharlyRobot.Size = new System.Drawing.Size(121, 23);
            this.buttonConnectCharlyRobot.TabIndex = 13;
            this.buttonConnectCharlyRobot.Text = "Connecter";
            this.buttonConnectCharlyRobot.UseVisualStyleBackColor = true;
            this.buttonConnectCharlyRobot.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // buttonInit
            // 
            this.buttonInit.Enabled = false;
            this.buttonInit.Location = new System.Drawing.Point(84, 114);
            this.buttonInit.Name = "buttonInit";
            this.buttonInit.Size = new System.Drawing.Size(121, 23);
            this.buttonInit.TabIndex = 14;
            this.buttonInit.Text = "Init";
            this.buttonInit.UseVisualStyleBackColor = true;
            this.buttonInit.Click += new System.EventHandler(this.buttonInit_Click);
            // 
            // comboBoxPortArduino
            // 
            this.comboBoxPortArduino.FormattingEnabled = true;
            this.comboBoxPortArduino.Location = new System.Drawing.Point(163, 24);
            this.comboBoxPortArduino.Name = "comboBoxPortArduino";
            this.comboBoxPortArduino.Size = new System.Drawing.Size(121, 21);
            this.comboBoxPortArduino.TabIndex = 15;
            // 
            // buttonConnectArduino
            // 
            this.buttonConnectArduino.Location = new System.Drawing.Point(163, 60);
            this.buttonConnectArduino.Name = "buttonConnectArduino";
            this.buttonConnectArduino.Size = new System.Drawing.Size(121, 23);
            this.buttonConnectArduino.TabIndex = 16;
            this.buttonConnectArduino.Text = "Connecter";
            this.buttonConnectArduino.UseVisualStyleBackColor = true;
            this.buttonConnectArduino.Click += new System.EventHandler(this.buttonConnectArduino_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "CharlyRobot";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(166, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Arduino";
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(473, 279);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(75, 23);
            this.buttonStop.TabIndex = 19;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(365, 348);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "label3";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // LEDButton
            // 
            this.LEDButton.Location = new System.Drawing.Point(301, 25);
            this.LEDButton.Name = "LEDButton";
            this.LEDButton.Size = new System.Drawing.Size(16, 19);
            this.LEDButton.TabIndex = 21;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 527);
            this.Controls.Add(this.LEDButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonConnectArduino);
            this.Controls.Add(this.comboBoxPortArduino);
            this.Controls.Add(this.buttonInit);
            this.Controls.Add(this.buttonConnectCharlyRobot);
            this.Controls.Add(this.comboBoxPortCharlyRobot);
            this.Controls.Add(this.labelY);
            this.Controls.Add(this.labelZ);
            this.Controls.Add(this.labelX);
            this.Controls.Add(this.textBoxY);
            this.Controls.Add(this.textBoxZ);
            this.Controls.Add(this.textBoxX);
            this.Controls.Add(this.buttonZDown);
            this.Controls.Add(this.buttonZUp);
            this.Controls.Add(this.buttonRight);
            this.Controls.Add(this.buttonLeft);
            this.Controls.Add(this.buttonDown);
            this.Controls.Add(this.buttonUp);
            this.Name = "MainWindow";
            this.ShowIcon = false;
            this.Text = "CharlyRobot";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonUp;
        private System.Windows.Forms.Button buttonDown;
        private System.Windows.Forms.Button buttonLeft;
        private System.Windows.Forms.Button buttonRight;
        private System.Windows.Forms.Button buttonZDown;
        private System.Windows.Forms.Button buttonZUp;
        private System.Windows.Forms.TextBox textBoxX;
        private System.Windows.Forms.TextBox textBoxZ;
        private System.Windows.Forms.TextBox textBoxY;
        private System.Windows.Forms.Label labelX;
        private System.Windows.Forms.Label labelZ;
        private System.Windows.Forms.Label labelY;
        private System.Windows.Forms.ComboBox comboBoxPortCharlyRobot;
        private System.Windows.Forms.Button buttonConnectCharlyRobot;
        private System.Windows.Forms.Button buttonInit;
        private System.Windows.Forms.ComboBox comboBoxPortArduino;
        private System.Windows.Forms.Button buttonConnectArduino;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel LEDButton;
    }
}

