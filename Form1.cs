using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ShutdownSchedular
{
    public partial class Frmscheduler : Form
    {
        public Frmscheduler()
        {
            InitializeComponent();
        }
        public string basepath= AppDomain.CurrentDomain.BaseDirectory;
        public const string batchpath="BatchFiles";

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnScheduler_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime inputTime =ConvertToDate(timePicker.Text);
                TimeSpan t= timecalculate(inputTime);
                timePicker.Enabled = false;
                if (t.Equals(TimeSpan.Zero))
                {
                    Operation();
                }
                btnScheduler.Enabled = false;
                cmbOption.Enabled = false;
                timeScheduler.Start();
            }
            catch (Exception ex)
            {
                lblerror.Text = "Error:" + ex.Message;
            }
        }
        private DateTime ConvertToDate(string datetime) 
        {
            var time = datetime.Substring(datetime.IndexOf(" "));
            var date = datetime.Substring(0, 10);
            var datepart = date.Split('/');
            var timepart = time.Split(':');
            var dateList = datepart.Select(s => Convert.ToInt32(s)).ToList();
            var timelist = timepart.Select(s => Convert.ToInt32(s)).ToList();
            DateTime inputTime = new DateTime(dateList[2], dateList[1], dateList[0], timelist[0], timelist[1], timelist[2]);
            return inputTime;
        }
        private void Operation()
        {
            Process proc = null;
            try
            {
                string batDir = basepath+batchpath;
                string fileName = "";
                switch (cmbOption.Text)
                {
                    case "Shutdown":
                        fileName = "Shutdown.bat";
                        break;
                    case "Restart":
                        fileName = "Restart.bat";
                        break;
                    case "Hibernate":
                        fileName = "Hibernate.bat";
                        break;
                    case "Sleep":
                        fileName = "Sleep.bat";
                        break;
                    default:
                        MessageBox.Show("Error:Select proper operation");
                        throw new Exception("Error:Select proper operation");
                }
                CreateBatchFiles(batDir, fileName);
                proc = new Process();
                proc.StartInfo.WorkingDirectory = batDir;
                proc.StartInfo.FileName = fileName;
                proc.StartInfo.CreateNoWindow = false;
                //MessageBox.Show("Windows is"+fileName);
                proc.Start();
                proc.WaitForExit();

            }
            catch (Exception ex)
            {
                lblerror.Text ="Error:"+ ex.Message;

            }
        }
        private TimeSpan timecalculate(DateTime giventime)
        {
            DateTime currentTime = DateTime.Now;
            TimeSpan t = giventime > currentTime ? giventime - currentTime : new TimeSpan();
            lblRemainTime.Text = t.ToString(@"hh\:mm\:ss");
            return t;
        }

        private void timeScheduler_Tick(object sender, EventArgs e)
        {
            DateTime giventime = ConvertToDate(timePicker.Text);
            var t = giventime.AddSeconds(1);
            TimeSpan ts= timecalculate(giventime);

            if (lblRemainTime.ForeColor == Color.Maroon)
                lblRemainTime.ForeColor = Color.OrangeRed;
            else 
                lblRemainTime.ForeColor = Color.Maroon;
            
            if (ts.Equals(TimeSpan.Zero))
            {
                Clear();
                Operation();
            }
        }

        private void Frmscheduler_Load(object sender, EventArgs e)
        {
            if (!Directory.Exists(basepath +batchpath))
            {
                Directory.CreateDirectory(basepath+batchpath);
            }
            //CreateBatchFiles(basepath + batchpath,"Shutdown.bat");
            cmbOption.SelectedIndex = 0;
            timePicker.ShowUpDown = true;
            timePicker.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            timePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
        }
        private void CreateBatchFiles(string filepath,string filename)
        {
            if (!File.Exists(filepath +"\\"+filename))
            {
                using (StreamWriter sw = File.CreateText(filepath +"\\"+filename))
                {
                    
                    if (filename.Contains("Shutdown"))
                        sw.WriteLine("shutdown.exe /s /t 00");
                    else if(filename.Contains("Hibernate"))
                        sw.WriteLine("shutdown.exe /h /t 00");
                    else if(filename.Contains("Restart"))
                        sw.WriteLine("shutdown.exe /r /t 00");
                    else
                        sw.WriteLine("shutdown.exe /h /t 01");
                    sw.Close();
                }

            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Clear();   
        }
        private void Clear() 
        {
            lblRemainTime.Text = "";
            lblerror.Text = "";
            timePicker.Enabled = true;
            btnScheduler.Enabled = true;
            timeScheduler.Stop();
            timeScheduler.Dispose();
            cmbOption.Enabled = true;
            cmbOption.SelectedIndex = 1;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
