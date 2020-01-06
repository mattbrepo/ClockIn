using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace ClockIn
{
	public partial class MainForm : Form
	{
		private const string DB_FILE_NAME = "clockin.txt";

		private const char SEPARATOR = ';';
		private const string TAG_WORKING = "on";
		private const string TAG_NOT_WORKING = "off";
		
		private const string LABEL_NOT_WORKING = "not working...";
		private const string BTN_NOT_WORKING = "Clock in";
		private const string BTN_WORKING = "Clock out";

		private string _dbFilePath;
        private TimeSpan _todayWork;
        private List<Tuple<TimeSpan, string>> _activities;

		public MainForm()
		{
			InitializeComponent();
            string[] args = Environment.GetCommandLineArgs();
            if (args.Length == 2) _dbFilePath = Path.Combine(args[1], DB_FILE_NAME);
            else _dbFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, DB_FILE_NAME);

			RefreshUI(true);
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			RefreshUI(true);
		}

		private void btnOpenFile_Click(object sender, EventArgs e)
		{
			System.Diagnostics.Process.Start(_dbFilePath);
		}

		private void btnClock_Click(object sender, EventArgs e)
		{
			WriteRecord();
			RefreshUI(true);
		}

		private void WriteRecord()
		{
			string record = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + SEPARATOR;
			if (btnClock.Text == BTN_WORKING)
			{
                record += TAG_NOT_WORKING + SEPARATOR + cmbDetail.Text + SEPARATOR;
			}
			else
			{
				record += TAG_WORKING + SEPARATOR + cmbDetail.Text + SEPARATOR;
			}
			File.AppendAllLines(_dbFilePath, new string[] { record });
		}

		private void RefreshUI(bool loadDetails)
		{
			bool isWorking = false;
			DateTime startTime = DateTime.Now;
            textBoxDetail.Text = "";

			if (File.Exists(_dbFilePath))
			{
				string[] lines = File.ReadAllLines(_dbFilePath);

				if (loadDetails)
				{
					cmbDetail.Items.Clear();
                    cmbDetail.Items.AddRange(lines.Select(x => x.Split(SEPARATOR).ElementAtOrDefault(2)).Where(x => !string.IsNullOrEmpty(x)).Distinct().ToArray());
                    if (lines.Count() > 0)
                        cmbDetail.Text = lines.Last().Split(SEPARATOR).ElementAtOrDefault(2);

                    List<Tuple<DateTime, string, string>> xs = lines.Select(x => Tuple.Create(DateTime.Parse(x.Split(SEPARATOR)[0]), x.Split(SEPARATOR)[1], x.Split(SEPARATOR)[2])).Where(x => x.Item1.Date == DateTime.Today).ToList<Tuple<DateTime, string, string>>();
                    _todayWork = new TimeSpan();
                    _activities = new List<Tuple<TimeSpan, string>>();
                    if (xs.Count > 0)
                    {
                        if (xs[0].Item2 == TAG_NOT_WORKING)
                            xs.Insert(0, Tuple.Create(DateTime.Parse(DateTime.Now.ToString("dd/MM/yyyy") + " 00:00:01"), TAG_WORKING, cmbDetail.Text));

                        if (xs.Last().Item2 == TAG_WORKING)
                            xs.RemoveAt(xs.Count - 1);

                        if (xs.Count > 1)
                        {
                            for (int i = 0; i < xs.Count; i = i + 2)
                            {
                                TimeSpan tsi = (xs[i + 1].Item1 - xs[i].Item1);
                                _todayWork = _todayWork + tsi;
                                AddActivity(xs[i].Item3, tsi);
                            }
                        }
                    }
				}

				string last = lines.Last();
				string[] fields = last.Split(SEPARATOR);
				if (fields.Length > 1) 
				{
					startTime = DateTime.Parse(fields[0]);
					isWorking = fields[1] == TAG_WORKING;
				}
			}

            TimeSpan ts = new TimeSpan();
			if (isWorking)
			{
				ts = (DateTime.Now - startTime);
				if (ts.Days >= 1) textBox1.Text = "#err...";
				else textBox1.Text = ts.Hours.ToString("00") + ":" + ts.Minutes.ToString("00");
                AddActivity(cmbDetail.Text, ts);
				cmbDetail.Enabled = false;
				btnClock.Text = BTN_WORKING;
                this.Icon = ClockIn.Properties.Resources.Clock_working;
			}
			else
			{
				textBox1.Text = LABEL_NOT_WORKING;
				cmbDetail.Enabled = true;
				btnClock.Text = BTN_NOT_WORKING;
                this.Icon = ClockIn.Properties.Resources.Clock_not_working;
			}

            if (_todayWork.TotalMinutes > 1)
                textBox1.Text += "\r\n" + (_todayWork + ts).ToString("hh':'mm");

            textBoxDetail.Text = "";
            for (int i = 0; i < _activities.Count; i++)
            {
                textBoxDetail.Text += _activities[i].Item2 + ": " + _activities[i].Item1.ToString("hh':'mm") + "\r\n";
            }                
		}

        /// <summary>
        /// Add activity to the activities' list
        /// </summary>
        /// <param name="name"></param>
        /// <param name="tsi"></param>
        private void AddActivity(string name, TimeSpan tsi)
        {
            if (name == "") name = "working";
            int index = _activities.FindIndex(x => x.Item2 == name);
            if (index >= 0)
            {
                _activities[index] = Tuple.Create(_activities[index].Item1 + tsi, _activities[index].Item2);
            }
            else
            {
                _activities.Add(Tuple.Create(tsi, name));
            }
        }


	}
}
