namespace Chamber_MD
{
    partial class Chamber_MD
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Chamber_MD));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBoxConnection = new System.Windows.Forms.GroupBox();
            this.labelConnection = new System.Windows.Forms.Label();
            this.btn_Connect = new System.Windows.Forms.Button();
            this.cb_Ports = new System.Windows.Forms.ComboBox();
            this.groupBoxProfile = new System.Windows.Forms.GroupBox();
            this.textBoxTestMargin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelTestTime = new System.Windows.Forms.Label();
            this.textBoxTestTime = new System.Windows.Forms.TextBox();
            this.labelTemp = new System.Windows.Forms.Label();
            this.textBoxTestTemp = new System.Windows.Forms.TextBox();
            this.buttonRunStop = new System.Windows.Forms.Button();
            this.groupBoxTest = new System.Windows.Forms.GroupBox();
            this.labelRemaining = new System.Windows.Forms.Label();
            this.textBoxRemaining = new System.Windows.Forms.TextBox();
            this.progressBarTemp = new System.Windows.Forms.ProgressBar();
            this.labelSampleTemp = new System.Windows.Forms.Label();
            this.textBoxRoomTemp = new System.Windows.Forms.TextBox();
            this.labelChamberTemp = new System.Windows.Forms.Label();
            this.pictureBoxGreenLED = new System.Windows.Forms.PictureBox();
            this.textBoxChamberTemp = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBoxGrayLED = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBoxConnection.SuspendLayout();
            this.groupBoxProfile.SuspendLayout();
            this.groupBoxTest.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGreenLED)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGrayLED)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxConnection
            // 
            this.groupBoxConnection.Controls.Add(this.labelConnection);
            this.groupBoxConnection.Controls.Add(this.btn_Connect);
            this.groupBoxConnection.Controls.Add(this.cb_Ports);
            this.groupBoxConnection.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxConnection.Location = new System.Drawing.Point(42, 89);
            this.groupBoxConnection.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxConnection.Name = "groupBoxConnection";
            this.groupBoxConnection.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxConnection.Size = new System.Drawing.Size(208, 93);
            this.groupBoxConnection.TabIndex = 18;
            this.groupBoxConnection.TabStop = false;
            this.groupBoxConnection.Text = "Connection";
            // 
            // labelConnection
            // 
            this.labelConnection.AutoSize = true;
            this.labelConnection.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConnection.Location = new System.Drawing.Point(8, 67);
            this.labelConnection.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelConnection.Name = "labelConnection";
            this.labelConnection.Size = new System.Drawing.Size(38, 20);
            this.labelConnection.TabIndex = 2;
            this.labelConnection.Text = "Port";
            // 
            // btn_Connect
            // 
            this.btn_Connect.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Connect.Location = new System.Drawing.Point(109, 28);
            this.btn_Connect.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Connect.Name = "btn_Connect";
            this.btn_Connect.Size = new System.Drawing.Size(94, 37);
            this.btn_Connect.TabIndex = 1;
            this.btn_Connect.Text = "Connect";
            this.btn_Connect.UseVisualStyleBackColor = true;
            this.btn_Connect.Click += new System.EventHandler(this.btn_Connect_Click);
            // 
            // cb_Ports
            // 
            this.cb_Ports.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Ports.FormattingEnabled = true;
            this.cb_Ports.Location = new System.Drawing.Point(10, 34);
            this.cb_Ports.Margin = new System.Windows.Forms.Padding(2);
            this.cb_Ports.Name = "cb_Ports";
            this.cb_Ports.Size = new System.Drawing.Size(81, 25);
            this.cb_Ports.TabIndex = 0;
            // 
            // groupBoxProfile
            // 
            this.groupBoxProfile.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBoxProfile.Controls.Add(this.textBoxTestMargin);
            this.groupBoxProfile.Controls.Add(this.label1);
            this.groupBoxProfile.Controls.Add(this.labelTestTime);
            this.groupBoxProfile.Controls.Add(this.textBoxTestTime);
            this.groupBoxProfile.Controls.Add(this.labelTemp);
            this.groupBoxProfile.Controls.Add(this.textBoxTestTemp);
            this.groupBoxProfile.Controls.Add(this.buttonRunStop);
            this.groupBoxProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxProfile.Location = new System.Drawing.Point(305, 38);
            this.groupBoxProfile.Name = "groupBoxProfile";
            this.groupBoxProfile.Size = new System.Drawing.Size(613, 175);
            this.groupBoxProfile.TabIndex = 32;
            this.groupBoxProfile.TabStop = false;
            this.groupBoxProfile.Text = "Profile";
            // 
            // textBoxTestMargin
            // 
            this.textBoxTestMargin.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTestMargin.Location = new System.Drawing.Point(301, 77);
            this.textBoxTestMargin.Name = "textBoxTestMargin";
            this.textBoxTestMargin.Size = new System.Drawing.Size(126, 37);
            this.textBoxTestMargin.TabIndex = 46;
            this.textBoxTestMargin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(296, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 20);
            this.label1.TabIndex = 45;
            this.label1.Text = "Initial margin(C)";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelTestTime
            // 
            this.labelTestTime.AutoSize = true;
            this.labelTestTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTestTime.Location = new System.Drawing.Point(159, 54);
            this.labelTestTime.Name = "labelTestTime";
            this.labelTestTime.Size = new System.Drawing.Size(132, 20);
            this.labelTestTime.TabIndex = 44;
            this.labelTestTime.Text = "Test Time (min)";
            // 
            // textBoxTestTime
            // 
            this.textBoxTestTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTestTime.Location = new System.Drawing.Point(163, 77);
            this.textBoxTestTime.Name = "textBoxTestTime";
            this.textBoxTestTime.Size = new System.Drawing.Size(126, 37);
            this.textBoxTestTime.TabIndex = 43;
            this.textBoxTestTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelTemp
            // 
            this.labelTemp.AutoSize = true;
            this.labelTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTemp.Location = new System.Drawing.Point(10, 54);
            this.labelTemp.Name = "labelTemp";
            this.labelTemp.Size = new System.Drawing.Size(140, 20);
            this.labelTemp.TabIndex = 42;
            this.labelTemp.Text = "Temperature (C)";
            // 
            // textBoxTestTemp
            // 
            this.textBoxTestTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTestTemp.Location = new System.Drawing.Point(14, 77);
            this.textBoxTestTemp.Name = "textBoxTestTemp";
            this.textBoxTestTemp.Size = new System.Drawing.Size(136, 37);
            this.textBoxTestTemp.TabIndex = 41;
            this.textBoxTestTemp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonRunStop
            // 
            this.buttonRunStop.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.buttonRunStop.Location = new System.Drawing.Point(447, 51);
            this.buttonRunStop.Name = "buttonRunStop";
            this.buttonRunStop.Size = new System.Drawing.Size(148, 84);
            this.buttonRunStop.TabIndex = 40;
            this.buttonRunStop.Text = "RUN";
            this.buttonRunStop.UseVisualStyleBackColor = false;
            this.buttonRunStop.Click += new System.EventHandler(this.buttonRunStop_Click);
            // 
            // groupBoxTest
            // 
            this.groupBoxTest.Controls.Add(this.labelRemaining);
            this.groupBoxTest.Controls.Add(this.textBoxRemaining);
            this.groupBoxTest.Controls.Add(this.progressBarTemp);
            this.groupBoxTest.Controls.Add(this.labelSampleTemp);
            this.groupBoxTest.Controls.Add(this.textBoxRoomTemp);
            this.groupBoxTest.Controls.Add(this.labelChamberTemp);
            this.groupBoxTest.Controls.Add(this.pictureBoxGreenLED);
            this.groupBoxTest.Controls.Add(this.textBoxChamberTemp);
            this.groupBoxTest.Controls.Add(this.pictureBox3);
            this.groupBoxTest.Controls.Add(this.pictureBoxGrayLED);
            this.groupBoxTest.Controls.Add(this.pictureBox1);
            this.groupBoxTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxTest.Location = new System.Drawing.Point(42, 208);
            this.groupBoxTest.Name = "groupBoxTest";
            this.groupBoxTest.Size = new System.Drawing.Size(876, 170);
            this.groupBoxTest.TabIndex = 42;
            this.groupBoxTest.TabStop = false;
            this.groupBoxTest.Text = "Test";
            // 
            // labelRemaining
            // 
            this.labelRemaining.AutoSize = true;
            this.labelRemaining.Location = new System.Drawing.Point(494, 91);
            this.labelRemaining.Name = "labelRemaining";
            this.labelRemaining.Size = new System.Drawing.Size(163, 24);
            this.labelRemaining.TabIndex = 51;
            this.labelRemaining.Text = "Remaining Time";
            // 
            // textBoxRemaining
            // 
            this.textBoxRemaining.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRemaining.Location = new System.Drawing.Point(510, 117);
            this.textBoxRemaining.Name = "textBoxRemaining";
            this.textBoxRemaining.Size = new System.Drawing.Size(119, 37);
            this.textBoxRemaining.TabIndex = 50;
            this.textBoxRemaining.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // progressBarTemp
            // 
            this.progressBarTemp.Location = new System.Drawing.Point(334, 46);
            this.progressBarTemp.Maximum = 300;
            this.progressBarTemp.Name = "progressBarTemp";
            this.progressBarTemp.Size = new System.Drawing.Size(355, 37);
            this.progressBarTemp.TabIndex = 49;
            // 
            // labelSampleTemp
            // 
            this.labelSampleTemp.AutoSize = true;
            this.labelSampleTemp.Location = new System.Drawing.Point(145, 91);
            this.labelSampleTemp.Name = "labelSampleTemp";
            this.labelSampleTemp.Size = new System.Drawing.Size(191, 24);
            this.labelSampleTemp.TabIndex = 48;
            this.labelSampleTemp.Text = "Room Temperature";
            // 
            // textBoxRoomTemp
            // 
            this.textBoxRoomTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRoomTemp.Location = new System.Drawing.Point(156, 117);
            this.textBoxRoomTemp.Name = "textBoxRoomTemp";
            this.textBoxRoomTemp.Size = new System.Drawing.Size(119, 37);
            this.textBoxRoomTemp.TabIndex = 47;
            this.textBoxRoomTemp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelChamberTemp
            // 
            this.labelChamberTemp.AutoSize = true;
            this.labelChamberTemp.Location = new System.Drawing.Point(145, 20);
            this.labelChamberTemp.Name = "labelChamberTemp";
            this.labelChamberTemp.Size = new System.Drawing.Size(221, 24);
            this.labelChamberTemp.TabIndex = 46;
            this.labelChamberTemp.Text = "Chamber Temperature";
            // 
            // pictureBoxGreenLED
            // 
            this.pictureBoxGreenLED.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxGreenLED.Image")));
            this.pictureBoxGreenLED.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxGreenLED.InitialImage")));
            this.pictureBoxGreenLED.Location = new System.Drawing.Point(774, 28);
            this.pictureBoxGreenLED.Name = "pictureBoxGreenLED";
            this.pictureBoxGreenLED.Size = new System.Drawing.Size(28, 32);
            this.pictureBoxGreenLED.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxGreenLED.TabIndex = 3;
            this.pictureBoxGreenLED.TabStop = false;
            // 
            // textBoxChamberTemp
            // 
            this.textBoxChamberTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxChamberTemp.Location = new System.Drawing.Point(156, 46);
            this.textBoxChamberTemp.Name = "textBoxChamberTemp";
            this.textBoxChamberTemp.Size = new System.Drawing.Size(119, 37);
            this.textBoxChamberTemp.TabIndex = 45;
            this.textBoxChamberTemp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.InitialImage")));
            this.pictureBox3.Location = new System.Drawing.Point(750, 67);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(82, 80);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBoxGrayLED
            // 
            this.pictureBoxGrayLED.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxGrayLED.Image")));
            this.pictureBoxGrayLED.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxGrayLED.InitialImage")));
            this.pictureBoxGrayLED.Location = new System.Drawing.Point(774, 28);
            this.pictureBoxGrayLED.Name = "pictureBoxGrayLED";
            this.pictureBoxGrayLED.Size = new System.Drawing.Size(28, 32);
            this.pictureBoxGrayLED.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxGrayLED.TabIndex = 1;
            this.pictureBoxGrayLED.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(14, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(118, 124);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(42, 384);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "CHAMBER TEMP";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(876, 300);
            this.chart1.TabIndex = 43;
            this.chart1.Text = "chart1";
            // 
            // Chamber_MD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 747);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.groupBoxTest);
            this.Controls.Add(this.groupBoxProfile);
            this.Controls.Add(this.groupBoxConnection);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Chamber_MD";
            this.Text = "Chamber_MD";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxConnection.ResumeLayout(false);
            this.groupBoxConnection.PerformLayout();
            this.groupBoxProfile.ResumeLayout(false);
            this.groupBoxProfile.PerformLayout();
            this.groupBoxTest.ResumeLayout(false);
            this.groupBoxTest.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGreenLED)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGrayLED)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxConnection;
        private System.Windows.Forms.Label labelConnection;
        private System.Windows.Forms.Button btn_Connect;
        private System.Windows.Forms.ComboBox cb_Ports;
        private System.Windows.Forms.GroupBox groupBoxProfile;
        private System.Windows.Forms.Label labelTestTime;
        private System.Windows.Forms.TextBox textBoxTestTime;
        private System.Windows.Forms.Label labelTemp;
        private System.Windows.Forms.TextBox textBoxTestTemp;
        private System.Windows.Forms.Button buttonRunStop;
        private System.Windows.Forms.GroupBox groupBoxTest;
        private System.Windows.Forms.Label labelRemaining;
        private System.Windows.Forms.TextBox textBoxRemaining;
        private System.Windows.Forms.ProgressBar progressBarTemp;
        private System.Windows.Forms.Label labelSampleTemp;
        private System.Windows.Forms.TextBox textBoxRoomTemp;
        private System.Windows.Forms.Label labelChamberTemp;
        private System.Windows.Forms.PictureBox pictureBoxGreenLED;
        private System.Windows.Forms.TextBox textBoxChamberTemp;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBoxGrayLED;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxTestMargin;
    }
}

