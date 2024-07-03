using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace MRhythm
{
    public partial class MainForm : Form
    {
        [DllImport("user32.dll")]
        private static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll")]
        private static extern int GetWindowText(IntPtr hWnd, StringBuilder text, int count);

        private const int TriggerIntervalDefault = 1800;
        private const int TriggerTotalDefault = 600;

        private int _triggerInterval;
        private int _triggerTotal;
        private decimal _triggerDuration;
        private bool _isRunning;

        public MainForm()
        {
            InitializeComponent();
            InitializeDefaultValues();
            StartApplicationScanner();
        }

        private void InitializeDefaultValues()
        {
            _triggerInterval = TriggerIntervalDefault;
            _triggerTotal = TriggerTotalDefault;
            _triggerDuration = CalculateTriggerDuration(_triggerTotal, _triggerInterval);
            UpdateInputFields("startup");
        }

        private void StartApplicationScanner()
        {
            applicationScanner.Interval = 2000;
            applicationScanner.Start();
        }

        private static string GetActiveWindowTitle()
        {
            const int nChars = 256;
            var buff = new StringBuilder(nChars);
            var handle = GetForegroundWindow();

            return GetWindowText(handle, buff, nChars) > 0 ? buff.ToString() : "No window focused";
        }

        private void UpdateInputFields(string source)
        {
            switch (source)
            {
                case "triggerIntervalInput":
                    triggerTotalInput.Text = _triggerTotal.ToString();
                    triggerDurationTime.Text = _triggerDuration.ToString();
                    break;

                case "triggerTotalInput":
                    if (durationLock.Checked)
                    {
                        _triggerInterval = CalculateTriggerInterval(_triggerDuration, _triggerTotal);
                        triggerIntervalInput.Text = _triggerInterval.ToString();
                    }
                    else
                    {
                        _triggerDuration = CalculateTriggerDuration(_triggerTotal, _triggerInterval);
                        triggerDurationTime.Text = _triggerDuration.ToString();
                    }
                    break;

                case "triggerDurationTime":
                    if (triggerTotalLock.Checked)
                    {
                        _triggerInterval = CalculateTriggerInterval(_triggerDuration, _triggerTotal);
                        triggerIntervalInput.Text = _triggerInterval.ToString();
                    }
                    else
                    {
                        _triggerTotal = (int)Math.Round((_triggerDuration * 60000) / _triggerInterval);
                        triggerTotalInput.Text = _triggerTotal.ToString();
                    }
                    break;

                case "startup":
                    triggerIntervalInput.Text = _triggerInterval.ToString();
                    triggerTotalInput.Text = _triggerTotal.ToString();
                    triggerDurationTime.Text = _triggerDuration.ToString();
                    break;
            }
        }

        private static decimal CalculateTriggerDuration(int total, int interval)
        {
            return Math.Round((decimal)((total * interval) / 60000.0), 2);
        }

        private static int CalculateTriggerInterval(decimal duration, int total)
        {
            return (int)((duration * 60000) / total);
        }

        private void TriggerIntervalInput_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(triggerIntervalInput.Text, out int interval))
            {
                _triggerInterval = interval;
                UpdateInputFields("triggerIntervalInput");
            }
        }

        private void TriggerTotalInput_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(triggerTotalInput.Text, out int total))
            {
                _triggerTotal = total;
                UpdateInputFields("triggerTotalInput");
            }
        }

        private void TriggerDurationTime_TextChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(triggerDurationTime.Text, out decimal duration))
            {
                _triggerDuration = duration;
                UpdateInputFields("triggerDurationTime");
            }
        }

        private void TriggerClock_Tick(object sender, EventArgs e)
        {
            if (GetActiveWindowTitle() == targetApplicationInput.Text)
            {
                triggerControl.Text = "Stop";
                SendKeys.Send("t");
            }
            else
            {
                triggerControl.Text = "Paused";
            }
        }

        private void TriggerControl_Click(object sender, EventArgs e)
        {
            if (!_isRunning)
            {
                triggerClock.Interval = _triggerInterval;
                triggerClock.Start();
                _isRunning = true;
                triggerControl.Text = "Stop";
            }
            else
            {
                triggerClock.Stop();
                _isRunning = false;
                triggerControl.Text = "Start";
            }
        }

        private void ApplicationScanner_Tick(object sender, EventArgs e)
        {
            var processes = Process.GetProcesses();
            foreach (var process in processes)
            {
                if (!string.IsNullOrEmpty(process.MainWindowTitle) && !targetApplicationInput.Items.Contains(process.MainWindowTitle))
                {
                    targetApplicationInput.Items.Add(process.MainWindowTitle);
                }
            }
        }

        private void SetDefault_Click(object sender, EventArgs e)
        {
            InitializeDefaultValues();
        }
    }
}