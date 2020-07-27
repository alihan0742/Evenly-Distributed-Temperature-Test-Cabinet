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
using System.Threading;

namespace Chamber_MD
{
    public partial class Chamber_MD : Form
    {

        string tempChamber;
        string tempRoom;
        Int32 testTemp;
        Int32 initial_margin;
        Int32 remaining;
        bool testActive = false;
        bool run = false;
        double[] tempChamberBuffer = new double[5];
        double[] tempRoomBuffer = new double[5];
        int counter = 0;
        int index = 0;
        int desiredTemp;
        int first_run = 1;


        public Chamber_MD()
        {
            InitializeComponent();

        }

        public static string getTEMP(SerialPort sp, string strStart, string strEnd, int thermocouple)
        {     
            if (thermocouple==1)
            {
                sp.WriteLine("TEMP1");
            }
            else if (thermocouple==2)
            {
                sp.WriteLine("TEMP2");
            }
            
            string strSource = sp.ReadLine();

            try
            {
                if (strSource.Contains("Temp("))
                {
                    int Start, End;
                    if (strSource.Contains(strStart) && strSource.Contains(strEnd))
                    {
                        if (thermocouple == 1)
                        {
                            //Start = strSource.IndexOf(strStart, 0) + strStart.Length;
                            //End = strSource.IndexOf(strEnd, Start);
                            //return strSource.Substring(Start, End - Start - 5);

                            return strSource.Substring(5, 5);
                        }
                        else if (thermocouple == 2)
                        {
                            //Start = strSource.IndexOf(strStart, 0) + strStart.Length + 5;
                            //End = strSource.IndexOf(strEnd, Start);
                            //return strSource.Substring(Start, End - Start);

                            return strSource.Substring(5, 5);
                        }
                        else { return ""; }
                        
                    }
                    else
                    {return "";}
                }
                else
                {return "";}
            }
            catch
            {return "";}
        }
        private void btn_Connect_Click(object sender, EventArgs e)
        {
            try
            {
                if (btn_Connect.Text == "Connect")
                {
                    labelConnection.Text = "Port is open!";
                    serialPort1.PortName = cb_Ports.Text;
                    serialPort1.BaudRate = 115200;
                    serialPort1.Open();

                    timer1.Enabled = true;

                    btn_Connect.Text = "Disconnect";

                    groupBoxProfile.Enabled = true;
                    groupBoxTest.Enabled = true;

                }
                else
                {
                    timer1.Enabled = false;
                    Thread.Sleep(1000);
                    labelConnection.Text = "Port is closed!";
                    btn_Connect.Text = "Connect";
                    serialPort1.Close();

                    groupBoxProfile.Enabled = false;
                    groupBoxTest.Enabled = false;
                }
            }
            catch
            {
                labelConnection.Text = "Port is closed!";
                MessageBox.Show("Choose a valid Port!");
            }
        }
    
        private void Form1_Load(object sender, EventArgs e)
        {
            

            timer1.Enabled = false;
            timer1.Interval = 1000;

            labelConnection.Text = "Port is closed!";
            foreach (string s in SerialPort.GetPortNames())
            {
                cb_Ports.Items.Add(s);
            }

            groupBoxProfile.Enabled = false;
            groupBoxTest.Enabled = false;

            pictureBoxGreenLED.Visible = false;
            pictureBoxGrayLED.Visible = true;

            first_run = 1;

            textBoxTestMargin.Text = "10";

        }

        private void buttonRunStop_Click(object sender, EventArgs e)
        {


            if (buttonRunStop.Text == "RUN")
            {
                try
                {
                    if (Convert.ToInt32(textBoxTestTemp.Text) > 300 || Convert.ToInt32(textBoxTestTemp.Text) < 50 || textBoxTestTemp.Text == "")
                    {
                        MessageBox.Show("You should enter test temperature between 50 & 300!");
                        textBoxTestTemp.Text = "";
                        textBoxTestTime.Text = "";
                        return;
                    }
                    if (Convert.ToInt32(textBoxTestTime.Text) > 1440 || Convert.ToInt32(textBoxTestTime.Text) < 1 || textBoxTestTime.Text == "")
                    {
                        MessageBox.Show("You should enter test time between 1 & 1440!");
                        textBoxTestTemp.Text = "";
                        textBoxTestTime.Text = "";
                        return;
                    }
                    if (Convert.ToInt32(textBoxTestMargin.Text) > 30 || Convert.ToInt32(textBoxTestMargin.Text) < 0 || textBoxTestMargin.Text == "")
                    {
                        MessageBox.Show("You should enter test temperature margin between 0 & 30!");
                        textBoxTestTemp.Text = "";
                        textBoxTestTime.Text = "";
                        return;
                    }
                    
                }
                catch 
                {
                    MessageBox.Show("You should enter valid integer values for test temperature and test time!");
                    textBoxTestTemp.Text = "";
                    textBoxTestTime.Text = "";
                    textBoxTestMargin.Text = "";
                    return;
                }
                     
                {


                    testTemp = Convert.ToInt32(textBoxTestTemp.Text);
                    initial_margin = Convert.ToInt32(textBoxTestMargin.Text);
                    desiredTemp = testTemp- initial_margin;
                    remaining = Convert.ToInt32(textBoxTestTime.Text) * 60;

                    chart1.ChartAreas[0].AxisX.Title = "Time";
                    chart1.ChartAreas[0].AxisY.Title = "Temperature";
                    chart1.ChartAreas[0].AxisX.Minimum = 0;
                    chart1.ChartAreas[0].AxisX.Maximum = remaining+300; //5dk ekledim(0 dan 120 ye çıkması için)
                    chart1.ChartAreas[0].AxisY.Minimum = 0;
                    chart1.ChartAreas[0].AxisY.Maximum = 200;
                    //chart1.ChartAreas[0].AxisX.ScaleView.Zoom(0, 100);
                    chart1.Series[0].BorderWidth = 3;
                    chart1.Series[0].Points.Clear();

                    buttonRunStop.Text = "STOP";
                    buttonRunStop.BackColor = Color.Tomato;

                    serialPort1.WriteLine("LOCK");
                    Thread.Sleep(1000);

                    run = true;

                    serialPort1.WriteLine("ON");
                    Thread.Sleep(1000);
                }                    
            }

            else if (buttonRunStop.Text == "STOP")
            {
                buttonRunStop.Text = "RUN";
                buttonRunStop.BackColor = Color.MediumSpringGreen;

                serialPort1.WriteLine("UNLOCK");
                Thread.Sleep(1000);

                testActive = false;
                run = false;

                testTemp = Convert.ToInt32(textBoxTestTemp.Text);
                //remaining = Convert.ToInt32(textBoxTestTime.Text) * 60;
                textBoxRemaining.Text = "Stopped!";

                serialPort1.WriteLine("OFF");
                Thread.Sleep(1000);

                pictureBoxGreenLED.Visible = false;
                pictureBoxGrayLED.Visible = true;

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            tempChamber = getTEMP(serialPort1, "Temp(", ")", 2);            
            //textBoxChamberTemp.Text = tempvalChamber;

            tempRoom = getTEMP(serialPort1, "Temp(", ")", 1);
            //textBoxRoomTemp.Text = tempvalRoom;

            //double tempChamberDouble = Convert.ToDouble(tempChamber);
            double tempChamberDouble;
            double.TryParse(tempChamber.Replace('.', ','), out tempChamberDouble);
            //tempChamberDouble = tempChamberDouble / 100;
            tempChamberBuffer[index] = tempChamberDouble;

            //double tempRoomDouble = Convert.ToDouble(tempRoom);
            double tempRoomDouble;
            double.TryParse(tempRoom.Replace('.', ','), out tempRoomDouble);
            //tempRoomDouble = tempRoomDouble / 100;
            tempRoomBuffer[index] = tempRoomDouble;

            double tempChamberAvg = tempChamberDouble;
            double tempRoomAvg = tempRoomDouble;
            
            counter++;

            if (counter > 4)
            {
                tempChamberAvg = tempChamberBuffer.Sum() / 5;
                tempRoomAvg = tempRoomBuffer.Sum() / 5;
                counter = 4;
            }

            textBoxChamberTemp.Text = String.Format("{0:0.00}", tempChamberAvg);
            textBoxRoomTemp.Text = String.Format("{0:0.00}", tempRoomAvg);

            index++;
            if (index == 5)
                index = 0;

            int tempInt = Convert.ToInt32(tempChamberAvg);

            int tempIntProgress = 0;

            if (tempInt < 0)
                tempIntProgress = 0;
            else if (tempInt > 300)
                tempIntProgress = 300;
            else
                tempIntProgress = tempInt;

            progressBarTemp.Value = tempIntProgress;


            

            int tempDif = tempInt - desiredTemp;

            if (run == true)
            {

                this.chart1.Series[0].Points.AddXY(0, tempInt);

                if (first_run==1)
                {
                    if (tempDif < -2)
                    {
                        serialPort1.WriteLine("ON");
                        pictureBoxGreenLED.Visible = true;
                        pictureBoxGrayLED.Visible = false;

                    }
                    else if (tempDif > 2)
                    {
                        serialPort1.WriteLine("OFF");
                        pictureBoxGreenLED.Visible = false;
                        pictureBoxGrayLED.Visible = true;
                    }
                    else
                    {
                        testActive = true;

                        serialPort1.WriteLine("OFF");
                        pictureBoxGreenLED.Visible = false;
                        pictureBoxGrayLED.Visible = true;

                        first_run = 0;

                    }
                }
                else if(first_run==0)
                {

                    if(tempDif > initial_margin)
                    {
                        desiredTemp = testTemp;
                        first_run = 2;
                    }
                    
                    

                }

                else
                {
                    if (tempDif < -2)
                    {
                        serialPort1.WriteLine("ON");
                        pictureBoxGreenLED.Visible = true;
                        pictureBoxGrayLED.Visible = false;

                    }
                    else if (tempDif > 2)
                    {
                        serialPort1.WriteLine("OFF");
                        pictureBoxGreenLED.Visible = false;
                        pictureBoxGrayLED.Visible = true;
                    }
                    else
                    {
                        
                        serialPort1.WriteLine("OFF");
                        pictureBoxGreenLED.Visible = false;
                        pictureBoxGrayLED.Visible = true;
                      
                    }

                }



            }
            
            // totalTime++;
            if (remaining == 1)
            {
                remaining = 0;
                //totalTime = 0;

                serialPort1.WriteLine("OFF");
                pictureBoxGreenLED.Visible = false;
                pictureBoxGrayLED.Visible = true;
                serialPort1.WriteLine("UNLOCK");

                testActive = false;
                run = false;

                textBoxRemaining.Text = "00:00:00";

                MessageBox.Show("Testing complete!");

                textBoxTestTemp.Text = "";
                textBoxTestTime.Text = "";
                buttonRunStop.Text = "RUN";
                buttonRunStop.BackColor = Color.MediumSpringGreen;

                first_run = 1;
            }
            else
            {
                if (testActive == true)
                {
                    remaining--;
                    textBoxRemaining.Text = remaining / 3600 + ":" + ((remaining / 60 % 60) >= 10 ? (remaining / 60 % 60).ToString() : "0" + (remaining / 60 % 60)) + ":" + ((remaining % 60) >= 10 ? (remaining % 60).ToString() : "0" + (remaining % 60));
                }
            }
            //textBoxTotalTime.Text = totalTime / 60 + ":" + ((totalTime % 60) >= 10 ? (totalTime % 60).ToString() : "0" + (totalTime % 60));
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }   
}
