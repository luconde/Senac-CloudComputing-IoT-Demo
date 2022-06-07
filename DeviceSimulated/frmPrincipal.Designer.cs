namespace DeviceSimulated
{
    partial class frmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtAlertTemperature = new System.Windows.Forms.TextBox();
            this.txtMinHumi = new System.Windows.Forms.TextBox();
            this.txtMinTemperature = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtStringDevice = new System.Windows.Forms.TextBox();
            this.txtStringService = new System.Windows.Forms.TextBox();
            this.txtDeviceName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtAlertSent = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cmdActivate = new System.Windows.Forms.Button();
            this.txtMsgReceived = new System.Windows.Forms.TextBox();
            this.txtMsgSent = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtAlertTemperature);
            this.groupBox1.Controls.Add(this.txtMinHumi);
            this.groupBox1.Controls.Add(this.txtMinTemperature);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(41, 57);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.groupBox1.Size = new System.Drawing.Size(780, 795);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parâmetros da Temperatura";
            // 
            // txtAlertTemperature
            // 
            this.txtAlertTemperature.Location = new System.Drawing.Point(403, 317);
            this.txtAlertTemperature.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.txtAlertTemperature.Name = "txtAlertTemperature";
            this.txtAlertTemperature.Size = new System.Drawing.Size(356, 47);
            this.txtAlertTemperature.TabIndex = 5;
            this.txtAlertTemperature.Text = "30";
            // 
            // txtMinHumi
            // 
            this.txtMinHumi.Location = new System.Drawing.Point(403, 208);
            this.txtMinHumi.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.txtMinHumi.Name = "txtMinHumi";
            this.txtMinHumi.Size = new System.Drawing.Size(356, 47);
            this.txtMinHumi.TabIndex = 4;
            this.txtMinHumi.Text = "60";
            // 
            // txtMinTemperature
            // 
            this.txtMinTemperature.Location = new System.Drawing.Point(403, 104);
            this.txtMinTemperature.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.txtMinTemperature.Name = "txtMinTemperature";
            this.txtMinTemperature.Size = new System.Drawing.Size(356, 47);
            this.txtMinTemperature.TabIndex = 3;
            this.txtMinTemperature.Text = "20";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(58, 325);
            this.label6.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(342, 41);
            this.label6.TabIndex = 2;
            this.label6.Text = "Alerta para Temperatura:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(75, 216);
            this.label5.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(322, 41);
            this.label5.TabIndex = 1;
            this.label5.Text = "Mínimo para Umidade:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 112);
            this.label4.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(367, 41);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mínimo para Temperatura:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtStringDevice);
            this.groupBox2.Controls.Add(this.txtStringService);
            this.groupBox2.Controls.Add(this.txtDeviceName);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(933, 60);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.groupBox2.Size = new System.Drawing.Size(1302, 793);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Conectividade para o Azure IoT Hub";
            // 
            // txtStringDevice
            // 
            this.txtStringDevice.Location = new System.Drawing.Point(396, 541);
            this.txtStringDevice.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.txtStringDevice.Multiline = true;
            this.txtStringDevice.Name = "txtStringDevice";
            this.txtStringDevice.Size = new System.Drawing.Size(886, 228);
            this.txtStringDevice.TabIndex = 6;
            // 
            // txtStringService
            // 
            this.txtStringService.Location = new System.Drawing.Point(396, 265);
            this.txtStringService.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.txtStringService.Multiline = true;
            this.txtStringService.Name = "txtStringService";
            this.txtStringService.Size = new System.Drawing.Size(886, 228);
            this.txtStringService.TabIndex = 5;
            this.txtStringService.Text = "<Insira a String de Conexao do Azure IoT Hub>";
            // 
            // txtDeviceName
            // 
            this.txtDeviceName.Location = new System.Drawing.Point(396, 101);
            this.txtDeviceName.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.txtDeviceName.Name = "txtDeviceName";
            this.txtDeviceName.Size = new System.Drawing.Size(886, 47);
            this.txtDeviceName.TabIndex = 4;
            this.txtDeviceName.Text = "<Insira o nome do dispositivo>";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 525);
            this.label3.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(348, 41);
            this.label3.TabIndex = 2;
            this.label3.Text = "String para o Dispositivo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 273);
            this.label2.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(297, 41);
            this.label2.TabIndex = 1;
            this.label2.Text = "String para o Serviço:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 109);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(302, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome do dispositivo:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtAlertSent);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.lblStatus);
            this.groupBox3.Controls.Add(this.cmdActivate);
            this.groupBox3.Controls.Add(this.txtMsgReceived);
            this.groupBox3.Controls.Add(this.txtMsgSent);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(70, 913);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.groupBox3.Size = new System.Drawing.Size(2149, 462);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Execução";
            // 
            // txtAlertSent
            // 
            this.txtAlertSent.Location = new System.Drawing.Point(330, 323);
            this.txtAlertSent.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.txtAlertSent.Name = "txtAlertSent";
            this.txtAlertSent.ReadOnly = true;
            this.txtAlertSent.Size = new System.Drawing.Size(237, 47);
            this.txtAlertSent.TabIndex = 7;
            this.txtAlertSent.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(83, 331);
            this.label9.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(241, 41);
            this.label9.TabIndex = 6;
            this.label9.Text = "Alertas enviados:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblStatus.Location = new System.Drawing.Point(1183, 194);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(116, 71);
            this.lblStatus.TabIndex = 5;
            this.lblStatus.Text = "Idle";
            // 
            // cmdActivate
            // 
            this.cmdActivate.Location = new System.Drawing.Point(668, 109);
            this.cmdActivate.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.cmdActivate.Name = "cmdActivate";
            this.cmdActivate.Size = new System.Drawing.Size(384, 262);
            this.cmdActivate.TabIndex = 4;
            this.cmdActivate.Text = "Ativar";
            this.cmdActivate.UseVisualStyleBackColor = true;
            this.cmdActivate.Click += new System.EventHandler(this.cmdActivate_Click);
            // 
            // txtMsgReceived
            // 
            this.txtMsgReceived.Location = new System.Drawing.Point(330, 213);
            this.txtMsgReceived.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.txtMsgReceived.Name = "txtMsgReceived";
            this.txtMsgReceived.ReadOnly = true;
            this.txtMsgReceived.Size = new System.Drawing.Size(237, 47);
            this.txtMsgReceived.TabIndex = 3;
            this.txtMsgReceived.Text = "0";
            // 
            // txtMsgSent
            // 
            this.txtMsgSent.Location = new System.Drawing.Point(330, 109);
            this.txtMsgSent.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.txtMsgSent.Name = "txtMsgSent";
            this.txtMsgSent.ReadOnly = true;
            this.txtMsgSent.Size = new System.Drawing.Size(237, 47);
            this.txtMsgSent.TabIndex = 2;
            this.txtMsgSent.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(32, 221);
            this.label8.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(312, 41);
            this.label8.TabIndex = 1;
            this.label8.Text = "Mensagens recebidas:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 107);
            this.label7.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(300, 41);
            this.label7.TabIndex = 0;
            this.label7.Text = "Mensagens enviadas:";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2263, 1465);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.Name = "frmPrincipal";
            this.Text = "Simulação de dispositivo by Condé";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAlertTemperature;
        private System.Windows.Forms.TextBox txtMinHumi;
        private System.Windows.Forms.TextBox txtMinTemperature;
        private System.Windows.Forms.TextBox txtStringDevice;
        private System.Windows.Forms.TextBox txtStringService;
        private System.Windows.Forms.TextBox txtDeviceName;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button cmdActivate;
        private System.Windows.Forms.TextBox txtMsgReceived;
        private System.Windows.Forms.TextBox txtMsgSent;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtAlertSent;
        private System.Windows.Forms.Label label9;
    }
}
