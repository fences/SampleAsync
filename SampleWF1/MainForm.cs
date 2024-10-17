using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace SampleWF1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
     
        private bool _runFlag = false;
        private static readonly object _LOCKREF = new object();
        private int addcount = 0;
        private int deletecount = 0;
        private int clearcount = 0;
        private int modifycount = 0;
        private Series series;

        private void Form1_Load(object sender, EventArgs e)
        {
            chDataPlot.Series.Clear();
            series = new Series("Random Data");
            series.ChartType = SeriesChartType.Line;
            chDataPlot.Series.Add(series);
            timer1.Start();
        }

        private static List<double> _lData = new List<double>();
        private async void ProcessAsync()
        {
            try
            {
                await Task.Run(() =>
                {
                    var tasks = new[]
                    {          
                        Task.Run(() => Plot()),
                        Task.Run(() => ShowCounts()),
                        Task.Run(() => Insert()),
                        Task.Run(() => Modify()),
                        Task.Run(() => Insert()),
                        Task.Run(() => Insert()),
                        Task.Run(() => Delete()),
                        Task.Run(() => Delete()),
                        Task.Run(() => Delete()),
                        Task.Run(() => Delete()),
                        Task.Run(() => Clear()),
                        Task.Run(() => Modify())
                    };
                    Task.WaitAll(tasks);
                });
            }
            catch (Exception ex) { txtMessage.Text = ex.Message; }
        }


        private async void ShowCounts()
        {
            while (_runFlag)
            {
                try
                {

                    Invoke(new Action(() =>
                    {
                        txtAddCount.Text = addcount.ToString();
                        txtDeleteCount.Text = deletecount.ToString();
                        txtClearCount.Text = clearcount.ToString();
                        txtModifyCount.Text = modifycount.ToString();
                    }));

                    bool lockTaken = false;
                    try
                    {
                        Monitor.Enter(_LOCKREF, ref lockTaken);
                        if (lockTaken)
                        {
                            Invoke(new Action(() =>
                            {
                                if (_lData.Count > 0)
                                {

                                    lblDataList.BeginUpdate();
                                    lblDataList.Items.Clear();
                                    foreach (var item in _lData)
                                        lblDataList.Items.Add(item);
                                    lblDataList.EndUpdate();
                                }
                            }));
                        }
                    }
                    catch (Exception ex) { txtMessage.Text = ex.Message; }
                    finally
                    {
                        if (lockTaken)
                        {
                            Monitor.Exit(_LOCKREF);
                        }
                    }


                    await Task.Delay(25);
                }
                catch (Exception ex) { txtMessage.Text = ex.Message; }

            }
        }

        private void Plot()
        {
            while (_runFlag)
            {
                try
                {
                    bool lockTaken = false;
                    try
                    {
                        Monitor.Enter(_LOCKREF, ref lockTaken);
                        if (lockTaken)
                        {
                            if (_lData.Count > 0)
                            {
                                Invoke(new Action(() =>
                                {
                                    series.Points.Clear();
                                    for (int i = 0; i < _lData.Count; i++)
                                        series.Points.AddXY(i, _lData[i]);
                                }));
                            }
                        
                        }
                    }
                    catch (Exception ex) { txtMessage.Text = ex.Message; }
                    finally
                    {
                        if (lockTaken)
                        {
                            Monitor.Exit(_LOCKREF);
                        }
                    }
                }
                catch (Exception ex) { txtMessage.Text = ex.Message; }
            }
        }

        private void Insert()
        {
            while (_runFlag)
            {
                try
                {
                    bool lockTaken = false;
                    try
                    {
                        Monitor.Enter(_LOCKREF, ref lockTaken);
                        if (lockTaken)
                        {

                            for (int i = 0; i < 30; i++)
                            {
                                Random rnd = new Random((int)DateTime.Now.Ticks);

                                double rndData = rnd.NextDouble();
                                _lData.Add(rndData);
                                string print = string.Format("Add  -> List Count={0} , Value={1} , ThreadID={2}", _lData.Count, rndData, Thread.CurrentThread.ManagedThreadId);
                                WriteTextSafe(print);
                                addcount++;
                                if (!_runFlag)
                                    break;

                            }
                        }
                    }
                    catch (Exception ex) { txtMessage.Text = ex.Message; }
                    finally
                    {
                        if (lockTaken)
                        {
                            Monitor.Exit(_LOCKREF);
                        }
                    }
                }
                catch (Exception ex) { txtMessage.Text = ex.Message; }
            }

        }

        private void Delete()
        {
            while (_runFlag)
            {
                try
                {
                    bool lockTaken = false;
                    try
                    {
                        Monitor.Enter(_LOCKREF, ref lockTaken);
                        if (lockTaken)
                        {
                            int len = _lData.Count;
                            if (len > 0)
                            {
                                Random rnd = new Random((int)DateTime.Now.Ticks);
                                int index = rnd.Next(0, len - 1);
                                _lData.RemoveAt(index);
                                string print = string.Format("Delete  -> Index={0} , ThreadID={1}", index, Thread.CurrentThread.ManagedThreadId);
                                WriteTextSafe(print);
                                deletecount++;
                            }
                        }
                    }
                    catch (Exception ex) { txtMessage.Text = ex.Message; }
                    finally
                    {
                        if (lockTaken)
                        {
                            Monitor.Exit(_LOCKREF);
                        }
                    }
                }
                catch (Exception ex) { txtMessage.Text = ex.Message; }
            }

        }

        private void Modify()
        {

            while (_runFlag)
            {
                try
                {
                    bool lockTaken = false;
                    try
                    {
                        Monitor.Enter(_LOCKREF, ref lockTaken);
                        if (lockTaken)
                        {
                            int len = _lData.Count;
                            if (len > 0)
                            {
                                Random rnd = new Random((int)DateTime.Now.Ticks);
                                int index = rnd.Next(0, len - 1);
                                double val = rnd.NextDouble();
                                _lData[index] = val;
                                string print = string.Format("Modified -> Index={0} , Value={1} , ThreadID={2}", index, val, Thread.CurrentThread.ManagedThreadId);
                                WriteTextSafe(print);
                                modifycount++;
                            }
                        }
                    }
                    catch (Exception ex) { txtMessage.Text = ex.Message; }
                    finally
                    {
                        if (lockTaken)
                        {
                            Monitor.Exit(_LOCKREF);
                        }
                    }
                }
                catch (Exception ex) { txtMessage.Text = ex.Message; }

            }

        }
        private void Clear()
        {
            while (_runFlag)
            {
                try
                {
                    bool lockTaken = false;
                    try
                    {
                        Monitor.Enter(_LOCKREF, ref lockTaken);
                        if (lockTaken)
                        {
                            _lData.Clear();
                            Console.WriteLine("Clear All!");
                            string print = string.Format("Clear All! , ThreadID={0}", Thread.CurrentThread.ManagedThreadId);
                            WriteTextSafe(print);
                            clearcount++;
                        }
                    }
                    catch (Exception ex) { txtMessage.Text = ex.Message; }
                    finally
                    {
                        if (lockTaken)
                        {
                            Monitor.Exit(_LOCKREF);
                        }
                    }
                }
                catch (Exception ex) { txtMessage.Text = ex.Message; }
            }
        }


        public void WriteTextSafe(string text)
        {
            if (txtMessage.InvokeRequired)
            {
                Action safeWrite = delegate { WriteTextSafe($"{text}"); };
                txtMessage.Invoke(safeWrite);
            }
            else
                txtMessage.Text = text;
        }


        private void btnStart_Click(object sender, EventArgs e)
        {
            if (btnStart.Text == "start")
            {
                addcount = 0;
                clearcount = 0;
                deletecount = 0;
                modifycount = 0;
                _runFlag = true;
                btnStart.Text = "stop";
                ProcessAsync();

            }
            else
            {
                _runFlag = false;
                btnStart.Text = "start";
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}
