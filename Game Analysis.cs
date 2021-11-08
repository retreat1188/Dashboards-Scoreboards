using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp___Lab12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //constant
        const int TOTALLAPS = 5;

        //global (i.e., modular) variables
        string minLapTime = "";
        string maxLapTime = "";
        string avgLapTime = "";
        string sumOfLapTimes = "";

        int minLapTimeInSeconds;
        int maxLapTimeInSeconds;
        int avgLapTimeInSeconds;
        int sumOfLapTimesInSeconds;

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //declarations
            int lap1Time;
            int lap2Time;
            int lap3Time;
            int lap4Time;
            int lap5Time;

            //get the user input
            lap1Time = Convert.ToInt32(txtLap1.Text);
            lap2Time = Convert.ToInt32(txtLap2.Text);
            lap3Time = Convert.ToInt32(txtLap3.Text);
            lap4Time = Convert.ToInt32(txtLap4.Text);
            lap5Time = Convert.ToInt32(txtLap5.Text);

            //calculations
            calcMinLapTime(lap1Time, lap2Time, lap3Time, lap4Time, lap5Time);
            calcMaxLapTime(lap1Time, lap2Time, lap3Time, lap4Time, lap5Time);
            calcAvgLapTime(lap1Time, lap2Time, lap3Time, lap4Time, lap5Time);
            calcSumOfLapTimes(lap1Time, lap2Time, lap3Time, lap4Time, lap5Time);

            //output
            lblMinLapTime.Text = minLapTime;
            lblMaxLapTime.Text = maxLapTime;
            lblAvgLapTime.Text = avgLapTime;
            lblSumofLapTimes.Text = sumOfLapTimes;
        }

        void calcMinLapTime(int lap1TimePar, int lap2TimePar, int lap3TimePar,
            int lap4TimePar, int lap5TimePar)
        {
            int minimumTime;
            int minutes;
            int seconds;

            minimumTime = Math.Min(lap1TimePar, Math.Min(lap2TimePar, Math.Min(
                lap3TimePar, Math.Min(lap4TimePar, lap5TimePar))));

            if (minimumTime >= 60) 
            {
                minutes = (int) (minimumTime / 60);
                seconds = minimumTime - minutes * 60;
                minLapTime = minutes.ToString() + "\'" + seconds.ToString() + "\"";
            }
            else
            {
                minutes = 0;
                seconds = minimumTime;
                minLapTime = seconds.ToString() + "\"";
            }
        }

        void calcMaxLapTime(int lap1TimePar, int lap2TimePar, int lap3TimePar,
            int lap4TimePar, int lap5TimePar)
        {
            int maximumTime;
            int minutes;
            int seconds;

            maximumTime = Math.Max(lap1TimePar, Math.Max(lap2TimePar, Math.Max(
                lap3TimePar, Math.Max(lap4TimePar, lap5TimePar))));

            if (maximumTime >= 60)
            {
                minutes = (int)(maximumTime / 60);
                seconds = maximumTime - minutes * 60;
                maxLapTime = minutes.ToString() + "\'" + seconds.ToString() + "\"";
            }
            else
            {
                minutes = 0;
                seconds = maximumTime;
                maxLapTime = seconds.ToString() + "\"";
            }
        }

        void  calcAvgLapTime(int lap1TimePar, int lap2TimePar, int lap3TimePar,
            int lap4TimePar, int lap5TimePar)
        {
            int minutes;
            int seconds;

            avgLapTimeInSeconds = (lap1TimePar + lap2TimePar + lap3TimePar +
                lap4TimePar + lap5TimePar) / TOTALLAPS; //83 -> 1'23"
            if (avgLapTimeInSeconds >= 60)
            {
                minutes = (int)(avgLapTimeInSeconds / 60);
                seconds = avgLapTimeInSeconds - minutes * 60;
                avgLapTime = minutes.ToString() + "\'" + seconds.ToString() + "\"";
            }
            else
            {
                minutes = 0;
                seconds = avgLapTimeInSeconds;
                avgLapTime = seconds.ToString() + "\""; //53"
            }
        }

        void calcSumOfLapTimes(int lap1TimePar, int lap2TimePar, int lap3TimePar,
            int lap4TimePar, int lap5TimePar)
        {
            int minutes;
            int seconds;

            sumOfLapTimesInSeconds = lap1TimePar + lap2TimePar + lap3TimePar +
                lap4TimePar + lap5TimePar;

            if (sumOfLapTimesInSeconds >= 60)
            {
                minutes = (int)(sumOfLapTimesInSeconds / 60);
                seconds = sumOfLapTimesInSeconds - minutes * 60;
                sumOfLapTimes = minutes.ToString() + "\'" + seconds.ToString() + "\"";
            }
            else
            {
                minutes = 0;
                seconds = sumOfLapTimesInSeconds;
                sumOfLapTimes = seconds.ToString() + "\"";
            }
        }
    }
}
