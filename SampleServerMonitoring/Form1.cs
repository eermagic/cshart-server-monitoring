using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SampleServerMonitoring
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnReadEvent_Click(object sender, EventArgs e)
        {
            //讀取事件檢視器
            EventLog evLog = new EventLog();

            //選取Application 類的 Log
            evLog.Log = "Application";

            //選出 Type 為 Error，且時間為一天內的 Log
            var AppLogEntries =
            from EventLogEntry ev in evLog.Entries
            where ev.EntryType == EventLogEntryType.Error && ev.TimeGenerated > DateTime.Now.AddDays(-1)
            orderby ev.TimeGenerated descending
            select new
            {
                ev.Source,
                ev.InstanceId,
                ev.Message,
                ev.TimeGenerated,
                ev.UserName,
                ev.EntryType,
            };

            //放到DataSource上
            dataGridView1.DataSource = AppLogEntries.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnReadCPU_Click(object sender, EventArgs e)
        {
            // 取得cpu 效能
            PerformanceCounter cpu = new PerformanceCounter(
            "Processor", "% Processor Time", "_Total");

            // 取得近 5 秒的平均值
            double cpuAvg = 0;
            for (int i = 0; i < 5; i++)
            {
                cpuAvg += cpu.NextValue();
                Thread.Sleep(1000);
            }
            cpuAvg = Math.Round(cpuAvg / 5, 0);
            txtCPU.Text = "CPU 使用率 = " + cpuAvg + " %";
        }

        private void btnReadHD_Click(object sender, EventArgs e)
        {
            //硬碟可用容量
            StringBuilder sb = new StringBuilder();
            DriveInfo[] allDrives = DriveInfo.GetDrives();

            foreach (DriveInfo d in allDrives)
            {
                sb.Append($"裝置 {d.Name}: ");
                if (d.IsReady == true)
                {
                    // 可用容量 MB
                    string FreeSpace = (d.TotalFreeSpace / (1024 * 1024)).ToString("N0");
                    int FreeSpacePercent = Convert.ToInt32(Convert.ToDouble(d.TotalFreeSpace) / Convert.ToDouble(d.TotalSize) * 100);
                    sb.AppendLine($"可用容量: {FreeSpace} MB 使用率: ({FreeSpacePercent} %)");
                }
            }
            txtHD.Text = sb.ToString();
        }

        private void btnReadProgram_Click(object sender, EventArgs e)
        {
            //檢查某程式執行
            string[] ProgName = { "w3wp" , "sqlserver", "Batch1" }; //執行程式名稱
            StringBuilder sb = new StringBuilder();
            foreach (string name in ProgName)
            {
                Process[] myProcess = Process.GetProcessesByName(name);
                if (myProcess.Length == 0)
                {
                    sb.AppendLine("程式: " + name + " 未執行");
                }
                else
                {
                    sb.AppendLine("程式: " + name + " 執行中");
                }
            }
            txtProg.Text = sb.ToString();
        }

        private void btnSendLine_Click(object sender, EventArgs e)
        {
            //發送 Line  通知
            string message = "測試訊息1\n測試訊息2\n測試訊息3";

            HttpClient httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/x-www-form-urlencoded"));
            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", "{取代你的 Token}");
            var content = new Dictionary<string, string>();
            content.Add("message", message);
            httpClient.PostAsync("https://notify-api.line.me/api/notify", new FormUrlEncodedContent(content));
        }
    }
}
