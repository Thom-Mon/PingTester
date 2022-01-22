using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.NetworkInformation;
using System.Windows.Forms.DataVisualization.Charting;

namespace PingTester
{
    public partial class Form1 : Form
    {
        List<int> pingTimeList = new List<int>();

        public Form1()
        {
            InitializeComponent();
        }

        /*
         * Do a single PingTest to see if given Page is reachable
         */
        private void buttonStartPingTest_button_Click(object sender, EventArgs e)
        {
                try
                {
                    Ping myPing = new Ping();
                    PingReply reply = myPing.Send(inputAddress_TextBox.Text, 1000);

                    if (reply != null)
                    {
                        outputPingTestResult_richtextbox.AppendText("Status :  " + reply.Status + " \n Zeit(ms) : " + reply.RoundtripTime.ToString() + " \n Address : " + reply.Address + "\n");
                    }
                }
                catch
                {
                    outputPingTestResult_richtextbox.AppendText("Fehler: TimeOut des Pings");
                }
          
        }

        /*
         * Pings are performed by using the given Ip-Address severall time to calculate a average value.
         * This is done 20-times by default.
         * At the beginning the list of pingTimes is emptied
         */
        private void buttonAutomatikPingTest_button_Click(object sender, EventArgs e)
        {
            pingTimeList.Clear();

            for (int i = 0; i < 20; i++)
            {
                try
                {
                    Ping myPing = new Ping();
                    PingReply reply = myPing.Send(inputAddress_TextBox.Text, 1000);

                    if (reply != null)
                    {
                        outputPingTestResult_richtextbox.AppendText("Status :  " + reply.Status + " \n Zeit(ms) : " + reply.RoundtripTime.ToString() + " \n Address : " + reply.Address + "\n");
                        pingTimeList.Add(Convert.ToInt32(reply.RoundtripTime));
                    }
                }
                catch
                {
                    outputPingTestResult_richtextbox.AppendText("Fehler: TimeOut des Pings");
                }
            }
            
            makeChart();
        }
        /*
         * Changes the size of the Textoutput and the chart to fit the WindowsSize
         */
        private void SizeChangedAction(object sender, EventArgs e)
        {
            int WidthOfForm = this.Size.Width;
            int HeightOfForm = this.Size.Height;
            //PingOutput_Height OnSizeChange
            outputPingTestResult_richtextbox.Size = new System.Drawing.Size(outputPingTestResult_richtextbox.Size.Width, HeightOfForm - 150);
            //Chart_Size OnSizeChange
            chartPingHistory_chart.Size = new System.Drawing.Size(WidthOfForm - 300, HeightOfForm - 150);
        }

        /*
         * Called if a new Value has been chosen in the DropDown for the maximum Y-Axis Value
         */
        private void OnDropDownChangeMaxY(object sender, EventArgs e)
        {
            makeChart();
        }

        /*
         * Builds the chart according to the settings. Standard-Y Size is 100.  
         * The chart uses the pingTimeList to build itself. It is rebuilt if the Y-Axix maximum is changed.
         */
        private void makeChart()
        {
            List<int> x = new List<int>();
            int counter = 1;
            
            foreach(int entry in pingTimeList) 
            {
                x.Add(counter);
                counter++;
            }

            chartPingHistory_chart.Series[0].LegendText = "Pingverlauf";
            chartPingHistory_chart.Series[0].Color = Color.Red;
            chartPingHistory_chart.Series[0].ChartType = SeriesChartType.Spline;
            chartPingHistory_chart.Series[0].BorderWidth = 3;
            chartPingHistory_chart.Series[0].Points.DataBindXY(x, pingTimeList);
           
            if (dropdownMaxYValue_combobox.SelectedItem.ToString() != "dynamisch")
            {
                chartPingHistory_chart.ChartAreas[0].AxisY.Maximum = Convert.ToInt32(dropdownMaxYValue_combobox.SelectedItem);
            }
        }
        /*
         * handles the Enter-Button in the textbox to make a ping-history call.
         */
        private void enterPressedOnIpTextbox(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                buttonAutomatikPingTest_button_Click(this, new EventArgs());
            }
        }
    }
}
